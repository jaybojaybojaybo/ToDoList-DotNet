﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoList.Controllers
{
    public class ItemsController : Controller
    {
        private ToDoListContext db = new ToDoListContext();

        public IActionResult Index()
        {
            return View(db.Items.ToList());
        }
        public IActionResult Details(int id)
        {
            Item thisItem = db.Items.FirstOrDefault(items => items.ItemId == id);
            return View(thisItem);
        }
    }
}
