using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageBuilderWizard
{
    class BuilderPackagePrototype
    {
        // Cache previous context
        private static Dictionary<string, BuilderPackageInterface> userPreviousConfig = new Dictionary<string, BuilderPackageInterface>();

        //Rule to get Manual Maintaince And Declare Page
        public static BuilderPackageInterface getManualMaintainceAndDeclarePage()
        {

            if (userPreviousConfig.ContainsKey("getManualMaintainceAndDeclarePage"))
            {
                BuilderPackageInterface mybuildPkg = userPreviousConfig["getManualMaintainceAndDeclarePage"]; 
                return (BuilderPackageInterface)mybuildPkg.clone(); ;
            }

            Prolog myProlog = new Prolog();
            PackageOperations myPackageOperations = new PackageOperations();
            BuilderPackageInterface _ManualPage = new ManualPage(myProlog, myPackageOperations);

            ReqFiles myReqFiles = new ReqFiles();
            BuildProc myBuildProc = new BuildProc();
            versionHistory myversionHistory = new versionHistory();
            Maintenance _Maintenance = new Maintenance(myReqFiles, myBuildProc, myversionHistory);

            TestStub myTestStub = new TestStub();
            DeclarClass myClass = new DeclarClass(myTestStub);
            PackageNameSpace myPackageNameSpace = new PackageNameSpace("PackageBuilderTest", myClass, null);

            BuildPackage myContext = new BuildPackage();
            myContext.setBuildPackage(_ManualPage);
            myContext.setBuildPackage(_Maintenance);
            myContext.setBuildPackage(myPackageNameSpace);

            userPreviousConfig["getManualMaintainceAndDeclarePage"] = myContext;
            return myContext;
        }


        //Rule to get Manual Maintaince And Declare Page
        public static BuilderPackageInterface getManualPageAndStruct()
        {

            if (userPreviousConfig.ContainsKey("getManualPageAndStruct"))
            {
                BuilderPackageInterface mybuildPkg = userPreviousConfig["getManualPageAndStruct"];
                return (BuilderPackageInterface)mybuildPkg.clone(); ;
            }

            Prolog myProlog = new Prolog();
            PackageOperations myPackageOperations = new PackageOperations();
            BuilderPackageInterface _ManualPage = new ManualPage(myProlog, myPackageOperations);
            DeclarStruct myStruct = new DeclarStruct();

            BuildPackage myContext = new BuildPackage();
            myContext.setBuildPackage(_ManualPage);
            myContext.setBuildPackage(myStruct);
            userPreviousConfig["getManualPageAndStruct"] = myContext;
            return myContext;
        }



        // Writing to file
        public static void writeToFile(string tmp, string fileName)
        {
            using (StreamWriter writetext = new StreamWriter(fileName))
            {
                writetext.WriteLine(tmp);
            }
        }
    }
}
