﻿using Assignment5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Components
{
    //Class for dynamic navigation menu
    public class NavigationMenuViewComponent : ViewComponent
    {

        private IBookRepository repository;

        public NavigationMenuViewComponent(IBookRepository repo)
        {
            repository = repo;
        }
        //Dynamically builds category navbar
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(repository.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
