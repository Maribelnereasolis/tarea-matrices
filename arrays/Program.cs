int[] numeros = new int[10];
Console.WriteLine("Hola! porfavor ingrese 10 numeros");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"por favor ingrese el numero{i + 1}:");
    numeros[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Los valores son");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}

int suma = 0;
for (int i = 0; i < numeros.Length; i++)
{
    suma = suma + numeros[i];

}
Console.WriteLine("La suma de todos los numeros es :" + suma);
int promedio = 0;
promedio = suma / 10;
Console.WriteLine("el promedio de todos los numeros ingresados es:" + promedio);
