using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageBuilderWizard
{
    public class ManualPage : BuilderPackageInterface
    {

        private BuilderPackageInterface _myProlog = null;
        private BuilderPackageInterface _myPackageOperations = null;

        // Settting Manual Page 
        public ManualPage(BuilderPackageInterface pkgInter1, BuilderPackageInterface pkgInter2)
        {
            _myProlog = pkgInter1;
            _myPackageOperations = pkgInter2;
        }

        // Returning Manual Page String
        public override string buildPackage(XMLReader ContextValues)
        {
            string tmp = "";
            if (_myProlog != null)
            {
                tmp += _myProlog.buildPackage(ContextValues);
            }
            if (_myPackageOperations != null)
            {
                tmp += _myPackageOperations.buildPackage(ContextValues);
            }
            return tmp;
        }

        // Cloning Object
        public override object clone()
        {
            return new ManualPage((BuilderPackageInterface)_myProlog.clone(), (BuilderPackageInterface)_myPackageOperations.clone());
        }
    }
}
