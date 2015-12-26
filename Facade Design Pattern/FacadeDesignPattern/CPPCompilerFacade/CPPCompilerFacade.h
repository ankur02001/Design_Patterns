
#ifndef CPPCOMPILERFACADE
#define CPPCOMPILERFACADE

///////////////////////////////////////////////////////////////////////
////  CPPCompilerFacade.h                                            //
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
//This module defines a class that provides services necessary for  CPP CompilerFacade.
//
*/
#include "../Parser/Parser.h"
#include "../Assembler/Assembler.h"
#include "../Linker/Linker.h"
#include "../CompilerFacade/CompilerFacade.h"

#include<iostream>
using namespace std;

class CPPCompilerFacade : public CompilerFacade {

public:

	// This override compile function from CompilerFacade to start compiling JAVA files
	void compile(string sourceFile) {
		cout << endl;
		cout << endl;
		string orgSrcFile = sourceFile;
		parser->parse(sourceFile);
		sourceFile = compileInternal(sourceFile);
		sourceFile = assembler->assemble(sourceFile);
		sourceFile = linker->link(sourceFile);
		cout << endl;
		cout << "Successfully compiled " + orgSrcFile << endl;
		cout << "Final executable is " + sourceFile << endl;
	}

private:

	// This function handles compiler internals
	string compileInternal(string sourceFile) {
		
		sourceFile.replace(sourceFile.end() - 3, sourceFile.end(), "asm");

		cout << "Compiled to assembly " + sourceFile <<endl ;
		return sourceFile;
	}

	Parser *parser = new Parser();
	Assembler *assembler = new Assembler();
	Linker *linker = new Linker();
	
};
#endif#pragma once
#pragma once
