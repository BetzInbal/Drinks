using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Drinks.Configuration.AppConfiguration;
using  Drinks.Models;

namespace Drinks.Service
{
    internal static class DrinkService
    {
        public static void CriateXSMLifNotExistsCars()
        {
            if (!File.Exists(DrinksPath))
            {
                XDocument document = new(); //XDocument.Parse
                XElement root = new XElement("Drinks");
                document.Add(root);
                document.Save(DrinksPath);
            }
        }
        public static XElement InsertDrink(Drink drink) 
        {
            XDocument document = XDocument.Load(DrinksPath);
            XElement xDrink = new(
                "Drinks"
                );
            return xDrink;  
        }





        //public static Drink ConvertFromXElement(XElement xElement)
        

            //return new();
        
    }
}
