using System;
using System.Linq;

namespace ORMBBDDPropia
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
            string option = Console.ReadLine().Trim().ToUpper();

            using (BBDDRODRIEntities db = new BBDDRODRIEntities())
            {
                while (option != "H")
                {
                    switch (option)
                    {
                        case "A":
                            db.Clients.Add(newClient());
                            db.SaveChanges();
                            break;
                        case "B":
                            db.Products.Add(newProduct());
                            db.SaveChanges();
                            break;
                        case "C":
                            db.Manufacturers.Add(newManufacturer());
                            db.SaveChanges();
                            break;
                        case "D":
                            mostrarClientes(db);
                            break;
                        case "E":
                            mostrarProductos(db);
                            break;
                        default:
                            Console.WriteLine("Inserta una opción correcta.");
                            break;
                    }
                    menu();
                    option = Console.ReadLine().Trim().ToUpper();
                }
            }

        }
        //MENU FUNCTION
        public static void menu()
        {
            Console.WriteLine("-- MENÚ -- ");
            Console.WriteLine("A) ADD CLIENT");
            Console.WriteLine("B) ADD PRODUCT");
            Console.WriteLine("C) ADD MANUFACTURER");
            Console.WriteLine("D) SHOW CLIENTS");
            Console.WriteLine("E) SHOW PRODUCTS");
            Console.WriteLine("F) SHOW MANUFACTERS");
            Console.WriteLine("G) SHOW CLIENTS");
            Console.WriteLine("H) EXIT");
            Console.WriteLine();
            Console.Write("OPTION: ");
        }

        //FUNCTIONS TO ADD CLIENTS/MANUFCTURER/PRODUCTS
        public static Manufacturers newManufacturer()
        {
            string name, adress;

            Console.Write("\n------------------------------------\n");
            Console.Write("NAME MANUFACTURER: ");
            name = Console.ReadLine().Trim();
            Console.Write("ADRESS MANUFACTURER: ");
            adress = Console.ReadLine().Trim();
            Console.Write("------------------------------------\n");
            return new Manufacturers
            {
                name = name,
                adress = adress
            };
        }
        public static Clients newClient()
        {
            string name, adress;

            Console.Write("\n------------------------------\n");
            Console.Write("NAME CLIENT: ");
            name = Console.ReadLine().Trim();
            Console.Write("ADRESS CLIENT: ");
            adress = Console.ReadLine().Trim();
            Console.Write("------------------------------------\n");
            return new Clients
            {
                name = name,
                adress = adress
            };
        }
        public static Products newProduct()
        {
            int idmanufacturer;
            double price;
            string name;

            Console.Write("\n------------------------------\n");
            Console.Write("ID PRODUCT: ");
            idmanufacturer = int.Parse(Console.ReadLine().Trim());
            Console.Write("NAME PRODUCT: ");
            name = Console.ReadLine().Trim();
            Console.Write("PRICE CLIENT: ");
            price = double.Parse(Console.ReadLine().Trim());
            Console.Write("------------------------------------\n");
            return new Products
            {
                idManufacturer = idmanufacturer,
                name = name,
                price = price
            };
        }

        public static void mostrarClientes(BBDDRODRIEntities db)
        {
            Console.WriteLine("\nCLIENTS: \n");
            var info1 = from client in db.Clients select client;

            foreach (Clients row in info1)
            {
                Console.WriteLine(row.idClient + " -- " + row.name + " -- " + row.adress);
            }
            Console.WriteLine();
        }

        public static void mostrarProductos(BBDDRODRIEntities db)
        {
            Console.WriteLine("\nPRODUCTS: \n");
            var info2 = from product in db.Products select product;

            foreach (Products row in info2)
            {
                Console.WriteLine(row.idProduct + " -- " + row.name + " -- " + row.price);
            }
            Console.WriteLine();
        }

        public static void mostrarManufacters(BBDDRODRIEntities db)
        {
            Console.WriteLine("\nMANUFACTERS: \n");
            var info3 = from manufacturer in db.Manufacturers select manufacturer;
            foreach (Manufacturers row in info3)
            {
                Console.WriteLine(row.idManufacturer + " -- " + row.name + " -- " + row.adress);
            }
            Console.WriteLine();
        }
    }
}