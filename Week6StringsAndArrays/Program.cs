
string hello = "hello world!  ";


int stringLength = hello.Length;

//string trimeedString = hello.Trim(); //trimmib tühikud tekstist välja


hello = hello.Trim();
hello = hello.Replace(hello[0], char.ToUpper(hello[0]));

char firstLetter = hello[0];
Console.WriteLine(firstLetter);



//loeb tähtede arvu
//int wordCounter = 0;
//for(int i = 0; i < hello.Length; i++)
//{
//    //Console.WriteLine($"{i} symbol in string: {hello[i]}");
//    if (char.IsWhiteSpace(hello[i])) ;
//    {
//        wordCounter++;
//    }  
//}
//Console.WriteLine($"Word count in {hello}: {wordCounter} words");

