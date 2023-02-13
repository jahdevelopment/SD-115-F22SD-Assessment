using SD_115_F22SD_Assessment.Models;
using System.ComponentModel;
using System.Security.Cryptography.Xml;

namespace SD_115_F22SD_Assessment.Database
{
    public static class Context
    {
        public static HashSet<Laptop> Laptops = new HashSet<Laptop>();

        public static HashSet<Brand> Brands = new HashSet<Brand>();

        public static HashSet<Laptop> LaptopsCopy = new HashSet<Laptop>();

        private static int _idCount = 0;
        public static int GetIdCount()
        {
            _idCount++;
            return _idCount;
        }

        

    private static void _seedMethod()
        {
            Brand DellXPS = new Brand("Dell", "XPS13");
            Brand DellInspiron = new Brand("Dell", "Inspiron 15 7000");
            Brand DellG5 = new Brand("Dell", "G5 15");
            Brand DellLatitude = new Brand("Dell", "Latitude 7410");
            Brand DellVostro = new Brand("Dell", "Vostro 5590");
            Brand HPSpectre = new Brand("HP", "Spectre x360");
            Brand HPEnvy = new Brand("HP", "Envy x360");
            Brand HPPavilion = new Brand("HP", "Pavilion x360");
            Brand HPDragonfly = new Brand("HP", "Elite Dragonfly");
            Brand HPProbook = new Brand("HP", "ProBook 450");
            Brand LenovoThinkpad = new Brand("Lenovo", "ThinkPad X1");
            Brand LenovoIdeapad = new Brand("Lenovo", "IdeaPad 5");
            Brand LenovoLegion5 = new Brand("Lenovo", "Legion 5");
            Brand LenovoThinkpadT14 = new Brand("Lenovo", "ThinkPad T14");
            Brand LenovoIdeapad3 = new Brand("Lenovo", "Ideapad3");

            Laptop LaptopOne = new Laptop(DellXPS, new DateTime(2023, 1, 1), 5, 1200, TypeOfBusiness.New);
            Laptop LaptopTwo = new Laptop(DellInspiron, new DateTime(2018, 1, 1), 3, 700, TypeOfBusiness.Refurbished);
            Laptop LaptopThree = new Laptop(DellG5, new DateTime(2020, 1, 1), 8, 900, TypeOfBusiness.Refurbished);
            Laptop LaptopFour = new Laptop(DellLatitude, new DateTime(2017, 1, 1), 7, 800, TypeOfBusiness.Refurbished);
            Laptop LaptopFive = new Laptop(DellVostro, new DateTime(2019, 1, 1), 5, 750, TypeOfBusiness.Refurbished);
            Laptop LaptopSix = new Laptop(HPSpectre, new DateTime(2021, 1, 1), 2, 1150, TypeOfBusiness.New);
            Laptop LaptopSeven = new Laptop(HPEnvy, new DateTime(2016, 1, 1), 1, 120, TypeOfBusiness.Rental);
            Laptop LaptopEight = new Laptop(HPPavilion, new DateTime(2015, 1, 1), 8, 100, TypeOfBusiness.Rental);
            Laptop LaptopNine = new Laptop(HPDragonfly, new DateTime(2022, 1, 1), 2, 1100, TypeOfBusiness.New);
            Laptop LaptopTen = new Laptop(HPProbook, new DateTime(2023, 1, 1), 3, 1250, TypeOfBusiness.New);
            Laptop LaptopEleven = new Laptop(LenovoThinkpad, new DateTime(2021, 1, 1), 4, 800, TypeOfBusiness.Refurbished);
            Laptop LaptopTwelve = new Laptop(LenovoIdeapad, new DateTime(2022, 1, 1), 6, 950, TypeOfBusiness.New);
            Laptop LaptopThirteen = new Laptop(LenovoLegion5, new DateTime(2018, 1, 1), 7, 150, TypeOfBusiness.Rental);
            Laptop LaptopFourteen = new Laptop(LenovoThinkpadT14, new DateTime(2021, 1, 1), 3, 1200, TypeOfBusiness.Refurbished);
            Laptop LaptopFifteen = new Laptop(LenovoIdeapad3, new DateTime(2017, 1, 1), 8, 100, TypeOfBusiness.Rental);

            Brands.Add(DellXPS);
            Brands.Add(DellInspiron);
            Brands.Add(DellG5);
            Brands.Add(DellLatitude);
            Brands.Add(DellVostro);
            Brands.Add(HPSpectre);
            Brands.Add(HPEnvy);
            Brands.Add(HPPavilion);
            Brands.Add(HPProbook);
            Brands.Add(HPDragonfly);
            Brands.Add(LenovoThinkpad);
            Brands.Add(LenovoIdeapad);
            Brands.Add(LenovoLegion5);
            Brands.Add(LenovoIdeapad3);
            Brands.Add(LenovoThinkpadT14);

            Laptops.Add(LaptopOne);
            Laptops.Add(LaptopTwo);
            Laptops.Add(LaptopThree);
            Laptops.Add(LaptopFour);
            Laptops.Add(LaptopFive);
            Laptops.Add(LaptopSix);
            Laptops.Add(LaptopSeven);
            Laptops.Add(LaptopEight);
            Laptops.Add(LaptopNine);
            Laptops.Add(LaptopTen);
            Laptops.Add(LaptopEleven);
            Laptops.Add(LaptopTwelve);
            Laptops.Add(LaptopThirteen);
            Laptops.Add(LaptopFourteen);
            Laptops.Add(LaptopFifteen);

            
            foreach (Laptop l in Laptops)
            {
                LaptopsCopy.Add(l);
            }





        }
        static Context()
        {
            _seedMethod();
        }
    }

    public enum TypeOfBusiness
    {
        New,
        Refurbished,
        Rental
    }
}
