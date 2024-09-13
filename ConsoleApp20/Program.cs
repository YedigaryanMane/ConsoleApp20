using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{

    class Planet
    {
        public string name;
        public string oldName;
        public int numOfSatellite;

        public void PrintAll()
        {
            Console.WriteLine($"name: {name}  \\  numofSatellite: {numOfSatellite}");
        }

        public void Initalize(string name,int numOfSatellite)
        {
            this.name = name;
            this.numOfSatellite = numOfSatellite;
        }

    }

    class Flower
    {
        public string name;
        public string color;
        public string type;

        public void PrintAllFlowers()
        {
            Console.WriteLine($"name: {name} \\ color: {color} \\ type: {type}");
        }
        
        public void Initalize(string name,string color)
        {
            this .name = name;
            this.color = color;
        }
        public void Initalize(string name, string color,string type)
        {
            this.name = name;
            this.color = color;
            this.type = type;
        }
    }

    class Country
    {
        public string name;
        public string capital;
        public void PrintCountry()
        {
            Console.WriteLine($"name: {name} \\ capital: {capital}");
        }

        public void Initalize(string name,string capital)
        {
            this.name = name;
            this.capital = capital; 
        }
    }

    class Computer
    {
        public string name;
        public string color;
        public int originNum;

        public void PrintWhatIWillSay()
        {
            Console.WriteLine($"Caputer name is {name}.Computer id  {color}.It is create in  {originNum}.");
        }

        public  void Initalize(String name,string color,int originNum)
        {
            this.name = name;
            this.color = color;
            this.originNum = originNum;
        }
    }

    class Watch
    {
        public string brand;
        public string color;
        public int createNum;

        public void PrintWhatIWillSay()
        {
            Console.WriteLine($"Watch is {brand} brand.It is {color}.It is create in {createNum}.");
        }
    }

    class Bag
    {
        public string brand;
        public string color;
        public string size;

        public void PrintWhatIWillSay()
        {
            Console.WriteLine($"Bag is {brand} brand.It is {color}.It is  {size}.");
        }
    }

    class Cake
    {
        public string brand;
        public string name;
        public string color;
        public void PrintWhatIWillSay()
        {
            Console.WriteLine($"Cake is {brand} brand.It's name is {name}.it is {color}");
        }

        public void Initalize(string brand,string name,string color)
        {
            this.brand = brand;
            this.name = name;
            this.color = color;
        }
    }
    class Necklace
    {
        public string brand;
        public string type;
        public string size;

        public void PrintWhatIWillSay()
        {
            Console.WriteLine($"Necklace is {brand} brand.it is {type}.It is {size}.");
        }

        public void Inatalize(string brand, string type, string size)
        {
            this.brand = brand;
            this.type = type;
            this.size = size;
        }
    }

    class Car
    {
        public string name;
        public string color;
        public string mark;

        public void PrintWhatIWillSay()
        {
            Console.WriteLine($"Car name is {name}.It is {color}.Car is {mark}");
        }

        public void Initalize(string name,string color,string mark)
        {
            this.name=name;
            this.color=color;
            this.mark=mark;
        }
    }
        internal class Program
        {
        static void Main(string[] args)
        {
            Planet Erkir = new Planet();
            Erkir.Initalize("Erkir", 1);

            Erkir.PrintAll();

            Planet Mars = new Planet();
            Mars.Initalize("Mars", 2);

            Mars.PrintAll();

            Flower Rose = new Flower();
            Rose.Initalize("Rose", "red");
            Rose.PrintAllFlowers();

            Flower Tulip = new Flower();
            Tulip.Initalize("Tulip", "Pink");
            Tulip.PrintAllFlowers();

            Country Armenia = new Country();
            Armenia.Initalize("Armenia", "Yerevan");
            Armenia.PrintCountry();

            Country France = new Country();
            France.Initalize("France", "Paris");
            France.PrintCountry();

            Computer Asus = new Computer();
            Asus.Initalize("Asus", "Gray", 1900);
            Asus.PrintWhatIWillSay();

            Watch Casio = new Watch();
            Casio.brand = "Casio";
            Casio.color = "Black";
            Casio.createNum = 1908;
            Casio.PrintWhatIWillSay();

            Bag LouisVoution = new Bag()
            {
                brand = "LouisVoution",
                color = "Brown",
                size = "Big",
            };
            LouisVoution.PrintWhatIWillSay();

            Cake Tartu = new Cake();
            Tartu.Initalize("Tartu", "Arevacaxik", "Yellow");
            Tartu.PrintWhatIWillSay();

            Necklace Pandora = new Necklace();
            Pandora.Inatalize("Pandora", "silver", "big");
            Pandora.PrintWhatIWillSay();

            Car Mercedes = new Car();
            Mercedes.Initalize("Mercedes", "black", "Gt 63.");
            Mercedes.PrintWhatIWillSay();

                Console.ReadLine();
            }
        }
    }
