using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageBuilderWizard
{
    class MainExecutive
    {

        static void Main(string[] args)
        {
            Console.WriteLine("\n\n  Testing build Package \n\n");
            // Get Context from Xml file
            XMLReader ContextValues = new XMLReader();
            ContextValues.parseXML();

            // GetRuleForCreation
            BuilderPackageInterface mybuildPkg_4 = BuilderPackagePrototype.getManualPageAndStruct();

            // Displaying to console
            Console.WriteLine(mybuildPkg_4.buildPackage(ContextValues));


            // GetRuleForCreation
            BuilderPackageInterface mybuildPkg_1 = BuilderPackagePrototype.getManualMaintainceAndDeclarePage();
            BuilderPackagePrototype.writeToFile(mybuildPkg_1.buildPackage(ContextValues), "TesetingInterpreter.cs");

            // cloning builder package
            BuilderPackageInterface mybuildPkg_2 = BuilderPackagePrototype.getManualMaintainceAndDeclarePage();
            BuilderPackagePrototype.writeToFile(mybuildPkg_2.buildPackage(ContextValues), "TesetingPrototype.cs");

           
            Console.WriteLine("\n");

        }
    }
}
