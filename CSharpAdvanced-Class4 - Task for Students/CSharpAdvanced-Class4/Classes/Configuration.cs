using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using CSharpAdvanced_Class4.Interfaces;
using static CSharpAdvanced_Class4.Enums.Enums;

namespace CSharpAdvanced_Class4
{     
    public abstract class Item 
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }  
    }

    public class Part : Item, IPrice
    { 
        public double GetPrice()
        {
            return Price;
        } 
    }

    public class Module : Item, IPrice, IDiscont
    {
        private List<Part> _parts = new List<Part>(); 

        public Module() { }
        public Module(string name)
        {
            Name = name;
        }

        public void AddPartToModule(Part part, int quantity = 1)
        {
            part.Quantity = quantity;
            _parts.Add(part); 
        }
        public void RemovePartFromModule(Part part) => _parts.Remove(part);
        public double GetPrice()
        {
            double temp=0;
            foreach (var item in _parts)
            {
                temp += item.Price * item.Quantity;
                
            }
            return temp;
        }

        public void SetDiscount(double discount)
        {

            if (discount<0&&discount>100)
            {
                Console.WriteLine("You can`t enter price that is bigger than 100 and smaller than 1!");
            }
            else
            {
                Discount = discount / 100;
            }           
             
        }

        public double GetPriceWithDiscount()
        { 
            return GetPrice() * (1 - Discount);
        }
    }

    public class Configuration : Item, IPrice, IDiscont
    {
        public Colors BoxColor { get; set; }
        private List<Part> _parts = new List<Part>();
        private List<Module> _modules = new List<Module>();
    

        public Configuration() { }
        public Configuration(Colors boxColor)
        { 
            BoxColor = boxColor;
        }

        public void AddPartToProduct(Part part, int quantity = 1)
        {
            _parts.Add(part);
            part.Quantity = quantity;
        }
        public void RemoveModuleFromProduct(Module module) => _modules.Remove(module);
        public void AddModuleToProduct(Module module, int quantity = 1)
        {
            _modules.Add(module);
            module.Quantity = quantity;
        }
         
        public double GetPrice()
        {
            double cena = 0;
            foreach (var item in _parts)
            {
                cena += item.Price * item.Quantity;

            }
            foreach (var item in _modules)
            {
                cena += item.Price * item.Quantity;

            }           
            return cena;
        }

        public double GetPriceWithDiscount()
        {
            return GetPrice() * (1 - Discount);
        }

        public void SetDiscount(double discount)
        {
            if (discount < 0 && discount > 100)
            {
                Console.WriteLine("You can`t enter price that is bigger than 100 and smaller than 1!");
            }
            else
            {
                Discount = discount / 100;
            }           
        }
    }
}
