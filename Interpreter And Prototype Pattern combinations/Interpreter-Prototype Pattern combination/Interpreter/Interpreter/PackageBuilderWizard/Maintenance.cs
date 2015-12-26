using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageBuilderWizard
{
    public class Maintenance : BuilderPackageInterface
    {


        private BuilderPackageInterface _ReqFiles = null;
        private BuilderPackageInterface _BuildProc = null;
        private BuilderPackageInterface _VersionHistory = null;


        // Settting Maintenance Page 
        public Maintenance(BuilderPackageInterface pkgInter1, BuilderPackageInterface pkgInter2 , BuilderPackageInterface pkgInter3)
        {
            _ReqFiles = pkgInter1;
            _BuildProc = pkgInter2;
            _VersionHistory = pkgInter3;
        }

        // Returning Maintenance Page String
        public override string buildPackage(XMLReader ContextValues)
        {
             string tmp = "";
            if (_ReqFiles != null)
            {
                tmp += _ReqFiles.buildPackage(ContextValues);
            }
            if (_BuildProc != null)
            {
                tmp += _BuildProc.buildPackage(ContextValues);
            }
            if (_VersionHistory != null)
            {
                tmp += _VersionHistory.buildPackage(ContextValues);
            }
            return tmp;
        }

        // Cloning Object
        public override object clone()
        {
            return new Maintenance((BuilderPackageInterface)_ReqFiles.clone(), 
                (BuilderPackageInterface)_BuildProc.clone(), (BuilderPackageInterface)_VersionHistory.clone());
        }
    }
}
