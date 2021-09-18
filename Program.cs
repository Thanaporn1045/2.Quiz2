using System;
using System.Collections.Generic;

namespace Q.week5
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputrose; int inputsunflower;
            Plantinfo inputPlantinfo = new Plantinfo();

            Console.Write("Input Total Rose : ");
            inputrose = int.Parse(Console.ReadLine());

            Console.Write("Input Total Sun Flower : ");
            inputsunflower = int.Parse(Console.ReadLine());

            inputinfo(inputrose, inputPlantinfo);
            inputinfo(inputsunflower, inputPlantinfo);
            

            static void inputinfo(int Amount, Plantinfo inputPlantinfo1)
            {
                
                for(int i = 0; i<Amount;i++)
                {
                    Console.Write("ID : ");
                    inputPlantinfo1.ID = int.Parse(Console.ReadLine());
                    Console.Write("Plant name : ");
                    inputPlantinfo1.Plantname = Console.ReadLine();
                    Console.Write("Plant description : ");
                    inputPlantinfo1.Plantdescription = Console.ReadLine();
                    Console.Write("Amount : ");
                    inputPlantinfo1.Amount = int.Parse(Console.ReadLine());
                    Console.Write("Height : ");
                    inputPlantinfo1.Height = Console.ReadLine();
                    Console.Write("Circumference : ");
                    inputPlantinfo1.Circumference = Console.ReadLine();

                }

            }

        }
    }
    class Plantinfo
    {
        public int ID;
        public string Plantname;
        public string Plantdescription;
        public int Amount;
        public string Height;
        public string Circumference;

    }
    class Rose 
    {
        private List<Plantinfo> roseinfo;
        
        public void addrose(Plantinfo addrose)
        {
            roseinfo.Add(addrose);
        }

    }
        class Sunflower
    {
        private List<Plantinfo> sunflowerinfo;

        public void addsunflower(Plantinfo addsunflower)
        {
            sunflowerinfo.Add(addsunflower);
        }

    }


}
