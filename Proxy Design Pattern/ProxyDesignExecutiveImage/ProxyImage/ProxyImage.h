#ifndef PROXYIMAGEDESIGNPATTERN
#define PROXYIMAGEDESIGNPATTERN

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
#include "../RealImage/RealImage.h";


// Concerete class ProxyImage
class ProxyImage : public Image {

private:
	RealImage *image = nullptr;
	string filename = "";

public:
	//Constructor
	ProxyImage(string filename) {
		this->filename = filename;
	}

	// Displays the image
	void displayImage() {
		if (image == nullptr) {
			// called when image loads first time
			image = new RealImage(filename);
		}
		image->displayImage();
	}
};
#endif