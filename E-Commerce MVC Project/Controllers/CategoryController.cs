using AutoMapper;
using BusinessLogicLayer.Interfaces;
using DataAccessLayer.Entities;
using E_Commerce_MVC_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_MVC_Project.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IMapper _Mapper;
        private readonly IUnitOFWork _UnitOFWork;

        public CategoryController(IMapper mapper, IUnitOFWork unitOFWork) 
        {
            _Mapper = mapper;
            _UnitOFWork = unitOFWork;
        }
        public IActionResult Index()
        {
            
            var  categories = _UnitOFWork.CategoryRepositories.GetAll();
            
            var categoryViewModel = _Mapper.Map<IEnumerable<CategoryViewModel>>(categories);

            return View(categoryViewModel);
        }
        public IActionResult Create()
        {
            
            return View(new CategoryViewModel());
        }
        [HttpPost]
        public IActionResult Create(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var category = _Mapper.Map<Category>(model);
                var result = _UnitOFWork.CategoryRepositories.Add(category);
                if (result > 0)
                    return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();

            var category = _UnitOFWork.CategoryRepositories.GetById(id);

            if (category == null)
                return NotFound();

            var categoryViewModel = _Mapper.Map<CategoryViewModel>(category);

            return View(categoryViewModel);
        }
        [HttpPost]
        public IActionResult Update(int id, CategoryViewModel model)
        {
            if (id != model.Id)
                return NotFound();
            if (ModelState.IsValid)
            {
                var category = _Mapper.Map<Category>(model);
                var result = _UnitOFWork.CategoryRepositories.Add(category);
                if (result > 0)
                    return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
