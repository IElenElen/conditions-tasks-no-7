namespace conditions_tasks_no_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C. Task no 7");
            //Napisz program, który pobierze 3 liczby od użytkownika i sprawdzi która jest największa.
            //Dane: 25, 63, 79. Rezultat: 79 jest największa z podanych.
            //która liczba jest największa a nie tylko, że no3 np. największta to 79

            //& lepiej sprawdzić wszystko przy porównaniu

            Console.WriteLine("Podaj pierwszą liczbę: ");
            string no1Input = Console.ReadLine();
            Console.WriteLine("Podaj drugą liczbę: ");
            string no2Input = Console.ReadLine();
            Console.WriteLine("Podaj trzecią liczbę: ");
            string no3Input = Console.ReadLine();
            int no1out;
            int no2out;
            int no3out;
            if (((int.TryParse(no1Input, out no1out)) && (int.TryParse(no2Input, out no2out)) && (int.TryParse(no3Input, out no3out))))
            {
                Console.WriteLine("Konwersja udana");

                if ((no1out < no3out) & (no2out < no3out))
                {
                    Console.WriteLine($"Najwieksza liczba to: {no3out}");
                }
                else if ((no1out < no2out) & (no3out < no2out))
                {
                    Console.WriteLine($"Największa liczba to: {no2out}");
                }
                else if ((no2out < no1out) & (no3out < no1out))
                {
                    Console.WriteLine($"Największa liczba to: {no1out}");
                }
                else if (no1out == no2out & no2out == no3out)
                {
                    Console.WriteLine("Wszystkie liczby są równe");
                }
            }
            else
            {
                Console.WriteLine("Bląd. Wprowadź poprawne liczby");
            }
        }
    }
}
