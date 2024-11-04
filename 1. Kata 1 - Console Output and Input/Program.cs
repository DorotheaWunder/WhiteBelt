

class Program
{
    static void Main()
    {
        void Greeting()
        {
            Console.WriteLine("Enter your name");
            string nameInput = Console.ReadLine();
            Console.WriteLine($"Hello {nameInput}, welcome to the 1. Kata");
        }

        void CheckEnthusiasm()
        {
            Console.WriteLine("On a level from 1-10, how excited are you?");
            //int excitementInput = Convert.ToInt32(Console.ReadLine());
            int excitementInput = int.Parse(Console.ReadLine());
            if (excitementInput <= 0 || excitementInput > 10)
            {
                Console.WriteLine($"you entered {excitementInput} but that's not a valid number.");
                Console.WriteLine("Let's try that again");
                CheckEnthusiasm();
            }
            else if (excitementInput >= 7)
            {
                Console.WriteLine($"{excitementInput}? Nice, you're really motivated I see");
            }
            else
            {
                Console.WriteLine($"{excitementInput}? Let's see if we'll manage to increase this during the course");
            }
        }
        
        Greeting();
        CheckEnthusiasm();
    }
}



