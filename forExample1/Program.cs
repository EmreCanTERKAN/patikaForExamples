//1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Kendime İnanıyorum, ben bu yazılım işini hallederim.");
}
Console.WriteLine("_____________________________________________________________");
//2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

for (int i = 0; i <= 20; i++)
{
    Console.WriteLine(i);

}
Console.WriteLine("_____________________________________________________________");
//3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
for (int i = 0; i <= 20; i += 2)
{
    Console.WriteLine(i);
}
Console.WriteLine("_____________________________________________________________");
//4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
int toplam = 0;
for (int i = 50; i <= 150; i++)
{
    toplam += i;
}
Console.WriteLine(toplam);
Console.WriteLine("_____________________________________________________________");
//5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
int toplamCift = 0;
int toplamTek = 0;
for (int i = 0; i <= 120; i += 2)
{

    toplamCift += i;

}
for (int j = 1; j < 120; j += 2)
{

    toplamTek += j;
}
Console.WriteLine("1den-120 e kadar olan tek sayıların toplamı : " + toplamTek);
Console.WriteLine("1den-120 e kadar olan çift sayıların toplamı :" + toplamCift);