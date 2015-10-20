#ifndef DESBOXES_H
#define DESBOXES_H

char P0[64]={
	58, 50, 42, 34, 26, 18, 10, 2, 
	60, 52, 44, 36, 28, 20, 12, 4, 
	62, 54, 46, 38, 30, 22, 14, 6,
	64, 56, 48, 40, 32, 24, 16, 8,
	57, 49, 41, 33, 25, 17, 9,   1, 
	59, 51, 43, 35, 27, 19, 11, 3,
	61, 53, 45, 37, 29, 21, 13, 5,
	63, 55, 47, 39, 31, 23, 15, 7};

char P0inv[64]={
	40, 8, 48, 16, 56, 24, 64, 32,
	39, 7, 47, 15, 55, 23, 63, 31,
	38, 6, 46, 14, 54, 22, 62, 30,
	37, 5, 45, 13, 53, 21, 61, 29, 
	36, 4, 44, 12, 52, 20, 60, 28,
	35, 3, 43, 11, 51, 19, 59, 27,
	34, 2, 42, 10, 50, 18, 58, 26,
	33, 1, 41, 9, 49, 17, 57, 25};

char E[48]={
	32,   1,   2,  3,   4,   5, 
	4,   5,   6,  7,   8,   9,
	8,   9, 10, 11, 12, 13,
	12, 13, 14, 15, 16, 17,
	16, 17, 18, 19, 20, 21,
	20, 21, 22, 23, 24, 25,
	24, 25, 26, 27, 28, 29,
	28, 29, 30, 31, 32,  1};

char M1[4][16]={
	14, 4, 13, 1, 2, 15, 11, 8, 3, 10, 6, 12, 5, 9, 0, 7,
	0, 15, 7, 4, 14, 2, 13, 1, 10, 6, 12, 11, 9, 5, 3, 8,
	4, 1, 14, 8, 13, 6, 2, 11, 15, 12, 9, 7, 3, 10, 5, 0,
	15, 12, 8, 2, 4, 9, 1, 7, 5, 11, 3, 14, 10, 0, 6, 13 };

char M2[4][16]={
	15, 1, 8, 14, 6, 11, 3, 4, 9, 7, 2, 13, 12, 0, 5, 10,
	3, 13, 4, 7, 15, 2, 8, 14, 12, 0, 1, 10, 6, 9, 11, 5,
	0, 14, 7, 11, 10, 4, 13, 1, 5, 8, 12, 6, 9, 3, 2, 15,
	13, 8, 10, 1, 3, 15, 4, 2, 11, 6, 7, 12, 0, 5, 14, 9};

char M3[4][16]={
	10, 0, 9, 14, 6, 3, 15, 5, 1, 13, 12, 7, 11, 4, 2, 8,
	13, 7, 0, 9, 3, 4, 6, 10, 2, 8, 5, 14, 12, 11, 15, 1,
	13, 6, 4, 9, 8, 15, 3, 0, 11, 1, 2, 12, 5, 10, 14, 7,
	1, 10, 13, 0, 6, 9, 8, 7, 4, 15, 14, 3, 11, 5, 2, 12};

char M4[4][16]={
	7, 13, 14, 3, 0, 6, 9, 10, 1, 2, 8, 5, 11, 12, 4, 15,
	13, 8, 11, 5, 6, 15, 0, 3, 4, 7, 2, 12, 1, 10, 14, 9,
	10, 6, 9, 0, 12, 11, 7, 13, 15, 1, 3, 14, 5, 2, 8, 4,
	3, 15, 0, 6, 10, 1, 13, 8, 9, 4, 5, 11, 12, 7, 2, 14};

char M5[4][16]={
	2, 12, 4, 1, 7, 10, 11, 6, 8, 5, 3, 15, 13, 0, 14, 9,
	14, 11, 2, 12, 4, 7, 13, 1, 5, 0, 15, 10, 3, 9, 8, 6,
	4, 2, 1, 11, 10, 13, 7, 8, 15, 9, 12, 5, 6, 3, 0, 14,
	11, 8, 12, 7, 1, 14, 2, 13, 6, 15, 0, 9, 10, 4, 5, 3};

char M6[4][16]={
	12, 1, 10, 15, 9, 2, 6, 8, 0, 13, 3, 4, 14, 7, 5, 11,
	10, 15, 4, 2, 7, 12, 9, 5, 6, 1, 13, 14, 0, 11, 3, 8,
	9, 14, 15, 5, 2, 8, 12, 3, 7, 0, 4, 10, 1, 13, 11, 6,
	4, 3, 2, 12, 9, 5, 15, 10, 11, 14, 1, 7, 6, 0, 8, 13};

char M7[4][16]={
	4, 11, 2, 14, 15, 0, 8, 13, 3, 12, 9, 7, 5, 10, 6, 1,
	13, 0, 11, 7, 4, 9, 1, 10, 14, 3, 5, 12, 2, 15, 8, 6,
	1, 4, 11, 13, 12, 3, 7, 14, 10, 15, 6, 8, 0, 5, 9, 2,
	6, 11, 13, 8, 1, 4, 10, 7, 9, 5, 0, 15, 14, 2, 3, 12 };

char M8[4][16]={
	13, 2, 8, 4, 6, 15, 11, 1, 10, 9, 3, 14, 5, 0, 12, 7,
	1, 15, 13, 8, 10, 3, 7, 4, 12, 5, 6, 11, 0, 14, 9, 2,
	7, 11, 4, 1, 9, 12, 14, 2, 0, 6, 10, 13, 15, 3, 5, 8,
	2, 1, 14, 7, 4, 10, 8, 13, 15, 12, 9, 0, 3, 5, 6, 11 };

char P[32]={
	16, 7, 20, 21,
	29, 12, 28, 17,
	1, 15, 23, 26,
	5, 18, 31, 10, 
	2, 8, 24, 14,
	32, 27, 3, 9,
	19, 13, 30, 6,
	22, 11, 4, 25};

char Rev_P[32] = { 
	9, 17, 23, 31,
	13, 28, 2, 18,
	24, 16, 30, 6,
	26, 20, 10, 1,
	8, 14, 25, 3,
	4, 29, 11, 19,
	32, 12, 22, 7,
	5, 27, 15, 21 };

char PC1[56]={
	57, 49, 41, 33, 25, 17, 9, 
	1, 58, 50, 42, 34, 26, 18, 
	10, 2, 59, 51, 43, 35, 27, 
	19, 11, 3, 60, 52, 44, 36, 
	63, 55, 47, 39, 31, 23, 15, 
	7, 62, 54, 46, 38, 30, 22, 
	14, 6, 61, 53, 45, 37, 29, 
	21, 13, 5, 28, 20, 12, 4};

char Rev_PC1[64] = {
	8, 16, 24, 56, 52, 44, 36, 0,
	7, 15, 23, 55, 51, 43, 35, 0,
	6, 14, 22, 54, 50, 42, 34, 0,
	5, 13, 21, 53, 49, 41, 33, 0,
	4, 12, 20, 28, 48, 40, 32, 0,
	3, 11, 19, 27, 47, 39, 31, 0,
	2, 10, 18, 26, 46, 38, 30, 0,
	1, 9, 17, 25, 45, 37, 29, 0 };

char PC2[48]={ 
	14, 17, 11, 24, 1, 5, 
	3, 28, 15, 6, 21, 10, 
	23, 19, 12, 4, 26, 8, 
	16, 7, 27, 20, 13, 2, 
	41, 52, 31, 37, 47, 55, 
	30, 40, 51, 45, 33, 48, 
	44, 49, 39, 56, 34, 53, 
	46, 42, 50, 36, 29, 32};

char Rev_PC2[56] = {
	5, 24, 7, 16, 6, 10, 20, 18,
	0, 12, 3, 15, 23, 1, 9, 19,
	2, 0, 14, 22, 11, 0, 13, 4,
	0, 17, 21, 8, 47, 31, 27, 48,
	35, 41, 0, 46, 28, 0, 39, 32,
	25, 44, 0, 37, 34, 43, 29, 36,
	38, 45, 33, 26, 42, 0, 30, 40 };

char key[8];
char round_keys[16][6];
char lr1[8]={0x74,0x85,0x02,0xcd,0x38,0x45,0x10,0x97};
char lr2[8]={0x48,0x69,0x11,0x02,0x6a,0xcd,0xff,0x31};
char lr3[8]={0x35,0x74,0x18,0xda,0x01,0x3f,0xec,0x86};
char lr1_star[8]={0x38,0x74,0x75,0x64,0x38,0x45,0x10,0x97};
char lr2_star[	8]={0x37,0x5b,0xd3,0x1f,0x6a,0xcd,0xff,0x31};
char lr3_star[8]={0x12,0x54,0x98,0x47,0x01,0x3f,0xec,0x86};
char cripto_lr1[8];
char cripto_lr2[8];
char cripto_lr3[8];
char cripto_lr1_star[8];
char cripto_lr2_star[8];
char cripto_lr3_star[8];

int key_contor[8][64];
char found_key[8];
#endif