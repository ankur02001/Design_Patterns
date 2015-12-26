#pragma once

#ifndef LINKER
#define LINKER
/////////////////////////////////////////////////////////////////////
//  Linker.h                                                       //
//                                                                 //
//  ver 1.0                                                        //
//  Language:      Visual C++ 2013                                 //
//  Platform:      Dell, Windows 8.1                               //
//  Application:   Facade Design Pattern Demo                      //
//  Author:		   Ankur Pandey                                    //
/////////////////////////////////////////////////////////////////////
/*
Module Operations:
==================
This module defines a class that provides services necessary to Linker.
*/
#include<iostream>
using namespace std;
#include<string>

class Linker {

public:
	
	// This function takes .obj file and converts into .exe
	string link(string sourceFile) {
		
		sourceFile.replace(sourceFile.end() - 3, sourceFile.end(), "exe");
		
		cout << "Linked to executable " + sourceFile << endl;
		return sourceFile;
	}

};
#endif