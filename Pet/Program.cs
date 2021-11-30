using System;

namespace Pet
{
    class Program
    {
        class Pet
        {
            string name;
            int age;
            double weight;
            public Pet(string _name)
            {
                name = _name;
                age = 0;
                weight = 0.1;
                Console.WriteLine($"{name} has been created from the souls of the dead.");
            }
            public double Weight
            {
                get { return weight; }
            }
            public void ShowPetInto()
            {
                Console.WriteLine($"Name: {name}.");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Weight: {weight}");
            }
            

            public void Eats() 
            {
                weight += 0.2;
                Console.WriteLine($"{name} has eaten a giga pack of Lays Green Onion chips (#NotSpon).");
            }
            public void Run()
            {
                weight -= 0.1;
                Console.WriteLine("*Rattle rattle* Wow im getting old...");
            }
          //~Pet()
          //  {
          //      Console.WriteLine($"{name} has been flushed down the toilet, he was a good soldier... and brand integration.");
          //  }
        }
        static void Main(string[] args)
        {
            Pet myPet = new Pet("Hälvik");
            myPet.ShowPetInto();

            for(int i = 0; i < 10; i++)
            {
                myPet.Eats();
                Console.WriteLine($"Current weight: {myPet.Weight}");
                if(myPet.Weight >= 0.7)
                {
                    while(myPet.Weight > 0.7)
                    {
                        myPet.Run();
                        Console.WriteLine($"Weight after running: {myPet.Weight}");
                    }
                }
            }

            //GC.Collect();
        }
    }
} 
