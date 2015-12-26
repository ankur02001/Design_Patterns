using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageBuilderWizard
{
    class DeclarStruct : BuilderPackageInterface
    {
        // return Struct string within namespace
        public override string buildPackage(XMLReader ContextValues)
        {
            string tmp = "\n\n" +
                         "\t\tstruct " + ContextValues.Struct  +
                         "\t\t{ \n\n\n\t\t}\n";
            return tmp;
        }

        // clone object
        public override object clone()
        {
            return new DeclarStruct();
        }
    }
}
