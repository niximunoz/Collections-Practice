Console.WriteLine("********Tres matrices básicas************");
/*Crea una matriz para contener los valores enteros 0 a 9.​*/
int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
Console.WriteLine("**********************************");
/*Crea una matriz con los nombres "Tim", "Martin", "Nikki" y "Sara".​*/
string[] names = { "Tim", "Martin", "Nikki", "Sara" };
foreach (string name in names)
{
    Console.WriteLine(name);
}
Console.WriteLine("**********************************");
/*Crea una matriz de longitud 10 que alterne entre valores verdadero y falso, empezando por verdadero.​*/
bool[] trueOrFalse = new bool[10];
for (int i = 0; i < trueOrFalse.Length; i++)
{
    if (i % 2 == 0)
    {
        trueOrFalse[i] = true;
    }
}

foreach (bool valor in trueOrFalse)
{
    Console.WriteLine(valor);
}
Console.WriteLine("**********************************");
Console.WriteLine("********Lista de Sabores************");
/*Crea una lista de sabores de helados que contenga al menos 5 sabores diferentes (¡no dudes en añadir más de 5!).​*/
List<string> iceCreams = new List<string>();

iceCreams.Add("Piña");
iceCreams.Add("Frutilla");
iceCreams.Add("Mango");
iceCreams.Add("Chocolate");
iceCreams.Add("Vainilla");
iceCreams.Add("Frambuesa");

Console.WriteLine(iceCreams[2]);

foreach (string iceCream in iceCreams)
{
    Console.WriteLine(iceCream);
}
Console.WriteLine("**********************************");

/*Imprime la longitud de esta lista después de construirla. ​*/
Console.WriteLine($"Cantidad de sabores de helados: {iceCreams.Count}");
Console.WriteLine("**********************************");
/*Imprime el tercer sabor de la lista y luego elimina ese valor. ​*/
Console.WriteLine($"Tercer sabor de la lista: {iceCreams[3]}");
iceCreams.Remove(iceCreams[3]);
Console.WriteLine("**********************************");
/*Obtén la nueva longitud de la lista (¡sólo debería ser una menos!)​*/
Console.WriteLine($"Nueva cantidad de sabores de helados: {iceCreams.Count}");
Console.WriteLine("**********************************");


Console.WriteLine("********Diccionario de Información del Usuario************");
/* Crea un diccionario que almacene tanto claves de cadena como valores de cadena. ​*/
Dictionary<string, string> infoUser = new Dictionary<string, string>();

/*Añade pares clave/valor a este diccionario donde:​
cada clave sea un nombre de la matriz de nombres​
cada valor sea un sabor seleccionado al azar de tu lista de sabores.​*/
Random rand = new Random();

int countIceCream = iceCreams.Count;
infoUser.Add(names[0], iceCreams[rand.Next(countIceCream)]);
infoUser.Add(names[1], iceCreams[rand.Next(countIceCream)]);
infoUser.Add(names[2], iceCreams[rand.Next(countIceCream)]);
infoUser.Add(names[3], iceCreams[rand.Next(countIceCream)]);

/*Revisa el diccionario e imprime el nombre de cada usuario y su sabor de helado asociado.​*/

foreach (KeyValuePair<string, string> info in infoUser)
{
    Console.WriteLine($"Usuario: {info.Key}, Sabor: {info.Value}");
    Console.WriteLine("****");
}