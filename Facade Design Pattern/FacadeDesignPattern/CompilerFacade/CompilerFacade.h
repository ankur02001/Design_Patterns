
#ifndef COMPILERFACADE
#define COMPILERFACADE
///////////////////////////////////////////////////////////////////////
////  CompilerFacade.h                                               //
////                                                                 //
////  ver 1.0                                                        //
////  Language:      Visual C++ 2013                                 //
////  Platform:      Dell, Windows 8.1                               //
////  Application:   Facade Design Pattern Demo                      //
////  Author:		   Ankur Pandey                                  //
///////////////////////////////////////////////////////////////////////
//
/*
//Module Operations:
//==================
//This module defines a class that provides services necessary for  CompilerFacade interface.
//
*/
#include<iostream>
using namespace std;

class CompilerFacade {

public:

	// Making compile function pure virtual so that  dervied class must have to override for specific compilation subsystem
	virtual void compile(string sourceFile) = 0;

};
#endif