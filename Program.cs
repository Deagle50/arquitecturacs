﻿/*
PROGRAMACION ESTRUCTURADA POR PROCEDIMIENTO O SUBRUTINAS
Calcula la media del array

Puedes usar FOR, WHILE, DO y 
>>> llaves UNICAMENTE para definir las funciones {}
Debes usar funciones sin paŕametros ni retorno

Restricciones:
    - todo variables globales
*/

using System;

var notas = new decimal[] { };
decimal suma;
int index;
decimal media;

Incializacion();
while (index < notas.Length) Proceso();
Finalizacion();


void Incializacion()
{
    Console.WriteLine("Inicializamos los datos");
    notas = new[] { 7.5M, 4, 6, 5, 4, 6.5M, 7.5M };
    suma = 0;
    index = 0;
}

void Proceso()
{
    //Console.WriteLine("Procesamos el ciclo");
    suma += notas[index];
    index++;
}

void Finalizacion()
{
    media = suma / notas.Length;
    Console.WriteLine($"La media es {media:0.00}");
    Console.WriteLine("Fin");

}


