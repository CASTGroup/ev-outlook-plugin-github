using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EisenVaultOutlookPlugin.Data.Entity
{
    public class DirectorySettings
    {
        public String DefaultFolder { get; set; }
        public String DefaultFolderTag { get; set; }
        public String LastUsedFolder { get; set; }
        public String LastUsedFolderTag { get; set; }

    }
}
