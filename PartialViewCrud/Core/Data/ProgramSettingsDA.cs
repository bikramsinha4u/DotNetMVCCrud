using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
    public class ProgramSettingsDA
    {
        //private readonly IDbConnection connection;

        //public ProgramSettingsDA(OracleDbConnectionProvider connectionProvider)
        //{
        //    this.connection = connectionProvider.GetOpenConnection();
        //}

        public static List<ProgramSettingsModel> model = new List<ProgramSettingsModel>()
        {   new ProgramSettingsModel { System_Id = "collection", Group_Name = "6789", Setting_Name = "window", Value = "yellow" },
            new ProgramSettingsModel { System_Id = "Collection2", Group_Name = "5643", Setting_Name = "task", Value = "blue" },
        };

        internal List<ProgramSettingsModel> GetProgramSettings()
        {
            return model;
        }

        internal Boolean GetProgramSettingsById(string id)
        {
            var item = model.Find(r => r.System_Id == id);

            if (item != null)
                return true;
            else
                return false;
        }

        internal string Create(string system_id, string group_name, string setting_name, string value)
        {
            var temp = new ProgramSettingsModel() { System_Id = system_id, Group_Name = group_name, Setting_Name = setting_name, Value = value };
            model.Add(temp);

            return "Success";
        }

        internal string Edit(string system_id, string group_name, string setting_name, string value)
        {
            var itemToUpdate = model.Single(r => r.System_Id == system_id);
            itemToUpdate.Group_Name = group_name;
            itemToUpdate.Setting_Name = setting_name;
            itemToUpdate.Value = value;

            return "Success";
        }

        internal string Delete(string id)
        {
            var itemToRemove = model.Single(r => r.System_Id == id);
            model.Remove(itemToRemove);

            return "Success";
        }        
    }
}
