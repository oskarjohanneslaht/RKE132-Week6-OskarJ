
string[] snacks = { "kartul", "riis", "tatar" };

Random rnd = new Random();

int RandomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"Täna sööme:{snacks[RandomIndex]}");