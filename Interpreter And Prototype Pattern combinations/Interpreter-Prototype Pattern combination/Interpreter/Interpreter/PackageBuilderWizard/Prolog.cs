using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageBuilderWizard 
{
    class Prolog : BuilderPackageInterface
    {
        // return Prolog string
        public override string buildPackage(XMLReader ContextValues)
        {
            string tmp = "/*\n" +
            "//////////////////////////////////////////////\n" +
            "                                              \n" +
            "    Author:  "+ ContextValues.prlg.Author +  "\n" +
            "             "+ ContextValues.prlg.EmailID + "\n" +
            "                                              \n" +
            "//////////////////////////////////////////////\n*/\n";

            return tmp;
        }

        // clone Object
        public override object clone()
        {
            return new Prolog();
        }
    }
}
