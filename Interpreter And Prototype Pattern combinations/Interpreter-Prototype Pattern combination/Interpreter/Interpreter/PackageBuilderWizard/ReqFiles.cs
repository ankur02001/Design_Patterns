using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageBuilderWizard
{
    class ReqFiles : BuilderPackageInterface
    {
        // Returning Required files String
        public override string buildPackage(XMLReader ContextValues)
        {
            List<String> Reqfile = ContextValues.reqFiles;
            string strTmp = "/*\n* \n" +
                        "*   Required Files \n" +
                        "*   ---------------- \n";
            foreach (var ReqfileItr in Reqfile){
                             strTmp += "*   " + ReqfileItr + "" +"\n";
            }
            strTmp +=         "*\n*/\n";
            return strTmp;
        }

        //clone object
        public override object clone()
        {
            return new ReqFiles();
        }
    }
}
