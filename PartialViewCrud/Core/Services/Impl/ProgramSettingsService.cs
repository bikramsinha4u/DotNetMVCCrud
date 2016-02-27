using Core.Data;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Impl
{
    public class ProgramSettingsService : IProgramSettingsService
    {
        private ProgramSettingsDA programSettingsDA = new ProgramSettingsDA();

        public List<ProgramSettingsModel> GetProgramSettings()
        {
            return programSettingsDA.GetProgramSettings();
        }

        public Boolean GetProgramSettingsById(string id)
        {
            return programSettingsDA.GetProgramSettingsById(id);
        }

        public string Create(string system_id, string group_name, string setting_name, string value)
        {
            return programSettingsDA.Create(system_id, group_name, setting_name, value);
        }
        public string Edit(string system_id, string group_name, string setting_name, string value)
        {
            return programSettingsDA.Edit(system_id, group_name, setting_name, value);
        }

        public string Delete(string id)
        {
            return programSettingsDA.Delete(id);
        }
    }
}
