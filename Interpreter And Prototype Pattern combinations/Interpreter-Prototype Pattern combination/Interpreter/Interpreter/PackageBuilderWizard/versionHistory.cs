using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageBuilderWizard
{
    class versionHistory : BuilderPackageInterface
    {
        // Returning Maintenance History String
        public override string buildPackage(XMLReader ContextValues)
        {
            List<String> versionHistry = new List<String>();
            versionHistry.Add(ContextValues.version);
            string strTmp = "\n/*\n* \n" +
                        "*   Maintenance History \n" +
                        "*   ---------------- \n";
            foreach (var versionHistryItr in versionHistry)
            {
                strTmp += "*   " + versionHistryItr + "" + "\n";
            }
            strTmp += "*\n*/";
            return strTmp;
        }

        // clone object
        public override object clone()
        {
            return new versionHistory();
        }
    }
    
}
