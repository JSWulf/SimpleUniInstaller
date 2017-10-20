using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleUniInstaller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUniInstaller.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void ParamArgTest()
        {
            Program.ParamArg(@"/test:""this is a\test!for@the-fair""");

            Program.ParamArg(@"/test:this is a\test!for@the-fair with no quotes");
            
            Program.ParamArg(@"/test");
            

            Assert.IsTrue(true);
        }
    }
}