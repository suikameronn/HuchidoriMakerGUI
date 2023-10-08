#pragma once
#include<iostream>
#include<vector>
#include<FreeImage.h>

class ImageProcess
{
private:
	std::vector<int>::iterator x;
	std::vector<int>::iterator y;

	RGBQUAD huchi;
	RGBQUAD color;

public:
	void Huchidori(FIBITMAP* image, std::vector<int>& edgeLoc, int width, int height, unsigned char red, unsigned char green, unsigned char blue);
};