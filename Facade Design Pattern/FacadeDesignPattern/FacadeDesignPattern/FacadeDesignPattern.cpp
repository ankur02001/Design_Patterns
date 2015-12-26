#ifndef EXE_FACADEDESIGNPATTERN
#define EXE_FACADEDESIGNPATTERN
///////////////////////////////////////////////////////////////////////
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
//This module defines a class that provides services necessary for  client.
//
*/
#include "../JavaCompilerFacade/JavaCompilerFacade.h"
#include "../CPPCompilerFacade/CPPCompilerFacade.h"

#include<iostream>
using namespace std;
#include<vector>

int main() {

	cout << "*********************************************" << endl;
	cout << "FACADE DESIGN PATTERN CODE DEMO" << endl;
	cout << "*********************************************" << endl;

	cout << "Compiling Cpp file" << endl;

	CompilerFacade   *CompilerFaca = new CPPCompilerFacade();
	CompilerFaca->compile("C:/Mydirectory/test.cpp");

	cout << endl;

	cout << "Compiling Java file" << endl;
	CompilerFacade *javafacade = new JavaCompilerFacade();
	javafacade->compile("C:/Mydirectory/test.java");


	int a;
	cin >> a;
	return 0;


}
#endif