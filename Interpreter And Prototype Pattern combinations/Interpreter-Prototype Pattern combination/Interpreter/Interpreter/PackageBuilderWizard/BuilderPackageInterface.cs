using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageBuilderWizard
{
    // Interface for package Builder
    public abstract class BuilderPackageInterface
    {
        public abstract string buildPackage(XMLReader ContextValues);
        public abstract object clone();
    }
}
