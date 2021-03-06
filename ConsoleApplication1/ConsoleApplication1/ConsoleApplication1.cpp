#include "pch.h"
#include <iostream>
#include <stdlib.h>

using namespace std;

struct Contacto {
	char nombre[30];
	char apellidoP[20];
	char apellidoM[20];
	int edad[4];
	char direccion[50];
	int telefono[11];
	char email[20];
};

struct Contacto agenda[10];

/*Alta*/
void registrar_contacto()
{
	for (int i = 0; i < 10; i++)
	{
		printf("\n Contacto #%d", i+1);
		printf("\n");

		printf("   Nombre(s): ");
		scanf_s("%s", &agenda[i].nombre);
		printf("   Apellido Paterno: ");
		scanf_s("%s", &agenda[i].apellidoP);
		printf("   Apellido Materno: ");
		scanf_s("%s", &agenda[i].apellidoP);
		printf("   Edad: ");
		scanf_s("%d", &agenda[i].edad);
		printf("   Direccion: ");
		scanf_s("%s", &agenda[i].direccion);
		printf("   Telefono: ");
		scanf_s("%d", &agenda[i].telefono);
		printf("   Email: ");
		scanf_s("%s", &agenda[i].email);

		system("pause");
		system("cls");
	}
}

/*Baja*/
void eliminar_contacto(int numeroContacto)
{
	if (numeroContacto > 0 && numeroContacto < 11)
	{
		for (int i = numeroContacto; i < 10; i++)
			agenda[i-1] = agenda[i];
		numeroContacto++;
	}
	else {
		printf("\n\t Contacto no encontrado");
	}
	system("pause");
	system("cls");
}

/*Desplegar*/
void mostrar_contacto(int numeroContacto)
{
	if (numeroContacto > 0 && numeroContacto < 11)
	{
		printf("\n Contacto #%d", numeroContacto);
		printf("\n");

		printf("   Nombre(s): %s %s %s", agenda[numeroContacto-1].nombre, agenda[numeroContacto - 1].apellidoP, agenda[numeroContacto - 1].apellidoM);
		printf("   Edad: %d", agenda[numeroContacto - 1].edad);
		printf("   Direccion: %s", agenda[numeroContacto - 1].direccion);
		printf("   Telefono: %d", agenda[numeroContacto - 1].telefono);
		printf("   Email: %s", agenda[numeroContacto - 1].email);
	}
	else {
		printf("\n\t Contacto no encontrado");
	}
}

/*DesplegarTodos*/
void mostrar_contactos()
{
	for (int i = 0; i < 10; i++) {
		mostrar_contacto(i);
	}
}

/*Menu*/
void menu()
{
	printf("\n\t\tREGISTRO DE VENDEDORES\n\n");
	printf(" 1. Registrar contacto\n");
	printf(" 2. Eliminar contacto\n");
	printf(" 3. Mostrar contacto\n");
	printf(" 4. Mostrar contactos\n");
	printf(" 5. Salir\n");
	printf("\n Ingrese opcion :");
}

/*Funcion principal*/
int main()
{
	int num = 0;       // numero de contactos
	int opcionMenu;            // opcion del menu
	int num_contacto;  // contacto seleccionado
	Contacto agenda[10];

	system("color 0b");

	do
	{
		menu();
		scanf_s("%d", &opcionMenu);

		switch (opcionMenu)
		{
		case 1:
			registrar_contacto();
			break;

		case 2:
			printf("\n Contacto que desea eliminar: ");
			scanf_s("%d", &num_contacto);
			eliminar_contacto(num_contacto);
			break;

		case 3:
			printf("\n Ingrese numero de contacto: ");
			scanf_s("%d", &num_contacto);
			mostrar_contacto(num_contacto);
			break;

		case 4:
			mostrar_contactos();
			break;
		}

		printf("\n\n");
		system("pause");  
		system("cls");

	} while (opcionMenu != 5);

	return 0;
}
