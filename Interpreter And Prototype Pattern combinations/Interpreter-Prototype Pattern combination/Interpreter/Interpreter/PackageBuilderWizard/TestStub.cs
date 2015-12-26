using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageBuilderWizard
{
    public class TestStub : BuilderPackageInterface
    {
        // Return test stub string
        public override string buildPackage(XMLReader ContextValues)
        { 
            string tmp = "\n\n" +
                          "#if ("+ ContextValues.testStub +") \n" +
                          "\t\t\t\tstatic void Main(string[] args){\n\n \t\t\t\t}\n" +
                          "#endif\n\n";
            return tmp;
        }

        // clone object
        public override object clone()
        {
            return new TestStub();
        }
    }
}
