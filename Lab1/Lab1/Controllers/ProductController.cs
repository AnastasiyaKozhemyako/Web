using Lab1.DAL.Entities;
using Lab1.Extensions;
using Lab1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab1.DAL.Data;
using Lab1.DAL.Entities;
using Microsoft.Extensions.Logging;

namespace Lab1.Controllers
{
    public class ProductController : Controller
    {
        private List<Dish> _dishes;
        private List<DishGroup> _dishGroups;
        ApplicationDbContext _context;

        int _pageSize;

        private ILogger _logger;

        public ProductController(ApplicationDbContext context)
        {
        }

        public ProductController(ApplicationDbContext context,
        ILogger<ProductController> logger)
        {
            _pageSize = 3;
            _context = context;
            _logger = logger;
        }
        
                //public ProductController(ApplicationDbContext context)
                //{
                //    _pageSize = 3;
                //    _context = context;
                //}
                //public ProductController()
                //{
                //    _pageSize = 3;
                //    SetupData();
                //}

                [Route("Catalog")]
        [Route("Catalog/Page_{pageNo}")]
        public IActionResult Index(int? group, int pageNo)
        {
            var groupMame = group.HasValue
            ? _context.DishGroups.Find(group.Value)?.GroupName
            : "all groups";
            //_logger.LogInformation($"info: group={group}, page={pageNo}");
            var dishesFiltered = _context.Dishes
            .Where(d => !group.HasValue || d.DishGroupId == group.Value);
            // Поместить список групп во ViewData
            ViewData["Groups"] = _context.DishGroups;
                // Получить id текущей группы и поместить в TempData
                ViewData["CurrentGroup"] = group ?? 0;


            var model = ListViewModel<Dish>.GetModel(dishesFiltered, pageNo,
_pageSize);
            if (Request.IsAjaxRequest())
                return PartialView("_listpartial", model);
           
            else
                return View(model);


        }

        //{
        //    return View(_dishes);
        //}
        /// <summary>
        /// Инициализация списков
        /// </summary>
        private void SetupData()
        {
            _dishGroups = new List<DishGroup>
 {
 new DishGroup {DishGroupId=1, GroupName="Стартеры"},
 new DishGroup {DishGroupId=2, GroupName="Салаты"},
 new DishGroup {DishGroupId=3, GroupName="Супы"},
 new DishGroup {DishGroupId=4, GroupName="Основные блюда"},
 new DishGroup {DishGroupId=5, GroupName="Напитки"},
 new DishGroup {DishGroupId=6, GroupName="Десерты"}
 };
            _dishes = new List<Dish>
 {
 new Dish {DishId = 1, DishName="Суп-харчо",
Description="Очень острый, невкусный",
Calories =200, DishGroupId=3, Image="harcho.jpg" },
new Dish { DishId = 2, DishName="Борщ",
Description="Много сала, без сметаны",
Calories =330, DishGroupId=3, Image="Borsh.jpg" },
new Dish { DishId = 3, DishName="Котлета пожарская",
Description="Хлеб - 80%, Морковь - 20%",
Calories =635, DishGroupId=4, Image="Cocl.jpg" },
new Dish { DishId = 4, DishName="Макароны по-флотски",
Description="С охотничьей колбаской",
Calories =524, DishGroupId=4, Image="Macaron.jpg" },
new Dish { DishId = 5, DishName="Компот",
Description="Быстро растворимый, 2 литра",
Calories =180, DishGroupId=5, Image="Campot.jpg" }
 };
        }
    }
}

