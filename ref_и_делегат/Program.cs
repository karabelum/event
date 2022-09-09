using ref_и_делегат;
void PrintMes() {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Writeline(mes);
}


Acc acc1 = new Acc(100);
acc1.Notify += PrintMes;


acc1.Put(20);


acc1.Take(700);

acc1.Take(1800);