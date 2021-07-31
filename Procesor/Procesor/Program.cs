using System;

namespace Procesor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj zawartość rejestru AX");
            string AX = Console.ReadLine();

            Console.WriteLine("Podaj zawartość rejestru BX");
            string BX = Console.ReadLine();

            Console.WriteLine("Podaj zawartość rejestru CX");
            string CX = Console.ReadLine();

            Console.WriteLine("Podaj zawartość rejestru DX");
            string DX = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Podaj docelowy rejestr rozkazu MOV");
                string docelowy = Console.ReadLine();
                Console.WriteLine("Podaj pierwotny rejestr rozkazu MOV");
                string pierwotny = Console.ReadLine();

                if (docelowy == "AX" && pierwotny == "AX")
                {
                    AX = AX;
                }
                else if (docelowy == "AX" && pierwotny == "BX")
                {
                    AX = BX;
                }
                else if (docelowy == "AX" && pierwotny == "CX")
                {
                    AX = CX;
                }
                else if (docelowy == "AX" && pierwotny == "DX")
                {
                    AX = DX;
                }
                else if (docelowy == "BX" && pierwotny == "AX")
                {
                    BX = AX;
                }
                else if (docelowy == "BX" && pierwotny == "BX")
                {
                    BX = BX;
                }
                else if (docelowy == "BX" && pierwotny == "CX")
                {
                    BX = CX;
                }
                else if (docelowy == "BX" && pierwotny == "DX")
                {
                    BX = DX;
                }
                else if (docelowy == "CX" && pierwotny == "AX")
                {
                    CX = AX;
                }
                else if (docelowy == "CX" && pierwotny == "BX")
                {
                    CX = BX;
                }
                else if (docelowy == "CX" && pierwotny == "CX")
                {
                    CX = CX;
                }
                else if (docelowy == "CX" && pierwotny == "DX")
                {
                    CX = DX;
                }
                else if (docelowy == "DX" && pierwotny == "AX")
                {
                    DX = AX;
                }
                else if (docelowy == "DX" && pierwotny == "BX")
                {
                    DX = BX;
                }
                else if (docelowy == "DX" && pierwotny == "CX")
                {
                    DX = CX;
                }
                else if (docelowy == "DX" && pierwotny == "DX")
                {
                    DX = DX;
                }
                else
                {
                    Console.WriteLine("Błędnie wprowadzone rejestry procesora, spróbuj ponownie");
                }
                Console.WriteLine("Aktualne rejestry procesora po wykonaniu rozkazu MOV:");
                Console.WriteLine("AX: " + AX);
                Console.WriteLine("BX: " + BX);
                Console.WriteLine("CX: " + CX);
                Console.WriteLine("DX: " + DX);
                Console.WriteLine("Aby kontynować naciśnij ENTER");
                Console.ReadKey();

            }
        }
    }
}
