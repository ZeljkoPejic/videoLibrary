// task2.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <stdlib.h>


//structure holding name and number of years of each film festival
struct filmFestival{
	char name[100];
	int nYears;
	int Avg;
	int**filmInfo;
};



int _tmain(int argc, _TCHAR* argv[])
{
	

	//number of film festivals:
	int nFilmFestivals;
	printf("Insert number of film festivals: \n");
	scanf_s("%d", &nFilmFestivals);

	//dynamic allocation of structures:
	struct filmFestival *pFilmFestival;
	pFilmFestival = new filmFestival[nFilmFestivals];
	


	//fill structures and corresponding 2D arrays:
	for (int i = 0; i < nFilmFestivals; i++)
	{
		pFilmFestival[i].filmInfo = NULL;

		printf("Insert the name of the %d. film festival: \n", i+1);
		scanf_s("%s", pFilmFestival[i].name, 100);

		printf("Insert the number of years of the %d. film festival: \n", i+1);
		scanf_s("%d", &(pFilmFestival[i]).nYears);

		//dynamic allocation od 2D array:
		pFilmFestival[i].filmInfo = new int*[pFilmFestival[i].nYears]; //rows
		for (int j = 0; j < pFilmFestival[i].nYears; j++)
		{
			pFilmFestival[i].filmInfo[j] = new int[2]; //cols
		}

		//fill 2D arrays:
		pFilmFestival[i].Avg = 0;
		for (int j = 0; j < pFilmFestival[i].nYears; j++)
		{
			
			printf("Insert year %d / %d: \n", j+1, pFilmFestival[i].nYears);
			scanf_s("%d", &pFilmFestival[i].filmInfo[j][0]);

			printf("Insert number of films in that year: \n");
			scanf_s("%d", &pFilmFestival[i].filmInfo[j][1]);
			pFilmFestival[i].Avg += pFilmFestival[i].filmInfo[j][1];
			
		}
		pFilmFestival[i].Avg = pFilmFestival[i].Avg / pFilmFestival[i].nYears; //compute average number of films for that film festival

	}
	
	//print info:

	for (int i = 0; i < nFilmFestivals; i++)
	{
		printf("%s:\t", pFilmFestival[i].name);

		for (int j = 0; j < pFilmFestival[i].nYears; j++)
		{
			printf("<%d., %d>", pFilmFestival[i].filmInfo[j][0], pFilmFestival[i].filmInfo[j][1]);
			if (j < pFilmFestival[i].nYears - 1) printf(",");
			else printf("; Avg:%d; \n", pFilmFestival[i].Avg);
			

		}

	}
	
	//deallocation:
	for (int i = 0; i < nFilmFestivals; i++)
	{
		for (int j = 0; j < pFilmFestival[i].nYears; j++)
			delete pFilmFestival[i].filmInfo[j];
		
		delete[] pFilmFestival[i].filmInfo;
	}
		

	delete[] pFilmFestival;

	return 0;
}

