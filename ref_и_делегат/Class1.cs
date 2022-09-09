
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_и_делегат {

    class Acc {
        public delegate void AccHandler(string sender);

        public event AccHandler? Notify;

        internal class Class1 {
            public Acc(int sum) {
                sum = Sum;
            }
            public int Sum { get; set; }
            public void Put(int sum) {
                Sum += sum;
                Notify?.Invoke(&"На счет поступило: {sum}");
                //Console.WriteLine(&"На счет поступило: {sum}");
            }
            public void Take(int sum) {
                if (Sum <= sum) {
                    Sum -= sum;
                    Notify?.Invoke(&"Со счета снято: {sum}");
                }
                else {
                    Notify?.Invoke(&"Недостаточно средств");
                }
            }
        }
    }
