#ifndef PROXY__Emply_EMPLOYDESIGNPATTERN
#define PROXY__Emply_EMPLOYDESIGNPATTERN

#include<string>

using namespace std;

// Report Generation Interface
class ReportGeneratorProxy {
public:
	virtual string generateDailyReport() = 0;
};

// Staff Interface
class  Staff {
public :
	virtual bool isOwner()=0;
	virtual void setReportGenerator(ReportGeneratorProxy *reportGenerator)=0;
};

// Employee Concerete class
 class Employee : public Staff {
 private :
	 ReportGeneratorProxy *reportGenerator;

 public :
	 // set setReportGenerator
	 void setReportGenerator(ReportGeneratorProxy *reportGenera) {
		this->reportGenerator = reportGenera;
	}
	 
	 //check owner
	 bool isOwner() {
		return false;
	}
	 
	 //generates Daily Report
	 string generateDailyReport() {
			return reportGenerator->generateDailyReport();
	}
 };

 // Owner Class
 class Owner : public Staff {
 private :
	 bool isOwnerrr = true;
	 ReportGeneratorProxy *reportGenerator;
 public :

	 // set setReportGenerator
	 void setReportGenerator(ReportGeneratorProxy *reportGenera) {
		this->reportGenerator = reportGenera;
	}
	
	 //check owner
	bool isOwner() {
		return isOwnerrr;
	}

	//generates Daily Report
	string generateDailyReport() {
			return reportGenerator->generateDailyReport();
	}
 };

 // ReportGenerator Class
 class ReportGenerator : public ReportGeneratorProxy {
 public:
	 ReportGenerator() {}

	 //generates Daily Report
	 string generateDailyReport() {
		 string report = " ********************Location X Daily Report********************\n "
			 "\t 03 \n"
			 "\t ocation ID : 012   \n"
			 "\t 04  \n"
			 "\t Today's Date: Sun Sep 14 13:28:12 IST 2014   \n"
			 "\t 05 \n"
			 "\t Total Pizza Sell : 112  \n"
			 "\t 06 \n"
			 "\t Total Sale : $2534    \n"
			 "\t 07    \n"
			 "\t Net Profit : $1985     \n "
			 "\t 08          \n  "
			 "*************************************************************** \n\n ";
		 return report;
	 }
 };

 // Report Generation Protection Proxy
 
 class ReportGeneratorProtectionProxy : public ReportGeneratorProxy {
 private:
	 Staff *staff;
	 ReportGenerator *ReportGeneratorr = nullptr;

 public:

	 ReportGeneratorProtectionProxy(Staff *staff) {
		 this->staff = staff;
		 ReportGeneratorr = new ReportGenerator();
	 }

	 //generates Daily Report
	 string generateDailyReport() {
		 if (staff->isOwner()) {
			 return ReportGeneratorr->generateDailyReport();
		 }
		 else {
			 return "Not Authorized to view report.";
		 }
	 }
 };

 
#endif

