using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Losowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int switchcase;

            for(; ; )
            {
                choiceOption();
                switchcase = enterNumber();
                switchOptions(switchcase);
            }
          
        }

        static void choiceOption()
        {
            Console.WriteLine("Wybierz jedną z opcji:");
            Console.WriteLine("1 - Losowanie grup");
            Console.WriteLine("2 - Losowanie par");
            Console.WriteLine("3 - Losowanie liczb z podanego zakresu");
            Console.WriteLine("4 - Wyczyść konsole");
            Console.WriteLine("6 - Wyjście");
        }

        static int enterNumber()
        {
           
            string number = Console.ReadLine();
            try
            {
                int optionNumber = int.Parse(number);
                return optionNumber;
            }
            catch (System.FormatException e)
            {
                return 0;
            } 
        }

        static void switchOptions(int inputSwitch)
        {
            switch (inputSwitch)
            {
                
                case 1:
                    Random rnd = new Random();
                    List<int> groups = new List<int> { };
                    int[] numberDraw = new int[106];
                    int k = 106;

                    for (int i = 0; i < k; i++)
                    {
                        numberDraw[i] = i + 1;
                    }

                    for (int i = 0; i < 16; i++)
                    {
                        int tmp = rnd.Next(0, k+1);
                        groups.Add(numberDraw[tmp]);

                        numberDraw[tmp] = numberDraw[k-1];
                        k--;
                    }

                    Console.WriteLine("Grupa A");
                    for (int i = 0; i < 4; i++)
                    {
                        if(groups[i] < 10)
                        {
                            Console.Write(groups[i] + "   ");
                        }
                        else if(groups[i] > 99)
                        {
                            Console.Write(groups[i] + " ");
                        }
                        else
                        {
                            Console.Write(groups[i] + "  ");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Grupa B");
                    for (int i = 0; i < 4; i++)
                    {
                        if (groups[i+4] < 10)
                        {
                            Console.Write(groups[i+4] + "   ");
                        }
                        else if (groups[i+4] > 99)
                        {
                            Console.Write(groups[i+4] + " ");
                        }
                        else
                        {
                            Console.Write(groups[i+4] + "  ");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Grupa C");
                    for (int i = 0; i < 4; i++)
                    {
                        if (groups[i + 8] < 10)
                        {
                            Console.Write(groups[i+8] + "   ");
                        }
                        else if (groups[i + 8] > 99)
                        {
                            Console.Write(groups[i + 8] + " ");
                        }
                        else
                        {
                            Console.Write(groups[i + 8] + "  ");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Grupa D");
                    for (int i = 0; i < 4; i++)
                    {
                        if (groups[i + 12] < 10)
                        {
                            Console.Write(groups[i+12] + "   ");
                        }
                        else if (groups[i + 12] > 99)
                        {
                            Console.Write(groups[i + 12] + " ");
                        }
                        else
                        {
                            Console.Write(groups[i + 12] + "  ");
                        }
                    }
                    Console.WriteLine();
                    rnd = null;
                    break;

                case 2:
                    Random rand = new Random();
                    List<int> numberRange = new List<int> { };

                    Console.WriteLine("Wprowadź liczbe par");
                    int numberPairs = 2 *enterNumber();
                    int decPairs = numberPairs;
                    int divisionPairs = numberPairs / 2;

                    if (numberPairs == 0)
                    {
                        Console.WriteLine("Podano złą ilość!!");
                    }
                    else
                    {
                        int[] tmpRange = new int[numberPairs];
                        for (int i = 0; i < numberPairs; i++)
                        {
                            tmpRange[i] = i + 1;
                        }

                        for (int i = 0; i < numberPairs; i++)
                        {
                            int tmp = rand.Next(0, decPairs);
                            numberRange.Add(tmpRange[tmp]);

                            tmpRange[tmp] = tmpRange[--decPairs];
                        }         

                        for (int i = 0; i < numberPairs; i++)
                        {
                            if (i % 2 == 0)
                            {
                                    Console.Write(numberRange[i] + " - ");
                            }
                            if(i % 2 ==1)
                            {
                                Console.Write(numberRange[i]);
                                Console.WriteLine();
                            }
                            
                        }
                    }

                    break;

                case 3:
                    Console.WriteLine("Podaj ilość liczb");
                    int range = enterNumber();
                    Random randOne = new Random();
                    int result = randOne.Next(1, range+1);
                    Console.WriteLine("Wylosowana liczba to: " + result);
                    break;

                case 4:
                    Console.Clear();
                    
                    break;
                case 6:
                   
                    Environment.Exit(-1);
                    break;

                default:
                    Console.WriteLine("Błąd!! Nie wybrano żadnej opcji!!");
                    break;

            }
        }
    }
}
