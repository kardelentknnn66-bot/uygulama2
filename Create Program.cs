static bool NumaraVarMi(List<string>liste, string aranan)
{
    foreach(string sayi in liste)
    {
        if (sayi == aranan)
        {
            return true;
        }
    }
    return false;
}
 {
    List<string> sayilar = new List<string> {"21", "11", "27"};
    Console.Write("Aranan Sayıyı Giriniz: ");
    string? input = Console.ReadLine();
    if(!int.TryParse(input, out int aranan))
    {
        Console.WriteLine("false");
        return;
    }
    bool bulundu = NumaraVarMi(sayilar, aranan.ToString());
    Console.WriteLine(bulundu ? "true" : "false");
}
