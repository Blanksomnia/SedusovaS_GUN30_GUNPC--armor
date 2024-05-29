using System;
using System.Xml.Linq;

namespace Armor
{
    public class Unit
    {
        private float Health;
        public string Name = "Unknow name";
        public float Armor;
        //public float damage = 
        public float RealHealth;
        public float armor { get 
            {
                var object2 = new Helm();
                var object3 = new Shell();
                var object4 = new Boots();
                Armor = object2.healthhelm + object3.healthShell + object4.healthBoots;
                return Armor;
            }
        }
        public float realHealth
        {
            get
            {
                RealHealth = Health * (1 + Armor);
                return RealHealth;
            }
        }
        public string name {  
        get {
                Console.WriteLine("Введите имя бойца:");
                string result = Console.ReadLine();
                if (result != "")
                {
                    Name = result;
                    return Name;
                }
                else
                {
                    return Name;
                }
           }
    } 

        public float health {
            get
            {
                Console.WriteLine("Введите начальное здоровье бойца (10-100):");
                if (float.TryParse(Console.ReadLine(), out Health) && Health >= 10 && Health <= 100)
                {

                    return Health;
                }
                else
                {
                    Console.WriteLine("НЕВЕРНО значение или кол. здоровья! повторите попытку: ");
                    return health;
                }
            } 
        }
    }
    public class Helm
    {
        public string NameHelm = "Helm";
        public float Healthhelm;
        public string namehelm
        {

            get
            {
                Console.WriteLine("Введите название шлему:");
                string result = Console.ReadLine();
                if (result != "")
                {
                    NameHelm = result;
                    return NameHelm;
                }
                else
                {
                    return namehelm;
                }
                
            }
            
        }
        public float healthhelm
        {
            get
            {
                Console.WriteLine("Введите начальное показатель здоровья шлема (0 - 1):");
                if (float.TryParse(Console.ReadLine(), out Healthhelm) && Healthhelm <= 1 && Healthhelm >= 0)
                {

                    return Healthhelm;
                }
                else
                {
                    Console.WriteLine("НЕВЕРНО значение или кол. показателя здоровья! повторите попытку: ");
                    return healthhelm;
                }
            }
        }

    }
    public class Shell
    {
        public string NameShell = "Shell";
        public float HealthShell;
        public string nameShell
        {

            get
            {
                Console.WriteLine("Введите название нагруднику:");
                string result = Console.ReadLine();
                if (result != "")
                {
                    NameShell = result;
                    return NameShell;
                }
                else
                {
                    return nameShell;
                }
            }
        }
        public float healthShell
        {
            get
            {
                Console.WriteLine("Введите начальное показатель здоровья нагрудника (0 - 1):");
                if (float.TryParse(Console.ReadLine(), out HealthShell) && HealthShell <= 1 && HealthShell >= 0)
                {

                    return HealthShell;
                }
                else
                {
                    Console.WriteLine("НЕВЕРНО значение или кол. показателя здоровья! повторите попытку: ");
                    return healthShell;
                }
            }
        }

    }
    public class Boots
    {
        public string NameBoots = "Boots";
        public float HealthBoots;
        public string nameBoots
        {

            get
            {
                Console.WriteLine("Введите название ботинкам:");
                string result = Console.ReadLine();
                if (result != "")
                {
                    NameBoots = result;
                    return NameBoots;
                }
                else
                {
                    return nameBoots;
                }
            }
        }
        public float healthBoots
        {
            get
            {
                Console.WriteLine("Введите начальное показатель здоровья ботинок (0 - 1):");
                if (float.TryParse(Console.ReadLine(), out HealthBoots) && HealthBoots <= 1 && HealthBoots >= 0)
                {
                    return HealthBoots;
                }
                else
                {
                    Console.WriteLine("НЕВЕРНО значение или кол. показателя здоровья! повторите попытку: ");
                    return healthBoots;
                }
            }
        }

    }
    public class Weapon
    {
        public string NameWeapon = "Weapon";
        private float MinDamage;
        private float MaxDamage;
        public string nameWeapon
        {

            get
            {
                Console.WriteLine("Введите название оружию:");
                string result = Console.ReadLine();
                if (result != "")
                {
                    NameWeapon = result;
                    return NameWeapon;
                }
                else
                {
                    return nameWeapon;
                }

            }
        }
        public float minDamage
        {
            get
            {
                Console.WriteLine("введите минимальное значение урона оружия (0 - 20): ");
                if (float.TryParse(Console.ReadLine(), out MinDamage) && MinDamage <= 0 && MinDamage >= 20)
                {

                    return MinDamage;
                }
                else
                {
                    Console.WriteLine("НЕВЕРНО значение или мин.кол. урона! повторите попытку: ");
                    return minDamage;
                }
            }
        }
        public float maxDamage
        {
            get
            {
                Console.WriteLine("введите максимальное значение урона оружия (20 - 40): ");
                if (float.TryParse(Console.ReadLine(), out MaxDamage) && MaxDamage <= 20 && MaxDamage >= 40)
                {

                    return MaxDamage;
                }
                else
                {
                    Console.WriteLine("НЕВЕРНО значение или макс.кол. урона! повторите попытку: ");
                    return maxDamage;
                }
            }
        }
    } 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Подготовка к бою--------- ");
            var object1 = new Unit();
            var object2 = new Helm();
            var object3 = new Shell();
            var object4 = new Boots();
            Console.WriteLine("имя бойца - {0} ||| ваше здоровье - {1}", object1.name, object1.health);
            Console.WriteLine("");
            Console.WriteLine("название шлема - {0} ||| здоровье шлема {1}", object2.namehelm, object2.healthhelm);
            Console.WriteLine("");
            Console.WriteLine("название нагрудника - {0} ||| здоровье нагрудника {1}", object3.nameShell, object3.healthShell);
            Console.WriteLine("");
            Console.WriteLine("название ботинок - {0} ||| здоровье ботинок {1}", object4.nameBoots, object4.healthBoots);
            Console.WriteLine("Общий показатель брони равен: {0}", object1.armor);
            Console.WriteLine("Фактическое значение здоровья равно: {0}", object1.realHealth);


        }
    }
}
