#ifndef REALIMAGEDESIGNPATTERN
#define REALIMAGEDESIGNPATTERN

///////////////////////////////////////////////////////////////////////
////                                                                 //
////  ver 1.0                                                        //
////  Language:      Visual C++ 2013                                 //
////  Platform:      Dell, Windows 8.1                               //
////  Application:   Proxy Design Pattern Demo                       //
////  Author:		   Ankur Pandey                                  //
///////////////////////////////////////////////////////////////////////
//
/*
//Module Operations:
//==================
//This module defines a class that provides services necessary for  client.
//
*/


#include<iostream>
#include<string>
using namespace std;

// Image Interface 

class Image {
public:
	virtual void displayImage() = 0;
};

// Concerete class RealImage

class RealImage : public Image {

private:
	string filename = "";

	// Loads the image from the disk
	void loadImageFromDisk() {
		cout << "Loading   " + filename << endl;
	}

public:

	// Constructor
	RealImage(string filename) {
		this->filename = filename;
		loadImageFromDisk();
	}

	// Displays the image
	void displayImage() {
		cout << "Displaying " + filename << endl;
	}
};
#endif