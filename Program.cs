/* Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanarak yazınız.)
1-Negatif ve numeric olmayan girişleri engelleyin.
2-Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
3-Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
*/

using System.Collections;
using Koleksiyonlar_soru_1;

ArrayList sayilar = new ArrayList();
ArrayList asalSayilar = new ArrayList();
ArrayList asalOlmayanSayilar = new ArrayList();
System.Console.WriteLine("20 Tane sayı giriniz.");
int sayi;
for (int i = 0; i < 20; i++)
{
    try
    {
        System.Console.WriteLine($" Lütfen {i + 1}. sayıyı giriniz.");
        sayi = Convert.ToInt32(Console.ReadLine());
       
        if (sayi <= 0)
        {
            --i;
            System.Console.WriteLine("Lütfen Pozitif bir sayı giriniz.!!");

        }
        else
        {
            sayilar.Add(sayi);
            

            if (AsalSorgula.AsalSorgulama(sayi))
            {
                asalSayilar.Add(sayi);
            }
            else
            {
                asalOlmayanSayilar.Add(sayi);
            }

            sayilar.Add(sayi);
        }
    }
    catch (Exception ex)
    {
        --i;
        System.Console.WriteLine("Lütfen sadece pozitif sayı giriniz.!!");
    }
}
asalOlmayanSayilar.Sort();
asalSayilar.Sort();
asalOlmayanSayilar.Reverse();
asalSayilar.Reverse();

foreach (int item in asalSayilar)
{
    Console.Write("{0,5}",item);
}
System.Console.WriteLine("\n**********");
Console.WriteLine("***Asal Olan Sayılar***");

foreach (var item in asalOlmayanSayilar)
{
    Console.Write("{0,5}",item);
}

System.Console.WriteLine("\n**{0}** adet asalsayı vardır.", asalSayilar.Count);
System.Console.WriteLine("**{0}** adet asal olmayan sayı vardır.", asalOlmayanSayilar.Count);

float normalAv = 0;
float asalAv = 0;

Console.WriteLine("***Asal Olmayan Sayılar***");
foreach (var item in asalOlmayanSayilar)
{
    Console.Write("{0,5}",item);
    normalAv = normalAv + Convert.ToInt32(item);
}
Console.Write($"\nToplam {asalOlmayanSayilar.Count} normal sayı girişi yapılmıştır ve ortalaması {normalAv / asalOlmayanSayilar.Count}");
Console.WriteLine("\n***Asal Olan Sayılar***");
foreach (var item in asalSayilar)
{
    Console.Write("{0,5}",item);
    asalAv = asalAv + Convert.ToInt32(item);
}
Console.Write($"\nToplam {asalSayilar.Count} asal sayı girişi yapılmıştır ve ortalaması {asalAv / asalSayilar.Count}");
