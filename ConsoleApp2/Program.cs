using System;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    class Program
    {
        public static void changeCase (string noun , string p)
        {

            //для 1 скланения 
            string S11 = @"а$";
            string S12 = @"я$";

            string R11 = "ы";
            string R12 = "и";

            string D1 = "е";

            string V11 = "у";
            string V12 = "ю";

            string T11 = "ой";
            string T12 = "ей";

            string P1 = "е";

            //для 2 скланения 
            string S23 = @"е$";
            string S22 = @"о$";
            string S21 = @"й$";
            string S24 = @"ие$";
            string S25 = @"ий$";
            string S26 = @"$";

            string R21 = "а";
            string R22 = "я";
            string R23 = "ия";

            string D21 = "у";
            string D22 = "ю";
            string D23 = "ию";

            string V21 = "я";
            string V22 = "о";
            string V23 = "е";
            string V24 = "ие";
            string V25 = "ий";
            string V26 = "";

            string T21 = "ом";
            string T22 = "ем";
            string T23 = "ием";

            string P21 = "е";
            string P22 = "ии";

            //для 3 скланения 
            string S3 = @"ь$";
            string R3 = "и";
            string D3 = "и";
            string V3 = "ь";
            string T3 = "ью";
            string P3 = "и";

            string result;
            // Regex regex1 = new Regex(@"а$");
            //string result = regex1.Replace(noun, R);
            //string result = Regex.Replace(noun, S11, R11);
            //Console.WriteLine(result);



            switch (p)
            {
                case "1":
                    result = Regex.Replace(noun, S11, R11);
                    if (result != noun) { Console.WriteLine(result); break; }
                    result = Regex.Replace(noun, S12, R12);
                    if (result != noun) { Console.WriteLine(result); break; }

                    result = Regex.Replace(noun, S3, R3);
                    if (result != noun) { Console.WriteLine(result); break; }

                    result = Regex.Replace(noun, S21, R22);
                    if (result != noun) { Console.WriteLine(result); break; }
                    result = Regex.Replace(noun, S22, R21);
                    if (result != noun) { Console.WriteLine(result); break; }
                    result = Regex.Replace(noun, S23, R22);
                    if (result != noun) { Console.WriteLine(result); break; }
                    result = Regex.Replace(noun, S24, R23);
                    if (result != noun) { Console.WriteLine(result); break; }
                    result = Regex.Replace(noun, S25, R23);
                    if (result != noun) { Console.WriteLine(result); break; }
                    result = Regex.Replace(noun, S26, R21);
                    if (result != noun) { Console.WriteLine(result); break; }

                    break;
                case "2":
                    result = Regex.Replace(noun, S11, D1);
                    if (result != noun) { Console.WriteLine(result); break; }
                    result = Regex.Replace(noun, S12, D1);
                    if (result != noun) { Console.WriteLine(result); break; }

                    result = Regex.Replace(noun, S3, D3);
                    if (result != noun) { Console.WriteLine(result); break; }

                    result = Regex.Replace(noun, S21, D22);
                    if (result != noun) { Console.WriteLine(result); break; }
                    result = Regex.Replace(noun, S22, D21);
                    if (result != noun) { Console.WriteLine(result); break; }
                    result = Regex.Replace(noun, S23, D22);
                    if (result != noun) { Console.WriteLine(result); break; }
                    result = Regex.Replace(noun, S24, D23);
                    if (result != noun) { Console.WriteLine(result); break; }
                    result = Regex.Replace(noun, S25, D23);
                    if (result != noun) { Console.WriteLine(result); break; }
                    result = Regex.Replace(noun, S26, D21);
                    if (result != noun) { Console.WriteLine(result); break; }

                    break;
                case "3":
                    result = Regex.Replace(noun, S11, V11);
                    if (result != noun) { Console.WriteLine(result); break; }
                    result = Regex.Replace(noun, S12, V12);
                    if (result != noun) { Console.WriteLine(result); break; }


                    result = Regex.Replace(noun, S3, V3);
                    if (result != noun) { Console.WriteLine(result); break; }

                    result = Regex.Replace(noun, S21, V21);
                    if (result != noun) { Console.WriteLine(result); break; }
                    result = Regex.Replace(noun, S22, V22);
                    if (result != noun) { Console.WriteLine(result); break; }
                    result = Regex.Replace(noun, S23, V23);
                    if (result != noun) { Console.WriteLine(result); break; }
                    result = Regex.Replace(noun, S24, V24);
                    if (result != noun) { Console.WriteLine(result); break; }
                    result = Regex.Replace(noun, S25, V25);
                    if (result != noun) { Console.WriteLine(result); break; }
                    result = Regex.Replace(noun, S26, V26);
                    Console.WriteLine(result);  

                    break;
                case "4":
                    result = Regex.Replace(noun, S11, T11);
                    if (result != noun) { Console.WriteLine(result); break; }
                    result = Regex.Replace(noun, S12, T12);
                    if (result != noun) { Console.WriteLine(result); break; }

                    result = Regex.Replace(noun, S3, T3);
                    if (result != noun) { Console.WriteLine(result); break; }

                    result = Regex.Replace(noun, S21, T22);
                    if (result != noun) { Console.WriteLine(result); break; }
                    result = Regex.Replace(noun, S22, T21);
                    if (result != noun) { Console.WriteLine(result); break; }
                    result = Regex.Replace(noun, S23, T22);
                    if (result != noun) { Console.WriteLine(result); break; }
                    result = Regex.Replace(noun, S24, T23);
                    if (result != noun) { Console.WriteLine(result); break; }
                    result = Regex.Replace(noun, S25, T23);
                    if (result != noun) { Console.WriteLine(result); break; }
                    result = Regex.Replace(noun, S26, T21);
                    if (result != noun) { Console.WriteLine(result); break; }

                    break;
                case "5":
                    result = Regex.Replace(noun, S11, P1);
                    if (result != noun) { Console.WriteLine($"o {result}"); break; }
                    result = Regex.Replace(noun, S12, P1);
                    if (result != noun) { Console.WriteLine(result); break; }

                    result = Regex.Replace(noun, S3, P3);
                    if (result != noun) { Console.WriteLine($"o {result}"); break; }

                    result = Regex.Replace(noun, S21, P21);
                    if (result != noun) { Console.WriteLine($"o {result}"); break; }
                    result = Regex.Replace(noun, S22, P21);
                    if (result != noun) { Console.WriteLine($"oб {result}"); break; }
                    result = Regex.Replace(noun, S23, P21);
                    if (result != noun) { Console.WriteLine($"oб {result}"); break; }
                    result = Regex.Replace(noun, S24, P22);
                    if (result != noun) { Console.WriteLine($"o {result}"); break; }
                    result = Regex.Replace(noun, S25, P22);
                    if (result != noun) { Console.WriteLine($"o {result}"); break; }
                    result = Regex.Replace(noun, S26, P21);
                    if (result != noun) { Console.WriteLine($"o {result}"); break; }

                    break;
            }
        }
        static void Main(string[] args)
        {
            Regex regex1 = new Regex(@"[а-яА-ЯёЁ]+");
            Regex regex2 = new Regex(@"[1-5]");
            string noun1;
            string p1;

        do
            {
            Console.WriteLine("Введите слово: ");
            noun1 = Console.ReadLine();
            }
        while (regex1.IsMatch(noun1)!=true);

        do
            {
            Console.WriteLine("Введите падеж (1- P, 2- Д, 3- В, 4- T, 5- П):");
            p1 = Console.ReadLine();
            }
        while (regex2.IsMatch(p1)!= true);

        changeCase(noun1, p1);




        }
    }
}
