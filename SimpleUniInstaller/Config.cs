using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUniInstaller
{
    public class Config
    {
        public Config(string file)
        {
            ReadFile(file);
        }

        public string CompanyName { get; private set; }
        public string SoftwareName { get; private set; }
        public string InstallDir { get; private set; }

        private void ReadFile(string file)
        {

        }
    }
}
