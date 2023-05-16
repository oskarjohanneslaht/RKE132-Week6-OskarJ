
string[] puuviljad = new string[3];

puuviljad[0] = "õunad";
puuviljad[1] = "banaanid";
puuviljad[2] = "pirnid";

Console.WriteLine(puuviljad[0]);

int puuviljamassivipikkus = puuviljad.Length;

Console.WriteLine($"There are {puuviljamassivipikkus} in your array.");



for (int i = 0; i < puuviljad.Length; i++)
{
    puuviljad[i] = puuviljad[i].Replace(puuviljad[i][0], char.ToUpper(puuviljad[i][0]));

}

foreach (string element in puuviljad)
{
    Console.WriteLine(element);
}



