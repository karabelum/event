using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_и_делегат {
    internal class Program2 {
        class MyClass {
            public string  { get; set; }
        public string num1 { get; set; }
        public string num2 { get; set; }
        public string num3 { get; set; }
        public MyClass(int num1, int num2, int num3) {

        }
    }
}
Console.WriteLine("ввести несколько слов через пробел");
//List<string> listslova = Console.ReadLine().Split(' ').ToList();
List<string> listslova = new() { "Сова", "Ворон", "Сова", "Ястреб", "Ястреб" };
var c = listslova.GroupBy(x => x);
//var z = c.OrderByDescending();
foreach (var item in c.OrderByDescending(z=>z.Count()) {
    Console.WriteLine(item.First() + "  " + item.Count());
}
List<MyClass> list = new() {
    new MyClass(2,4,6)
    new MyClass(4,5,7)
    new MyClass(2,4,6)
    new MyClass(12,22,6)
    new MyClass(2,33,6)
}
foreach (var item in OrderByDescending(m=>m.num1)){
    Console.WriteLine(item.ToString());
}

Console.WriteLine();