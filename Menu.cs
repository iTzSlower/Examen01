using System;
using System.Collections.Generic;
using System.Text;

namespace Examen01
{
    class Menu
    {
        Player player;
        List<Items> ListItems = new List<Items>();

        List<NPC> ListNPC = new List<NPC>();

        List<Enemy> ListEnemys = new List<Enemy>();
        List<Seller> seller = new List<Seller>();
        List<Talkers> ListTalker = new List<Talkers>();
        float Dinero = 200;
        public void Execute()
        {
            CreatePlayer();
            Default();
        }

        void Default() //para no empezar con las listas vacias
        {
            ListItems.Add(new Potion("pocion", "pocion de vida", 20));
            seller.Add(new Seller(200));
            seller[seller.Count - 1].AddItem(ListItems[0]);
            ListEnemys.Add(new Enemy("enemigo 01", 15, 15.5f, 2));
            ListTalker.Add(new Talkers("paco"));
            ListTalker[ListTalker.Count - 1].AddDialog("muy buenas");
        }
        void Inicio()
        {
            Console.Clear();
            Console.WriteLine("¿Que desea Realizar?");
            Console.WriteLine(" ");
            Console.WriteLine("1.- Crear una entidad o Item");
            Console.WriteLine("2.- Ver Listas");
            Console.WriteLine("3.- Mis Datos");
            Console.WriteLine(" ");
            Console.WriteLine($"Dinero:    {Dinero}");
            Console.WriteLine(" ");
            Respuesta();
        }
        void Respuesta()
        {
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("--Cual creara--");
                    Console.WriteLine("1.-Enemy");
                    Console.WriteLine("2.-Item");
                    Console.WriteLine("3.-Seller");
                    Console.WriteLine("4.-Talker");
                    Console.WriteLine("5.-Volver.");
                    int i = int.Parse(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            CreateEnemy();
                            break;
                        case 2:
                            CreateItem();
                            break;
                        case 3:
                            CreateSeller();
                            break;
                        case 4:
                            CreateTalker();
                            break;
                        case 5:
                            Inicio();
                            break;
                    }
                    break;
                case "2":
                    Lists();
                    break;
                case "3":
                    MyData();
                    break;
                default:
                    Console.WriteLine("La opción no existe");
                    break;
            }
        }
        void CreatePlayer()
        {
            string name;
            float exp;
            int level;

            Console.WriteLine("Nombre del jugador");
            name = Console.ReadLine();
            Console.WriteLine("Nivel del jugador (Solo enteros)");
            level = int.Parse(Console.ReadLine());
            Console.WriteLine("experiencia del jugador ");
            exp = float.Parse(Console.ReadLine());

            player = new Player(name, exp, level);
            Inicio();
        }
        void CreateItem()
        {
            Console.WriteLine("tipos validos:");
            Console.WriteLine("pocion - arma");
            Console.WriteLine(" ");

            string name;
            int cost;
            string type;

            Console.WriteLine("Nombre del Item: ");
            name = Console.ReadLine();
            Console.WriteLine("Costo del Item(Solo enteros): ");
            cost = int.Parse(Console.ReadLine());
            Console.WriteLine("tipo de Item: ");
            type = Console.ReadLine();

            switch (type)
            {
                case "pocion":
                    ListItems.Add(new Potion(type, name, cost));
                    break;
                case "arma":
                    Console.WriteLine("daño del Item: ");
                    int damage = int.Parse(Console.ReadLine());
                    ListItems.Add(new Weapon(type, name, cost, damage));
                    break;
                default:
                    Console.WriteLine("tipo no valido");
                    CreateItem();
                    break;
            }
            Lists();
        }
        void CreateEnemy()
        {
            Console.Clear();
            string name;
            float damage;
            float expG;
            int level;

            Console.WriteLine("Nombre del enemigo");
            name = Console.ReadLine();
            Console.WriteLine("Nivel del enemigo (Solo enteros)");
            level = int.Parse(Console.ReadLine());
            Console.WriteLine("experiencia que dara el enemigo ");
            expG = float.Parse(Console.ReadLine());
            Console.WriteLine("daño de enemigo");
            damage = float.Parse(Console.ReadLine());

            ListEnemys.Add(new Enemy(name, damage, expG, level));
            Inicio();
        }
        void CreateSeller()
        {
            Console.Clear();
            int dinero;

            Console.WriteLine("Cantidad de dinero que tendra el NPC");
            dinero = int.Parse(Console.ReadLine());


            seller.Add(new Seller(dinero));
            Inicio();
        }
        void CreateTalker()
        {
            Console.Clear();
            string name;
            int dialogCount;

            Console.WriteLine("Nombre del NPC Conversador:");
            name = Console.ReadLine();
            ListTalker.Add(new Talkers(name));

            Console.WriteLine("Cantidad de dialogos:");
            dialogCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < dialogCount; i++)
            {
                Console.WriteLine($"dilogo: {i}");
                string dialog = Console.ReadLine();
                ListTalker[ListTalker.Count - 1].AddDialog(dialog);
            }
            Inicio();
        }
        void MyData()
        {
            Console.Clear();
            Console.WriteLine(player.ShowData());
            Console.WriteLine("Presione cualquier tecla para volver al Inicio");
            string option = Console.ReadLine();

            switch (option)
            {
                default:
                    Inicio();
                    break;
            }
        }
        void Lists()
        {
            Console.Clear();
            Console.WriteLine("--LISTAS--");
            Console.WriteLine(" ");
            Console.WriteLine("1.- ITEMs");
            Console.WriteLine("2.- ENEMYs");
            Console.WriteLine("3.- NPCs");
            Console.WriteLine("3.- Volver");
            Console.WriteLine(" ");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ItemsList();
                    break;
                case 2:
                    EnemysList();
                    break;
                case 3:
                    NPCList();
                    break;
                case 4:
                    Inicio();
                    break;
                default:
                    Console.WriteLine("La opción no existe");
                    break;
            }
        }
        void ItemsList()
        {
            Console.Clear();
            Console.WriteLine("La lista de items es: ");
            for (int i = 0; i < ListItems.Count; i++)
            {
                Console.WriteLine($"{i}: {ListItems[i].ShowData()}");
            }
            Console.WriteLine("1.- Dar");
            Console.WriteLine("2.- Eliminar");
            Console.WriteLine("3.- volver");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    GiveItem();
                    break;
                case "2":
                    Console.WriteLine("indice del item");
                    int i = int.Parse(Console.ReadLine());
                    ListItems.RemoveAt(i);
                    ItemsList();
                    break;
                case "3":
                    Inicio();
                    break;
                default:
                    Console.WriteLine("La opción no existe");
                    break;
            }
        }
        void EnemysList()
        {
            Console.Clear();
            Console.WriteLine("La lista de enemigos: ");
            for (int i = 0; i < ListEnemys.Count; i++)
            {
                Console.WriteLine($"{i}: {ListEnemys[i].ShowData()}");
            }
            Console.WriteLine(" ");
            Console.WriteLine("presione cualquier tecla para volver");
            string back = Console.ReadLine();
            switch (back)
            {
                default:
                    Lists();
                    break;
            }
        }
        void GiveItem()
        {
            Console.WriteLine(" ");
            Console.WriteLine("index del item");
            int itemIndex = int.Parse(Console.ReadLine());
            Console.WriteLine("dar a:");
            Console.WriteLine("1.- Player");
            Console.WriteLine($"2.- Enemy, numero de enemigos {ListEnemys.Count}");
            Console.WriteLine($"3.- Seller, numero de vendedores {seller.Count}");
            Console.WriteLine($"4.- volver");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Give(1, itemIndex);
                    break;
                case 2:
                    Give(2, itemIndex);
                    break;
                case 3:
                    Give(3, itemIndex);
                    break;
                case 4:
                    ItemsList();
                    break;
                default:
                    Console.WriteLine(" ");
                    Console.WriteLine("La opción no existe");
                    GiveItem();
                    break;
            }
        }
        void Give(int a,int itemIndex)
        {
            switch (a)
            {
                case 1:
                    player.AddItem(ListItems[itemIndex]);
                    break;
                case 2:
                    Console.WriteLine("indice del enemigo");
                    int i = int.Parse(Console.ReadLine());
                    ListEnemys[i].AddItem(ListItems[itemIndex]);
                    break;
                case 3:
                    Console.WriteLine("indice del vendedor");
                    int v = int.Parse(Console.ReadLine());
                    seller[v].AddItem(ListItems[itemIndex]);
                    break;
            }
            Inicio();
        }
        void NPCList()
        {
            for (int i = 0; i < ListTalker.Count; i++)
            {
                ListNPC.Add(ListTalker[i]);
            }
            for (int i = 0; i < seller.Count; i++)
            {
                ListNPC.Add(seller[i]);
            }

            Console.Clear();
            Console.WriteLine("La lista de NPC es: ");
            foreach (NPC npc in ListNPC)
            {
                Console.WriteLine(npc.ShowData());
            }
            Console.WriteLine("presione cualquier tecla para volver");
            string a = Console.ReadLine();
            switch (a)
            {
                default:
                    Inicio();
                    break;
            }
        }
    }
}
