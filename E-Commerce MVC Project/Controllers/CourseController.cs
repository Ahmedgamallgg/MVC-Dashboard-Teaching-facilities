using AutoMapper;
using BusinessLogicLayer.Interfaces;
using DataAccessLayer.Entities;
using E_Commerce_MVC_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_MVC_Project.Controllers
{
    public class CourseController : Controller
    {
        private readonly IUnitOFWork _UnitOFWork;
        private readonly IMapper _Mapper;

        public CourseController(IUnitOFWork unitOFWork, IMapper mapper)
        {
            _UnitOFWork = unitOFWork;
            _Mapper = mapper;
        }

        public IActionResult Index(string? Name)
        {
            IEnumerable<Course> courses;
            if(string.IsNullOrEmpty(Name))
                courses = _UnitOFWork.CourseRepositories.GetAll();
            else
                courses = _UnitOFWork.CourseRepositories.SearchByName(Name);


            var courseViewModel = _Mapper.Map<IEnumerable<CourseViewModel>>(courses);

            return View(courseViewModel);
        }
        public IActionResult Create()
        {
            ViewBag.Category = _UnitOFWork.CategoryRepositories.GetAll();
            ViewBag.Trainer = _UnitOFWork.TrainerRepositories.GetAll();
            return View(new CourseViewModel());
        }
        [HttpPost]
        public IActionResult Create(CourseViewModel model)
        {
            if(ModelState.IsValid)
            {
                var Course = _Mapper.Map<Course>(model);
                var result = _UnitOFWork.CourseRepositories.Add(Course);
                if(result >  0)
                    return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();

            var course = _UnitOFWork.CourseRepositories.GetById(id);

            if (course == null)
                return NotFound();

            var courseViewModel = _Mapper.Map<CourseViewModel>(course);
            
            
            ViewBag.Category = _UnitOFWork.CategoryRepositories.GetAll();
            ViewBag.Trainer = _UnitOFWork.TrainerRepositories.GetAll();
            return View(courseViewModel);
        }
        [HttpPost]
        public IActionResult Update(int id,CourseViewModel model)
        {
            if(id != model.Id)
                return NotFound();
            if (ModelState.IsValid)
            {
                var Course = _Mapper.Map<Course>(model);
                var result = _UnitOFWork.CourseRepositories.Add(Course);
                if (result > 0)
                    return RedirectToAction("Index");
            }
            return View(model);
        }

    }
}
