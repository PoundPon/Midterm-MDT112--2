using System;
namespace Midterm {
    class Program {
        static void Main(string[] args) {
            int day = int.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            int b = 5;
            int w = 2;
            int c = 3;
            int x = 1;
            while (x == 1){
            string menu = Console.ReadLine();
            switch (menu){
                case "Breakfast Set":
                if (time <= 11){
                    for (int i = 0;i <= b;i++){
                        b--;
                    if (b > 0){
                        break;
                    }
                    else if (b < 0){
                        Console.WriteLine("Sorry your order is out of stock");
                        break;
                    }
                    }
                }
                else {
                    Console.WriteLine("Sorry your order is not available");
                }
                break;
                case "Weekend Set":
                if (day == 6|| day == 7){
                    for (int j = 0;j <= w;j++){
                        w--;
                        if (w > 0){
                            break;
                        }
                        else if (w < 0){
                        Console.WriteLine("Sorry your order is out of stock");
                        break;
                    }
                    
                    }
                }
                else {
                    Console.WriteLine("Sorry your order is not available");
                }
                break;
                case "Coffee":
                for (int i = 0;i <= c;i++){
                        c--;
                    if (c > 0){
                        break;
                    }
                    else if (c < 0){
                        Console.WriteLine("Sorry your order is out of stock");
                        break;
                        }
                }
                break;
                case "End":
                x = 0;
                break;
                default:
                Console.WriteLine("Please enter a valid menu");
                break;
            }
              }
            }
        }
    }
    