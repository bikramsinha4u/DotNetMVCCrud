using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IProgramSettingsService
    {
        List<ProgramSettingsModel> GetProgramSettings();

        Boolean GetProgramSettingsById(string id);

        string Create(string system_id, string group_name, string setting_name, string value);

        string Edit(string system_id, string group_name, string setting_name, string value);

        string Delete(string id);
    }
}
