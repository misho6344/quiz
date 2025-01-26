using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberguessing
{
    internal class number
    {
        public void met1() {
            Random random = new Random();

            Console.WriteLine("choose difficult easy(e),medium(m),hard(h): ");
            string a =Console.ReadLine();

            double atmpts = 0;
            int[] usernums = new int[5];

            if (a == "easy"||a== "e") {
                int rnum= random.Next(1,51);
                Console.WriteLine("write your number: ");
                
                for (int i = 0; i < 5; i++) {
                    int b = Convert.ToInt32(Console.ReadLine());
                    usernums[i] = b;
                    atmpts = i;
                    if (b == rnum) {
                        Console.WriteLine("your number is correct! " + b+" attempt:"+(atmpts+1));
                        break;
                    }
                    if (b < rnum)
                    {
                        Console.WriteLine("your number lower than random number! ");
                        
                    }
                    if (b > rnum)
                    {
                        Console.WriteLine("your number higher than random number! ");
                        
                    }

                }

                Console.WriteLine("your numbers were:  " + usernums[0] + "," + usernums[1] + "," + usernums[2]
                    + "," + usernums[3] + "," + usernums[4]);



            }

            if (a == "medium" || a == "m")
            {
                int rnum = random.Next(1, 101);
                Console.WriteLine("write your number: ");

                for (int i = 0; i < 5; i++)
                {
                    int b = Convert.ToInt32(Console.ReadLine());
                    usernums[i] = b;
                    atmpts = i;
                    if (b == rnum)
                    {
                        Console.WriteLine("your number is correct! " + b + " attempt:" + (atmpts + 1));
                        break;
                    }
                    if (b < rnum)
                    {
                        Console.WriteLine("your number lower than random number! ");

                    }
                    if (b > rnum)
                    {
                        Console.WriteLine("your number higher than random number! ");

                    }

                }

                Console.WriteLine("your numbers were:  " + usernums[0] + "," + usernums[1] + "," + usernums[2]
                    + "," + usernums[3] + "," + usernums[4]);



            }

            if (a == "hard" || a == "h")
            {
                int rnum = random.Next(1, 201);
                Console.WriteLine("write your number: ");

                for (int i = 0; i < 5; i++)
                {
                    int b = Convert.ToInt32(Console.ReadLine());
                    usernums[i] = b;
                    atmpts = i;
                    if (b == rnum)
                    {
                        Console.WriteLine("your number is correct! " + b + " attempt:" + (atmpts + 1));
                        break;
                    }
                    if (b < rnum)
                    {
                        Console.WriteLine("your number lower than random number! ");

                    }
                    if (b > rnum)
                    {
                        Console.WriteLine("your number higher than random number! ");

                    }

                }

                Console.WriteLine("your numbers were:  " + usernums[0] + "," + usernums[1] + "," + usernums[2]
                    + "," + usernums[3] + "," + usernums[4]);



            }






        }




        



    }
}
