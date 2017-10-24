using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUniInstaller
{
    public class Installer
    {
        public Installer(string config)
        {
            ReadConfig(config);
        }

        public string CompanyName { get; set; }
        public string SoftwareName { get; set; }
        public string InstallDirectory { get; set; }

        private void ReadConfig(string file)
        {

        }

        private void CopyDirectory()
        {

        }

        private void CreateShortcuts()
        {

        }

    }
}
