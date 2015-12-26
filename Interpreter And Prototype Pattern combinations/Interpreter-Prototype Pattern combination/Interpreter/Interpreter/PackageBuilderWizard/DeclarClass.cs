using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageBuilderWizard
{
    class DeclarClass : BuilderPackageInterface
    {
        private BuilderPackageInterface _myTestStub = null;

        // declare Class within namespace
        public  DeclarClass(BuilderPackageInterface myTestStub)
        {
            this._myTestStub = myTestStub;
        }

        // return class string
        public override string buildPackage(XMLReader ContextValues)
        { 
            string tmp = "\n" +
                         "\t\tpublic class " + ContextValues.ClassName + "\n\t\t{\n\n\n" +
                                  _myTestStub.buildPackage(ContextValues) +
                                "\t\t}";
            return tmp;
        }

        // clone object
        public override object clone()
        {
            return new DeclarClass((BuilderPackageInterface)_myTestStub.clone());
        }
    }
}
