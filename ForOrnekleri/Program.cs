// See https://aka.ms/new-console-template for more information

//Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdirilmasi.
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}
Console.WriteLine("-----------------------------------------------------------------");

//1 ile 20 arasındaki sayıları konsol ekranına yazdırılmasi.
for (int i = 1; i <= 20; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("-----------------------------------------------------------------");

//1 ile 20 arasındaki çift sayıları konsol ekranına yazdiran kod
for (int i = 1; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
Console.WriteLine("-----------------------------------------------------------------");

//50 ile 150 arasındaki sayıların toplamını ekrana yazdıran kod.
int sum = 0;
for (int i = 50; i <= 150; i++)
{

    sum += i;
}
Console.WriteLine("50 ile 150 arasindaki sayilarin toplami: " + sum);
Console.WriteLine("-----------------------------------------------------------------");

// 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdıran kod.

int oddNumberSum = 0; 
int evenNumberSum = 0;

for (int i = 1; i <= 120; i++)
{
    if (i %2 == 0)
    {
        evenNumberSum += i;    
    }
    else
    {
            oddNumberSum += i;
    }
}
Console.WriteLine($"1 ile 120 arasindaki tek sayilarin toplami: " + evenNumberSum + "\n1 ile 120 arasindaki cift sayilarin toplami: " + oddNumberSum);