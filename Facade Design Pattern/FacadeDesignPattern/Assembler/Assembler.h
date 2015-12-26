#pragma once


#ifndef ASSEMBLER
#define ASSEMBLER

#include<iostream>
using namespace std;
#include<string>

class Assembler {

public :

	string assemble(string sourceFile) {
			
		sourceFile.replace(sourceFile.end() - 3, sourceFile.end(), "obj");

		cout << "Translated to binary object code " + sourceFile << endl;
		return sourceFile;
	}
};
#endif