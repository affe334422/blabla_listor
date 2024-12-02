
using System.Linq.Expressions;

List<decimal> blabla = new List<decimal>();
decimal EnTillsumma = 0;


blabla.Add(1.5m);
blabla.Add(2.3m);
blabla.Add(2.4m);
blabla.Add(1.8m);
blabla.Add(4.5m);

medel(blabla,ref EnTillsumma);

blabla.RemoveAt(3);

foreach(decimal element in blabla){
    Console.WriteLine(element);
}

Console.WriteLine("Innan man tog bort talet på plats 3: " + EnTillsumma);
medel(blabla,ref EnTillsumma);


static void medel(List<decimal> lala, ref decimal shiiiit){
    decimal summa = 0;
    foreach(decimal element in lala){
        summa = summa + element;
        Console.WriteLine(summa + " summa");
    }
    summa = summa / lala.Count;
    Console.WriteLine(lala.Count + " test");
    Console.WriteLine(summa);
    shiiiit = summa;
}