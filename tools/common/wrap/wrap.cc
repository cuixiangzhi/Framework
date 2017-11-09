#include "wrap.h"
#include "uuid/uuid32.h"

extern "C" int diff(char* oldpath, char* newpath, char* patchpath);
DLLAPI int common_diff(char* oldpath, char* newpath, char* patchpath)
{
	return diff(oldpath, newpath, patchpath);
}

extern "C"  int patch(char* oldpath, char* patchpath, char* newpath);
DLLAPI int common_patch(char* oldpath, char* patchpath, char* newpath)
{
	return patch(oldpath, patchpath, newpath);
}

DLLAPI void common_md5(char* data, char* outhash)
{
	_uuid_t uuid;
	uuid_create_external(data,&uuid);
	char* hash = uuid_to_string(&uuid);
	strcpy(outhash, hash);
}

extern void encrypt(unsigned char* data, int len);
DLLAPI void common_encode(unsigned char* data,int len)
{
	encrypt(data,len);
}

extern void decrypt(unsigned char* data, int len);
DLLAPI void common_decode(unsigned char* data, int len)
{
	decrypt(data,len);
}