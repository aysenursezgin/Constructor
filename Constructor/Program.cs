using Constructor;



Bebek bebek1 = new Bebek()
{
    Ad = "Alperen",
    Soyad = "Sezgin",
    //DogumTarihi = DateTime.Now
};



Bebek bebek2 = new Bebek("Emir Asaf", "Algül");

//Property ler konsola yazılır
Console.WriteLine(bebek1.Ad);
Console.WriteLine(bebek1.Soyad);
Console.WriteLine(bebek1.DogumTarihi);
Console.WriteLine("-----------------");

Console.WriteLine(bebek2.Ad);
Console.WriteLine(bebek2.Soyad);
Console.WriteLine(bebek2.DogumTarihi);
Console.WriteLine("-----------------");