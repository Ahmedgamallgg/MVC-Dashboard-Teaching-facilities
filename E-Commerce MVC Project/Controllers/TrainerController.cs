using AutoMapper;
using BusinessLogicLayer.Interfaces;
using DataAccessLayer.Entities;
using E_Commerce_MVC_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_MVC_Project.Controllers
{
    public class TrainerController : Controller
    {
        private readonly IUnitOFWork _UnitOFWork;
        private readonly IMapper _Mapper;

        public TrainerController(IUnitOFWork unitOFWork, IMapper mapper)
        {
            _UnitOFWork = unitOFWork;
            _Mapper = mapper;
        }
        public IActionResult Index(string? name)
        {
            IEnumerable<Trainer> trainers;
            if (string.IsNullOrEmpty(name))
                trainers = _UnitOFWork.TrainerRepositories.GetAll();
            else
                trainers =_UnitOFWork.TrainerRepositories.GetByName(name);
            
            var trainersVM = _Mapper.Map<IEnumerable<TrainerViewModel>>(trainers);

            return View(trainersVM);
        }
        
        public IActionResult Create()
        {
            return View(new TrainerViewModel());
        }

        [HttpPost]
        public IActionResult Create(TrainerViewModel model)
        {
            if (ModelState.IsValid)
            {
                var trainer = _Mapper.Map<Trainer>(model);
                if (trainer != null)
                {
                    var result = _UnitOFWork.TrainerRepositories.Add(trainer);
                    if (result > 0)
                        return RedirectToAction("Index");
                }

            }
            return View(model);
        }
        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();

            var trainer = _UnitOFWork.TrainerRepositories.GetById(id);

            if (trainer == null)
                return NotFound();

            var trainerVW = _Mapper.Map<TrainerViewModel>(trainer );

            return View(trainerVW);
        }
        [HttpPost]
        public IActionResult Update(int id, TrainerViewModel model)
        {
            if (id != model.Id)
                return NotFound();
            if (ModelState.IsValid)
            {
                var trainer = _Mapper.Map<Course>(model);
                var result = _UnitOFWork.CourseRepositories.Add(trainer);
                if (result > 0)
                    return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
