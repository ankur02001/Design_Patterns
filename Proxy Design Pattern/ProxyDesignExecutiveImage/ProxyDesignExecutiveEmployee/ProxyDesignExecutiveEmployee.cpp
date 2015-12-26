#ifndef EXE_PROXYEMPLOYEEDESIGNPATTERN
#define EXE_PROXYEMPLOYEEDESIGNPATTERN
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

#include<iostream>
#include<string>
#include<iostream>
#include "../Employee/Employee.h";

using namespace std;

int main() {

	// Setting Report Genertor for Manager
	Owner *owner = new Owner();
	ReportGeneratorProxy *reportGenerator = new ReportGeneratorProtectionProxy(owner);
	owner->setReportGenerator(reportGenerator);

	// Setting Report Genertor for Normal Employee
	Employee *employee = new Employee();
	reportGenerator = new ReportGeneratorProtectionProxy(employee);
	employee->setReportGenerator(reportGenerator);


	// Manager Generating Daily Report
	cout <<   " Manager Generating Daily Report :" <<endl;
	cout << owner->generateDailyReport() << endl<<endl;

	//Normal Employee Generating Daily Report
	cout << " Normal Employee Generating Daily Report :" << endl;
	cout << employee->generateDailyReport() << endl <<endl;

	int a;
	cin >> a;
}
#endif