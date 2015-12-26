
#ifndef JAVACOMPILERFACADE
#define JAVACOMPILERFACADE

///////////////////////////////////////////////////////////////////////
////  JavaCompilerFacade.h                                           //
////                                                                 //
////  ver 1.0                                                        //
////  Language:      Visual C++ 2013                                 //
////  Platform:      Dell, Windows 8.1                               //
////  Application:   Facade Design Pattern Demo                      //
////  Author:		   Ankur Pandey                                  //
///////////////////////////////////////////////////////////////////////
///*
//Module Operations:
//==================
//This module defines a class that provides services necessary to JavaCompilerFacade.
//*/
#include "../JavaCompilerSubSystem/JavaCompilerSubSystem.h"
#include "../CompilerFacade/CompilerFacade.h"

#include<iostream>
using namespace std;

class JavaCompilerFacade : public CompilerFacade {

public:

	// This override compile function from CompilerFacade to start compiling JAVA files
	void compile(string sourceFile) {
		cout << endl;
		JavaCompilerSubSys->JavaCompilerSubSystemComipled(sourceFile);
	}

private:

	// Uses JavaCompilerSubSystem
	JavaCompilerSubSystem *JavaCompilerSubSys = new JavaCompilerSubSystem();
};
#endif
