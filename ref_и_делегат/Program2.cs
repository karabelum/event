using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_и_делегат {
    internal class Program2 {
        
    }
}
Console.WriteLine("ввести несколько слов через пробел");
//List<string> listslova = Console.ReadLine().Split(' ').ToList();
List<string> listslova = new() { "Сова", "Ворон", "Сова", "Ястреб" };
var c = listslova.GroupBy(x => x);
//var z = c.OrderByDescending();

    

foreach (var item in c) {
    Console.WriteLine(item.First() + " " + item.Count());
}