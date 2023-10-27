// See https://aka.ms/new-console-template for more information

//  Matriz
// 1.

int[] matriz1 = new int[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

foreach(int num in matriz1){
    Console.WriteLine(num);
}
 //2. 

 string[] matriz2 = new string[4];

 matriz2[0] = "Tim";
 matriz2[1] = "Martin";
 matriz2[2] = "Nikki";
 matriz2[3] = "Sara";

 foreach(string nombre in matriz2){
    Console.WriteLine(nombre);
 }
//3.

 bool[] matriz3 = new bool[10];

 matriz3[0] = true;
 matriz3[1] = false;
 matriz3[2] = true;
 matriz3[3] = false;
 matriz3[4] = true;
 matriz3[5] = false;
 matriz3[6] = true;
 matriz3[7] = false;
 matriz3[8] = true;
 matriz3[9] = false;

 foreach(bool trueorfalse in matriz3){
    Console.WriteLine(trueorfalse);
 }

 //----------------------------------

 //Listas

 //1.

 List<string> listaSabores = new List<string>();

 listaSabores.Add("Vainilla");
 listaSabores.Add("Mora");
 listaSabores.Add("Chocolate");
 listaSabores.Add("Pasas al ron");
 listaSabores.Add("Pistacho");
 listaSabores.Add("Lúcuma");

 Console.WriteLine(listaSabores.Count);
 Console.WriteLine(listaSabores[2]);

listaSabores.RemoveAt(2);

Console.WriteLine(listaSabores.Count);

// ----------------------------------------

//Diccionario

Dictionary<string, string> diccionario = new Dictionary<string, string>();

diccionario.Add("Tim", "Mora");
diccionario.Add("Martin", "Vainilla");
diccionario.Add("Nikki", "Pistacho");
diccionario.Add("Sara", "Lúcuma");

foreach(var nombreHelado in diccionario){
    Console.WriteLine(nombreHelado.Key + " Helado sabor " + nombreHelado.Value);
}
