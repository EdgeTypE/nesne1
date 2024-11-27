Console.WriteLine("müşteri kimliği: ");
int id = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("müşteri adı: ");
string name = Console.ReadLine();
Console.WriteLine("tüketilen birim: ");
int birim = Convert.ToInt32(Console.ReadLine());
double tutar = 0;

if (birim <= 199)
{
    tutar = birim * 1.20;
}
else if (birim >= 200 && birim < 400)
{
    tutar = 199 * 1.20;
    birim = birim - 199;
    tutar = birim * 1.50;
}
else if (birim >= 400 && birim < 600)
{
    tutar = 199 * 1.20;
    tutar += 200 * 1.50;
    birim = birim - 399;
    tutar += birim * 1.80;

}
else if (birim >= 600)
{
    tutar = 199 * 1.20;
    tutar += 200 * 1.50;
    tutar += 200 * 1.80;
    birim = birim - 599;
    tutar += birim * 2.00;
}
if (tutar < 100)
{
    Console.WriteLine("fatura oluşturulamadı, çünkü 100 TL'den az harcadınız " + tutar);
}
else
{
    if (tutar > 400)
    {
        tutar += tutar * 0.15;
        Console.WriteLine("cezalı ödüyorsunuz sayın " + name + " ödemeniz gereken tutar: " + tutar);
    }
    else
    {
        Console.WriteLine("sayın " + name + " ödemeniz gereken tutar: " + tutar);
    }
}

