using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageBuilderWizard
{
    class PackageOperations : BuilderPackageInterface
    {
        // Return Module Operations string
        public override string buildPackage(XMLReader ContextValues)
        {

 
            string tmp = "/*\n" + 
                        "*   Module Operations\n" +
                        "*   -----------------\n" +
                        "*   This module demonstrates ....... \n*\n" +
                        "*   Public Interface\n" +
                        "*   ---------------- \n" +
                        "*       "+ContextValues.packageOps + "\n" +
                        "* \n*/";
                return tmp;
        }

        // clone object
        public override object clone()
        {
            return new PackageOperations();
        }
    }
}
