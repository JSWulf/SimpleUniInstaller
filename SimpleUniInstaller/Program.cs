using System;
using System.IO;
using System.IO.Compression;
using Microsoft.Deployment.Compression.Zip;
using Microsoft.Deployment.Compression.Cab;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleUniInstaller
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach (var arg in args)
            {
                switch (arg.ToLower())
                {
                    case (@"/uninstall"):
                        // uninstaller
                        break;
                    case (@"/silent"):
                        // silent install
                        break;
                    case (@"/?"):
                        // help
                        break;
                    case(@"/extract"):
                        // Extract files to running directory
                        break;
                    case (@"/make"):
                        // read setup.config for install folder, company, product, copyright, shortcut, prereqs?.
                        break;
                    default:
                        //check for parameter arguments
                        break;
                }
            }

        }
        static public bool uninstall { get; set; }
        static public bool silent { get; set; }
        static public bool help { get; set; }
        static public bool extract { get; set; }
        static public bool make { get; set; }

        static private string directory;

        public string Directory
        {
            get { return directory; }
            set { directory = value; }
        }




    }
}
