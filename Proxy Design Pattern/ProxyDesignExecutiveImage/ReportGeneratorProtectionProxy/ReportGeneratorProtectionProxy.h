#ifndef PROXY_EMPLOYDESIGNPATTERN
#define PROXY_EMPLOYDESIGNPATTERN
///////////////////////////////////////////////////////////////////////
////                                                                 //
////  ver 1.0                                                        //
////  Language:      Visual C++ 2013                                 //
////  Platform:      Dell, Windows 8.1                               //
////  Application:   Proxy Design Pattern Demo                       //
////  Author:		   Ankur Pandey                                  //
///////////////////////////////////////////////////////////////////////
//
/*
//Module Operations:
//==================
//This module defines a class that provides services necessary for  client.
//
*/

#include<string>
using namespace std;

#include "../Employee/Employee.h";

class ReportGeneratorProxy {
public:
	virtual string generateDailyReport() = 0;
};

class ReportGeneratorProtectionProxy : public ReportGeneratorProxy {
private:
	Staff *staff;

public:

	ReportGeneratorProtectionProxy(Staff *staff) {
		this->staff = staff;
	}

	string generateDailyReport() {
		if (staff->isOwner()) {
			string report = " ********************Location X Daily Report********************\n ";

				/*	03               \n \
					Location ID : 012   \n  \
					04                     \n   \
					Today's Date: Sun Sep 14 13:28:12 IST 2014   \n \
					05              \n  \
					Total Pizza Sell : 112      \n    \
					06        \n   \
                   					Total Sale : $2534    \n  \
					07    \n  \
					Net Profit : $1985     \n \
					08          \n  \
					*************************************************************** \n\n"; 
			*/
			return report;
		}
		else {
			return "Not Authorized to view report.";
		}
	}
};
#endif