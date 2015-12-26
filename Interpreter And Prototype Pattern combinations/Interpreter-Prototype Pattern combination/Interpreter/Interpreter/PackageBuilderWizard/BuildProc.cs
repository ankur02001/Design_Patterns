using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageBuilderWizard
{
     class BuildProc : BuilderPackageInterface
    {
        // Return Build Process String
        public override string buildPackage(XMLReader ContextValues)
        {

            List<String> Reqfile = ContextValues.reqFiles;
            string tmp = "/*\n" +
                    "*   Build Process \n" +
                    "*   -----------------\n" +
                    "*   - Compiler command: " + ContextValues.buildProc;
                     foreach (var ReqfileItr in Reqfile)
                     {
                  //  tmp += " " + ReqfileItr + "" ;
                     }
            tmp += "\n* \n*/";
            return tmp;
        }

        // Clone object
        public override object clone()
        {
            return new BuildProc();
        }
    }
}
