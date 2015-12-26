#pragma once
/////////////////////////////////////////////////////////////////////
//  Scanner.h                                                      //
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
This module defines a class that provides services necessary to Parse.
*/

#ifndef SCANNER_H
#define SCANNER_H

#include<string>
#include<iostream>
using namespace std;

class Scanner {

public:
	
	//This Function scan CPP file 
	void scan(string sourceFile) {
		std::cout << "Started CPP FIle scanning " << sourceFile << endl;
	}
};
#endif