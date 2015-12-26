#pragma once
/*
class ProgramNode {
public:
	// program node manipulation
	virtual void GetSourcePosition(int& line, int& index);
	// ...

	// child manipulation
	virtual void Add(ProgramNode*);
	virtual void Remove(ProgramNode*);
	// ...

	virtual void Traverse(CodeGenerator&);
	Design Patterns : Elements of Reusable Object - Oriented Software
		214
protected:
	ProgramNode();
};
*/

public class Parser {

	private Scanner scanner = new Scanner();

	public void parse(String sourceFile) {
		scanner.scan(sourceFile);
		System.out.println("Started parsing " + sourceFile);
	}
}