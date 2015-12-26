using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageBuilderWizard
{
    public class BuildPackage : BuilderPackageInterface
    {
        private List<BuilderPackageInterface> _BuilderPackageAddExpression = new List<BuilderPackageInterface>();

        // Settting Builder Package
        public void setBuildPackage(BuilderPackageInterface pkgInter){
            if(pkgInter !=null)
            _BuilderPackageAddExpression.Add(pkgInter); 
        }

        // Returning Builder String
        public override string buildPackage(XMLReader ContextValues)
        {
            string strTmp = "\n";
            foreach (var pkgInterItr in _BuilderPackageAddExpression)
            {
                strTmp += "" + pkgInterItr.buildPackage(ContextValues) + "" + "\n";
            }
          
            return strTmp;
        }

        // Cloning Object
        public override Object clone()
        {
            BuildPackage buildPackageClone = new BuildPackage();
         
            foreach (var pkgInterItr in _BuilderPackageAddExpression)
            {
                buildPackageClone.setBuildPackage((BuilderPackageInterface)pkgInterItr.clone());
            }
            return buildPackageClone;
        }
    }
}
