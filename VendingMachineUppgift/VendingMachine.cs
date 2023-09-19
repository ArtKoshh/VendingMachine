using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineUppgift
{
    internal class VendingMachine
    {
        const int COST_OF_ITEM = 20;
        public int RunningTotal { get; set; }

        public VendingMachine()
        {
            RunningTotal = 0;
        }

        public void DepositMoney(int money)
        {
            //Only valid Entries
            switch (money)
            {
                case (1):
                    RunningTotal += 1;
                    break;
                case (5):
                    RunningTotal += 5;
                    break;
                case (10):
                    RunningTotal += 10;
                    break;
                case (20):
                    RunningTotal += 20;
                    break;
                case (50):
                    RunningTotal += 50;
                    break;
                case (100):
                    RunningTotal += 100;
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }
        public bool checkTotal()
        {
            if (RunningTotal >= COST_OF_ITEM)
                return true;
            else
                return false;
        }
        public void DisplaySelection()
        {
            HotDrink();
            Console.WriteLine("***************** Press 'A' for more information on HotDrinks");

            ColdDrink();
            Console.WriteLine("***************** Press 'B' for more information on ColdDrinks");

            Snacks();
            Console.WriteLine("***************** Press 'C' for more information on Snacks");
            Console.WriteLine("->>Go to Purchase press 'D'");
            MakeSelection(Convert.ToChar(Console.ReadLine().ToUpper()));
            PurchaseItem(Convert.ToChar(Console.ReadLine().ToUpper()));

        }
        private void PurchaseItem(char item)
        {
            bool PurchaseOK=false;
            while (!PurchaseOK)
            {
                switch (item)
                {
                    case 'A':
                        var BuyTea = new HotDrink.Tea();
                        BuyTea.Buy();
                        BuyTea.Use();
                        ReturnChange();
                        PurchaseOK = true; break;
                        case 'B':
                        var BuyCoffe = new HotDrink.Coffe();
                        BuyCoffe.Buy();
                        BuyCoffe.Use();
                        ReturnChange();
                        PurchaseOK = true; break;
                    case 'C':
                        var BuyCoCo = new HotDrink.Coffe();
                        BuyCoCo.Buy();
                        BuyCoCo.Use();
                        ReturnChange();
                        PurchaseOK = true;
                        break;
                        case 'D':
                        var BuyFanta = new ColdDrink.Fanta();
                        BuyFanta.Buy();
                        BuyFanta.Use();
                        ReturnChange();
                        PurchaseOK=true; break;
                    case 'E':
                        var BuyCocaCola = new ColdDrink.CocaCola();
                        BuyCocaCola.Buy();
                        BuyCocaCola.Use();
                        ReturnChange();
                        PurchaseOK = true;
                        break;
                    case 'F':
                        var BuyWater = new ColdDrink.Water();
                        BuyWater.Buy();
                        BuyWater.Use();
                        ReturnChange();
                        PurchaseOK = true;
                        break;
                    case 'G':
                        var BuyChips = new Snacks.Chips();
                        BuyChips.Buy();
                        BuyChips.Use();
                        ReturnChange();
                        PurchaseOK = true; break;
                    case 'H':
                        var BuySnickers = new Snacks.Snickers();
                        BuySnickers.Buy();
                        BuySnickers.Use();
                        ReturnChange();
                        PurchaseOK = true;
                        break;
                    case 'I':
                        var BuyBounty = new Snacks.Bounty();
                        BuyBounty.Buy();
                        BuyBounty.Use();
                        ReturnChange();
                        PurchaseOK = true;
                        break;
                    default:
                        Console.WriteLine(" Invalid Option please try again");
                        item = (Convert.ToChar(Console.ReadLine().ToUpper()));
                        PurchaseOK = false;
                        break;



                }
            }
        }

        private void MakeSelection(char selection)
        {
            bool selectionOK = false;
            while (!selectionOK)
            {
                switch (selection)
                {
                    case 'A':
                        HotDrinkDesc();
                        selectionOK = true;
                        Console.ReadKey();
                        ReturnMenu();
                        break;
                        
                    case 'B':
                        ColdDrinkDesc();
                        selectionOK = true;
                        Console.ReadKey();
                        ReturnMenu();
                        break;
                        
                    case 'C':
                        SnacksDesc();
                        selectionOK = true;
                        Console.ReadKey();
                        ReturnMenu();
                        break;
                    case 'D':
                        PurchaseMeny();
                        selectionOK=true;
                        break;
                    default:
                        Console.WriteLine("Invalid Selection Please Choose again");
                        selection = Convert.ToChar(Console.ReadLine().ToUpper());
                        selectionOK = false;
                        break;
                }
            }
        }
        public void HotDrink()
        {
            Product Product;
            Product = new HotDrink();
            Product.Desc();
            Product.Name();
            Product.Price();
        }
        public void HotDrinkDesc()
        {
            var Tea = new HotDrink.Tea();
            Tea.Description();
            var Coffe = new HotDrink.Coffe();
            Coffe.Description();
            var CoCo = new HotDrink.Coco();
            CoCo.Description();
        }
        public void ColdDrink()
        {
            Product Product1;
            Product1 = new ColdDrink();
            Product1.Desc();
            Product1.Name();
            Product1.Price();
        }
        public void ColdDrinkDesc()
        {
            var Fanta = new ColdDrink.Fanta();
            Fanta.Description();
            var CocaCola = new ColdDrink.CocaCola();
            CocaCola.Description();
            var Water = new ColdDrink.Water();
            Water.Description();
        }
        public void Snacks()
        {
            Product Product2;
            Product2 = new Snacks();
            Product2.Desc();
            Product2.Name();
            Product2.Price();
        }
        public void SnacksDesc()
        {
            var Chips = new Snacks.Chips();
            Chips.Description();
            var Snickers = new Snacks.Snickers();
            Snickers.Description();
            var Bounty = new Snacks.Bounty();
            Bounty.Description();
        }
        public void PurchaseMeny()
        {
            Console.WriteLine("Press the letter associated with an item you would like to purchase");
            Console.WriteLine("HotDrinks   A. Tea   B.Coffe     C.CoCo");
            Console.WriteLine("ColdDrinks  D.Fanta  E.CocaCola  F.Water");
            Console.WriteLine("Snacks      G.Chips  H.Snickers  I.Bounty");
        }
        public void ReturnMenu()
        {
            Console.Clear();
            DisplaySelection();
        }
        public void ReturnChange()
        {
            if(RunningTotal > COST_OF_ITEM)
                Console.WriteLine("Your Change is {0} Kr ",RunningTotal - COST_OF_ITEM);
        }
    }


    abstract class Product
    {
        public abstract void Price();
        public abstract void Name();
        public abstract void Desc();

      /*  class Tea : Product
        {
            public new int Price = 15;
            public new string Name = "Lipton";
            public new string Desc = "Hot tea";
        }
        class Coffe : Product
        {
            public new int Price = 15;
            public new string Name = "American";
            public new string Desc = "Black Coffe";
        }

        class Coco : Product
        {
            public new int Price = 15;
            public new string Name = "Coco";
            public new string Desc = "Hot Coco";
        }
      */

    }


    public interface IProduct
    {
        void Description();
        void Buy();
        void Use();
    }

    
    class HotDrink : Product
    {
        public override void Desc()
        {
            Console.WriteLine("Hot Drinks");
        }

        public override void Name()
        {
            Console.WriteLine("Tea,Coffe,Coco");
        }

        public override void Price()
        {
            Console.WriteLine("Price 20 kr");
        }
        
        public class Tea : HotDrink, IProduct
        {
            public void Buy()
            {
                Console.WriteLine("Thank You for Purchase!");
            }

            public void Description()
            {
                Console.WriteLine("Tea is hot!");
            }

            public void Use()
            {
                Console.WriteLine("Drink");
            }
        }
        public class Coffe : HotDrink, IProduct
        {
            public void Buy()
            {
                Console.WriteLine("Thank you for Purchase!");
            }

            public void Description()
            {
                Console.WriteLine("Coffe no Milk");
            }

            public void Use()
            {
                Console.WriteLine("Drink");
            }
        }
        public class Coco : HotDrink, IProduct
        {
            public void Buy()
            {
                Console.WriteLine("Thank you for purchase!");
            }

            public void Description()
            {
                Console.WriteLine("Coco is Sweet and Hot");
            }

            public void Use()
            {
                Console.WriteLine("Drink");
            }
        }
    }

    class ColdDrink : Product
    {

        public override void Desc()
        {
            Console.WriteLine("Cold Drinks");
        }

        public override void Name()
        {
            Console.WriteLine("Coca Cola,Fanta,Water");
        }

        public override void Price()
        {
            Console.WriteLine("Price 20 kr");
        }

        public class Fanta : ColdDrink, IProduct
        {
            public void Buy()
            {
                Console.WriteLine("Thank You for Purchase!");
            }

            public void Description()
            {
                Console.WriteLine("Fanta has Orange taste!");
            }

            public void Use()
            {
                Console.WriteLine("Drink");
            }
        }
        public class CocaCola : ColdDrink, IProduct
        {
            public void Buy()
            {
                Console.WriteLine("Thank you for Purchase!");
            }

            public void Description()
            {
                Console.WriteLine("CocaCola has Sweet Taste");
            }

            public void Use()
            {
                Console.WriteLine("Drink");
            }
        }
        public class Water : ColdDrink, IProduct
        {
            public void Buy()
            {
                Console.WriteLine("Thank you for purchase!");
            }

            public void Description()
            {
                Console.WriteLine("Water has No bubbles");
            }

            public void Use()
            {
                Console.WriteLine("Drink");
            }
        }
    }

    class Snacks : Product
    {

        public override void Desc()
        {
            Console.WriteLine("Snacks");
        }

        public override void Name()
        {
            Console.WriteLine("Chips,Snickers,Bounty");
        }

        public override void Price()
        {
            Console.WriteLine("Price 20 kr");
        }

        public class Chips : Snacks, IProduct
        {
            public void Buy()
            {
                Console.WriteLine("Thank You for Purchase!");
            }

            public void Description()
            {
                Console.WriteLine("Chips is Grilled Onion");
            }

            public void Use()
            {
                Console.WriteLine("Eat");
            }
        }
        public class Snickers : Snacks, IProduct
        {
            public void Buy()
            {
                Console.WriteLine("Thank you for Purchase!");
            }

            public void Description()
            {
                Console.WriteLine("Snickers has Sweet Taste");
            }

            public void Use()
            {
                Console.WriteLine("Eat");
            }
        }
        public class Bounty : Snacks, IProduct
        {
            public void Buy()
            {
                Console.WriteLine("Thank you for purchase!");
            }

            public void Description()
            {
                Console.WriteLine("Bounty has Coconut taste");
            }

            public void Use()
            {
                Console.WriteLine("Eat");
            }
        }
    }


}
