using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinGet_GUI
{
    class UpgradeableApp
    {
        private string name;
        private string id;
        private decimal version;
        private decimal available;
        private string source;

        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public decimal Version { get => version; set => version = value; }
        public decimal Available { get => available; set => available = value; }
        public string Source { get => source; set => source = value; }
    }
}
