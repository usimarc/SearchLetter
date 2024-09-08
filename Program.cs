string word = "Frase ou palavra";
char vogal = 'a';
int cont = 0;

foreach (char letra in word)
{
    if (letra == vogal)
    {
        cont++;
    }
}

Console.WriteLine(cont);