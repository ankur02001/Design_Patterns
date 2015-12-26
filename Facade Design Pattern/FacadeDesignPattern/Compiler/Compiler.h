
#ifndef COMPILERFACADE
#define COMPILERFACADE
#include "../Parser/Parser.h"
#include "../Assembler/Assembler.h"
#include "../Linker/Linker.h"

#include<iostream>
using namespace std;

class Compiler {

  public:
	 void compile(string sourceFile) {
		string orgSrcFile = sourceFile;
		parser->parse(sourceFile);
		sourceFile = compileInternal(sourceFile);
		sourceFile = assembler->assemble(sourceFile);
		sourceFile = linker->link(sourceFile);
		cout << "\n";
		cout << "Successfully compiled " + orgSrcFile;
		cout << "Final executable is " + sourceFile;
	}

   private :
	 string compileInternal(string sourceFile) {
	 //sourceFile = sourceFile.toLowerCase().replaceAll(".cpp", ".asm");
		cout << "Compiled to assembly " + sourceFile;
		return sourceFile;
	}
	 Parser *parser = new Parser();
	 Assembler *assembler = new Assembler();
	 Linker *linker = new Linker();
};
#endif