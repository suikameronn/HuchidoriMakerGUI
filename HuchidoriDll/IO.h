#pragma once
#include <iostream>
#include "FreeImage.h"

class IO
{
public:

	FIBITMAP* GenericLoader(const char* Path, int flag);//�摜���o�b�t�@�ɓǂݍ���

	bool GenericWriter(FIBITMAP* dib, const char* Path, int flag);//�摜���t�@�C���ɏo�͂���
};