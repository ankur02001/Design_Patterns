#ifndef EXE_PROXYIMAGEDESIGNPATTERN
#define EXE_PROXYIMAGEDESIGNPATTERN

///////////////////////////////////////////////////////////////////////
////                                                                 //
////  ver 1.0                                                        //
////  Language:      Visual C++ 2013                                 //
////  Platform:      Dell, Windows 8.1                               //
////  Application:   Proxy Design Pattern Demo                      //
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
#include "../ProxyImage/ProxyImage.h";
#include "../RealImage/RealImage.h";

using namespace std;

int main() {


	Image *IMAGE1 = new ProxyImage("HighResolution_10MB_Picture");
	Image *IMAGE2 = new ProxyImage("HighResolution_10MB_Picture");

	cout << " Calling IMAGE1->displayImage() " << endl << endl;
	IMAGE1->displayImage(); // loading necessary
	cout << endl;

	cout << " Calling IMAGE1->displayImage() " << endl << endl;
	IMAGE1->displayImage(); // loading unnecessary
	cout << endl;
	cout << " Calling IMAGE2->displayImage() " << endl << endl;
	IMAGE2->displayImage(); // loading necessary
	cout << endl;
	cout << " Calling IMAGE2->displayImage() " << endl << endl;
	IMAGE2->displayImage(); // loading unnecessary
	cout << endl;
	cout << " Calling IMAGE1->displayImage() " << endl << endl;
	IMAGE1->displayImage(); // loading unnecessary
	cout << endl;
	

	int a;
	cin >> a;
}
#endif