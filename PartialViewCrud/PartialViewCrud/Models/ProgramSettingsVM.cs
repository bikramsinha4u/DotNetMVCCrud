using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialViewCrud.Models
{
    public class ProgramSettingsVM
    {
        public string System_Id { get; set; }
        public string Group_Name { get; set; }
        public string Setting_Name { get; set; }
        public string Value { get; set; }

        public ProgramSettingsVM() { }
        public ProgramSettingsVM(ProgramSettingsModel model)
        {
            this.System_Id = model.System_Id;
            this.Group_Name = model.Group_Name;
            this.Setting_Name = model.Setting_Name;
            this.Value = model.Value;
        }
    }
}