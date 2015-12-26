#pragma once

#ifndef PARSER_H
#define PARSER_H

/////////////////////////////////////////////////////////////////////
//  Parser.h                                                       //
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
#include<iostream>
using namespace std;
#include<string>
#include "../Scanner/Scanner.h"

 class Parser {

 private :
	 Scanner scanner ;

 public:

	 // This function takes .asm file and converts into .obj
	 void parse(string sourceFile) {

			 scanner.scan(sourceFile);
	
			 cout << "Started CPP parsing " + sourceFile << endl;

			 sourceFile.replace(sourceFile.end()-3, sourceFile.end(), "obj");
	}

};
#endif