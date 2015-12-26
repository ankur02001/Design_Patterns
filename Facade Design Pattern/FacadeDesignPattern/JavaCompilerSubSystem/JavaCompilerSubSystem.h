//#pragma once
///////////////////////////////////////////////////////////////////////
////  JavaCompilerSubSystem.h                                        //
////                                                                 //
////  ver 1.0                                                        //
////  Language:      Visual C++ 2013                                 //
////  Platform:      Dell, Windows 8.1                               //
////  Application:   Facade Design Pattern Demo                      //
////  Author:		   Ankur Pandey                                    //
///////////////////////////////////////////////////////////////////////
///*
//Module Operations:
//==================
//This module defines a class that provides services necessary to JavaCompilerSubSystem.
//*/
#include<string>
#include<iostream>
using namespace std;

class JavaCompilerSubSystem {

public:

	// This function handles compilation  in java
	void JavaCompilerSubSystemComipled(string sourceFile) {
		string orgSrcFile = sourceFile;
		cout << "Parsing   " + sourceFile << endl;
		cout << "Converting to byte code " << endl;

		sourceFile.replace(sourceFile.end() - 4, sourceFile.end(), "class");
		
		cout << "Generated .class files : " + sourceFile << endl;
	

		cout << endl;
		cout << "Successfully compiled " + orgSrcFile << endl;
	}

};
