using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EisenVaultOutlookPlugin.Data.Entity
{
    public class ActionSettings
    {
        public Boolean DisableStandardSave { get; set; }
        public Boolean DisableDefaultdSave { get; set; }
        public Boolean DisableLastSave { get; set; }
    }
}
