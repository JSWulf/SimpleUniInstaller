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
    public class Program
    {
        public static void Main(string[] args)
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
                        ParamArg(arg);
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

        static public string Directory
        {
            get { return directory; }
            set { directory = value; }
        }

        public static void ParamArg(string arg)
        {
            string[] narg;
            string remQ = "";
            try
            {
                narg = arg.Split(':');
                remQ = narg[1].Replace("\"", "");
            }
            catch
            {
                //throw new Exception("Invalid Argument: " + arg);
                Console.WriteLine("Invalid Argument: " + arg);
            }
            

            Console.WriteLine(arg);
            Console.WriteLine(remQ);

            if (arg.Contains("/dir:"))
            {
                Directory = remQ;
            }

        }



    }
}
