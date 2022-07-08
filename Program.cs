int size;

Console.Write("Bir sayı giriniz: ");
size = Convert.ToInt32(Console.ReadLine());

int[] dizi = new int[size];

for (int i = 0; i < dizi.Length; i++)
{
    Console.WriteLine(i+1 + "." + " sayıyı giriniz: ");
    dizi[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Clear();

foreach (int x in dizi)
{
    if (x % 2==0)
        Console.WriteLine(x);
}