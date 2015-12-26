using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageBuilderWizard
{
    class BuildPackagePrototype
    {
        // Cache previous context
        private static Dictionary<string, BuilderPackageInterface> userPreviousConfig = new Dictionary<string, BuilderPackageInterface>();

        //Rule to get Manual Maintaince And Declare Page
        public static BuilderPackageInterface getManualMaintainceAndDeclarePage()
        {

            if (userPreviousConfig.ContainsKey("getManualMaintainceAndDeclarePage"))
            {
                return userPreviousConfig["getManualMaintainceAndDeclarePage"];
            }

            XMLReader ContextValues = new XMLReader();
            ContextValues.parseXML();

            Prolog myProlog = new Prolog(ContextValues.prlg.Author, ContextValues.prlg.EmailID);
            PackageOperations myPackageOperations = new PackageOperations(ContextValues.packageOps);
            BuilderPackageInterface _ManualPage = new ManualPage(myProlog, myPackageOperations);

            ReqFiles myReqFiles = new ReqFiles(ContextValues.reqFiles);
            BuildProc myBuildProc = new BuildProc(ContextValues.buildProc);
            versionHistory myversionHistory = new versionHistory(ContextValues.version);
            Maintenance _Maintenance = new Maintenance(myReqFiles, myBuildProc, myversionHistory);

            DeclarClass myClass = new DeclarClass(ContextValues.ClassName);
            DeclarStruct myStruct = new DeclarStruct(ContextValues.Struct);
            DeclarDefine myDeclar = new DeclarDefine(null, myStruct);

            BuildPackage myContext = new BuildPackage();
            myContext.setBuildPackage(_ManualPage);
            myContext.setBuildPackage(_Maintenance);
            myContext.setBuildPackage(myDeclar);
            userPreviousConfig["getManualMaintainceAndDeclarePage"] = myContext;
            return myContext;
        }

        //Rule to get Define And TestStubPage
        public static BuilderPackageInterface getDefineAndTestStubPage()
        {

            if (userPreviousConfig.ContainsKey("getDefineAndTestStubPage"))
            {
                return userPreviousConfig["getDefineAndTestStubPage"];
            }

            XMLReader ContextValues = new XMLReader();
            ContextValues.parseXML();

            TestStub myTestStub = new TestStub(ContextValues.testStub);

            AddExpression myContext = new AddExpression();
            myContext.setAddExpression(null);
            myContext.setAddExpression(myTestStub);
            userPreviousConfig["getDefineAndTestStubPage"] = myContext;
            return myContext;
        }


        //Rule to test class or TestStub Page
        public static BuilderPackageInterface getclassOrTestStubPage()
        {

            if (userPreviousConfig.ContainsKey("getclassOrTestStubPage"))
            {
                return userPreviousConfig["getclassOrTestStubPage"];
            }

            XMLReader ContextValues = new XMLReader();
            ContextValues.parseXML();

            TestStub myTestStub = new TestStub(ContextValues.testStub);


            DeclarClass myClass = new DeclarClass(ContextValues.ClassName);
            DeclarStruct myStruct = new DeclarStruct(ContextValues.Struct);
            DeclarDefine myDeclar = new DeclarDefine(null, myStruct);


            OrExpression myContext = new OrExpression();

            myContext.setOrExpression(myTestStub);
            myContext.setOrExpression(myDeclar);

            userPreviousConfig["getclassOrTestStubPage"] = myContext;

            return myContext;
        }


        public static void writeToFile(string tmp,string fileName)
        {
            using (StreamWriter writetext = new StreamWriter(fileName))
            {
                writetext.WriteLine(tmp);
            }
        }
    }
}
