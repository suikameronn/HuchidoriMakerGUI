#include"ImageProcess.h"

void ImageProcess::Huchidori(FIBITMAP* image,std::vector<int> &edgeLoc,int width,int height,unsigned char red,unsigned char green,unsigned char blue)
{
	int a = 0;

	huchi.rgbRed = red;
	huchi.rgbBlue = blue;
	huchi.rgbGreen = green;
	huchi.rgbReserved = 255;

	x = edgeLoc.begin();
	for (; x != edgeLoc.end(); ++x)
	{
		//Žl•ûŒü
		FreeImage_GetPixelColor(image, *x % width, (*x / width) - 1, &color);
		if (color.rgbReserved == a)
		{
			FreeImage_SetPixelColor(image, *x % width, (*x / width) - 1, &huchi);
		}

		FreeImage_GetPixelColor(image, (*x % width) + 1, *x / width, &color);
		if (color.rgbReserved == a)
		{
			FreeImage_SetPixelColor(image, (*x % width) + 1, *x / width, &huchi);
		}

		FreeImage_GetPixelColor(image, (*x % width) - 1, *x / width, &color);
		if (color.rgbReserved == a)
		{
			FreeImage_SetPixelColor(image, (*x % width) - 1, *x / width, &huchi);
		}

		FreeImage_GetPixelColor(image, *x % width, (*x / width) + 1, &color);
		if (color.rgbReserved == a)
		{
			FreeImage_SetPixelColor(image, *x % width, (*x / width) + 1, &huchi);
		}

		//ŽÎ‚ß
		FreeImage_GetPixelColor(image, (*x % width) - 1, (*x / width) - 1, &color);
		if (color.rgbReserved == a)
		{
			FreeImage_SetPixelColor(image, (*x % width) - 1, (*x / width) - 1, &huchi);
		}

		FreeImage_GetPixelColor(image, (*x % width) + 1, (*x / width) - 1, &color);
		if (color.rgbReserved == a)
		{
			FreeImage_SetPixelColor(image, (*x % width) + 1, (*x / width) - 1, &huchi);
		}

		FreeImage_GetPixelColor(image, (*x % width) - 1, (*x / width) + 1, &color);
		if (color.rgbReserved == a)
		{
			FreeImage_SetPixelColor(image, (*x % width) - 1, (*x / width) + 1, &huchi);
		}

		FreeImage_GetPixelColor(image, (*x % width) + 1, (*x / width) + 1, &color);
		if (color.rgbReserved == a)
		{
			FreeImage_SetPixelColor(image, (*x % width) + 1, (*x / width) + 1, &huchi);
		}
	}
}