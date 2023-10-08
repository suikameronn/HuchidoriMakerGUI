#include"dlldefine.h"

#include<iostream>
#include<vector>
#include<stdlib.h>
#include <string.h>
#include"FreeImage.h"
#include"IO.h"
#include"GetPixelData.h"
#include"ImageProcess.h"

void manager(char* result,const char* input, const char* output,unsigned char red, unsigned char green,unsigned char blue)
{
    FreeImage_Initialise();

    IO io;
    std::shared_ptr<FIBITMAP> image = std::shared_ptr<FIBITMAP>(io.GenericLoader(input, 0), FreeImage_Unload);
    if (!image)
    {
        strcpy_s(result, 256, "Result:Load Image Failed");
        return;
    }

    GetPixelData pixels(FreeImage_GetWidth(image.get()), FreeImage_GetHeight(image.get()));

    std::vector<int> edgeLoc(pixels.getWidth() * pixels.getHeight(), -1);
    pixels.copyAlpha(image.get(), edgeLoc);

    ImageProcess ip;
    ip.Huchidori(image.get(), edgeLoc, pixels.getWidth(), pixels.getHeight(),red,green,blue);

    if (!io.GenericWriter(image.get(), output, 0))
    {
        strcpy_s(result, 256, "Result:Huchidori Failed");
        return;
    }

    strcpy_s(result, 256, "Result:Success");
}