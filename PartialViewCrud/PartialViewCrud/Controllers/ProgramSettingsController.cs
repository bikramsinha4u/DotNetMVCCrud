using Core.Services;
using PartialViewCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialViewCrud.Controllers
{
    public class ProgramSettingsController : Controller
    {
        private readonly IProgramSettingsService programSettingsService;

        public ProgramSettingsController(IProgramSettingsService ips)
        {
            this.programSettingsService = ips;
        }

        // GET: /ProgramSettings/
        public ActionResult Index()
        {
            var vm = new List<ProgramSettingsVM>();
            var result = this.programSettingsService.GetProgramSettings();

            foreach (var item in result)
            {
                vm.Add(new ProgramSettingsVM(item));
            }

            ViewData["Message"] = TempData["Message"];
            return View(vm);
        }

        // POST: /ProgramSettings/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            var itemPresent = this.programSettingsService.GetProgramSettingsById(collection["system-id"]); 
            
            if (itemPresent == true)
                TempData["Message"] = Edit(collection);
            else
                try
                {
                    // TODO: Add insert logic here
                    string system_id = collection["system-id"];
                    string group_name = collection["group-name"];
                    string setting_name = collection["setting-name"];
                    string value = collection["value"];

                    var result = this.programSettingsService.Create(system_id, group_name, setting_name, value);

                    TempData["Message"] = "Added Successfully.";

                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }

            return RedirectToAction("Index");
        }

        // POST: /ProgramSettings/Edit/5
        [HttpPost]
        public string Edit(FormCollection collection)
        {
            string result = null;
            try
            {
                // TODO: Add update logic here
                string system_id = collection["system-id"];
                string group_name = collection["group-name"];
                string setting_name = collection["setting-name"];
                string value = collection["value"];

                result = this.programSettingsService.Edit(system_id, group_name, setting_name, value);
            }
            catch
            {
                //return View();
            }

            return "Updated Successfully.";
        }

        // POST: /ProgramSettings/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var result = this.programSettingsService.Delete(id);
                TempData["Message"] = "Deleted Successfully.";

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
