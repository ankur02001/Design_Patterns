using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageBuilderWizard
{
    class PackageNameSpace : BuilderPackageInterface
    {

        private BuilderPackageInterface _myClass= null;
        private BuilderPackageInterface _myStruct = null;

        String _packagenamspace = "";
        
        // Settting PackageNameSpace 
        public PackageNameSpace(String Packagenamspace, BuilderPackageInterface pkgInter1, BuilderPackageInterface pkgInter2)
        {
            _packagenamspace = Packagenamspace;
            _myClass = pkgInter1;
            _myStruct = pkgInter2;
        }

        // Returning PackageNameSpace String with class
        public override string buildPackage(XMLReader ContextValues)
        {
            string tmp = "\n\n\n" +
            "namespace " + _packagenamspace + " \n{";
            if (_myClass != null)
            {
                tmp += _myClass.buildPackage(ContextValues);
            }
            if (_myStruct != null)
            {
                tmp +=  _myStruct.buildPackage(ContextValues);
            }
            tmp += "\n}\n";
            return tmp;
        }

        // Cloning Object
        public override object clone()
        {
            if (_myStruct == null)
            {
                return new PackageNameSpace(_packagenamspace, (BuilderPackageInterface)_myClass.clone(), null);
            }
            else if (_myClass == null)
            {
                return new PackageNameSpace(_packagenamspace,null, (BuilderPackageInterface)_myStruct.clone());
            }
            else
            {
                return new PackageNameSpace(_packagenamspace, (BuilderPackageInterface)_myClass.clone(), (BuilderPackageInterface)_myStruct.clone());
            }
        }
    }
}
