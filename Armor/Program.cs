using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Armor
{
   
    public class Helm
    {
        public string NameHelm = "Helm";
        public float Healthhelm;
        public string namehelm
        {

            get
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите название шлему:");
                Console.ForegroundColor = ConsoleColor.Yellow;
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
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите начальное показатель здоровья шлема (0 - 1):");
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (float.TryParse(Console.ReadLine(), out Healthhelm) && Healthhelm <= 1 && Healthhelm >= 0)
                {
                    
                    return Healthhelm;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("здоровья шлема не должно превышать 10 и быть меньше 0");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    return 0;
                    
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
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите название нагруднику:");
                Console.ForegroundColor = ConsoleColor.Yellow;
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
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите начальное показатель здоровья нагрудника (0 - 1):");
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (float.TryParse(Console.ReadLine(), out HealthShell) && HealthShell <= 1 && HealthShell >= 0)
                {
                    return HealthShell;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("здоровья нагрудника не должно превышать 10 и быть меньше 0");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    return 0;

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
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите название ботинкам:");
                Console.ForegroundColor = ConsoleColor.Yellow;
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
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите начальное показатель здоровья ботинок (0 - 1):");
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (float.TryParse(Console.ReadLine(), out HealthBoots) && HealthBoots <= 1 && HealthBoots >= 0)
                {

                    return HealthBoots;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("здоровья ботинок не должно превышать 10 и быть меньше 0");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    return 0;
                }
            }
        }

    }
    public class Weapon
    {
        public string NameWeapon = "Weapon";
        private float MinDamage;
        private float MaxDamage;
        public float maxdamage;
        public float mindamage;
        public float Damage;
        public float damage { get
            {
                Random random = new Random();
                Damage = random.Next(Convert.ToInt32(MinDamage), Convert.ToInt32(MaxDamage));
                return Damage;
            } }
        public string nameWeapon
        {

            get
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите название оружию:");
                Console.ForegroundColor = ConsoleColor.Yellow;
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
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("введите минимальное значение урона оружия (0 - 20): ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (float.TryParse(Console.ReadLine(), out MinDamage) && MinDamage >= 0 && MinDamage <= 20)
                {
                    mindamage = MinDamage;
                    return MinDamage;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("НЕВЕРНО значение или мин.кол. урона! повторите попытку: ");
                    return minDamage;
                }
            }
        }
        public float maxDamage
        {
            get
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("введите максимальное значение урона оружия (20 - 40): ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (float.TryParse(Console.ReadLine(), out MaxDamage) && MaxDamage >= 20 && MaxDamage <= 40)
                {
                    maxdamage = MaxDamage;
                    return MaxDamage;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("НЕВЕРНО значение или макс.кол. урона! повторите попытку: ");
                    return maxDamage;
                }
            }
        }
        public float resulSetDamageParams { get
            {
                if (MinDamage > MaxDamage)
                {
                    MinDamage = maxdamage;
                    MaxDamage = mindamage;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("минимальное значение не должно быть больше максимальному");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    return MinDamage;
                    return MaxDamage;
                }
                if (MinDamage == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("минимальное значение не должно равняться 0");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    MinDamage = 1;
                    return MinDamage;
                    MinDamage = 1;
                }
                return MinDamage;
                return MaxDamage;
            } 
        }
        public float GetDamage { get 
            {
                
                float summ = 0;
                float res = 0;
                float f;
                for (float i = MinDamage; i <= MaxDamage; i++)
                {
                    res++;
                    summ += i;
                    
                }
                f = summ / res;
                return f;

            } }
    }
    public class Unit
    {
        private float Health;
        public string Name = "Unknow name";
        public float Armor;
        public float RealHealth;
        public float armor
        {
            get
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
        public string name
        {
            get
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите имя бойца:");
                Console.ForegroundColor = ConsoleColor.Yellow;
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

        public float health
        {
            get
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите начальное здоровье бойца (10-100):");
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (float.TryParse(Console.ReadLine(), out Health) && Health >= 10 && Health <= 100)
                {

                    return Health;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("НЕВЕРНО значение или кол. здоровья! повторите попытку: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    return health;
                }
            }
        }
    }
    public class Unit2
    {
        Random random = new Random();
        public string Name = "Unit2";
        public float Damage;
        public float MinDamage;
        public float MaxDamage;
        private float Health = 10;
        public float RealHealth;
        public float Armor;
        public float Helm;
        public float Shell;
        public float Boots;
        public float health { get { Random random = new Random(); Health = random.Next(10, 100); return Health; } }
        public float HealthHelm { get
            {
                Random random = new Random();
                Helm = random.Next(0, 2);
                return Helm;
            } 
        }
        public float HealthShell
        {
            get
            {
                Random random = new Random();
                Shell = random.Next(0, 2);
                return Shell;
            }
        }
        public float HealthBoots
        {
            get
            {
                Random random = new Random();
                Boots = random.Next(0, 2);
                return Boots;
            }
        }
        public float armor
        {
            get
            {
                Armor = Helm + Shell + Boots;
                return Armor;
            }
        }
        public float mindamage
        {
            get
            {
                Random random = new Random();
                MinDamage = random.Next(1,20);
                return MinDamage;
            }
        }
        public float maxdamage
        {
            get
            {
                Random random = new Random();
                MaxDamage = random.Next(20, 40);
                return MaxDamage;
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
        public float damage { get { Random random = new Random(); Damage = random.Next(Convert.ToInt32(MinDamage), Convert.ToInt32(MaxDamage)); return Damage; } }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------Подготовка к бою---------");
            var object1 = new Unit();
            var object2 = new Helm();
            var object3 = new Shell();
            var object4 = new Boots();
            var object5 = new Weapon();
            var object6 = new Unit2();
            Random damage = new Random();
            Console.WriteLine("---------Первый боец--------- ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("имя бойца - {0} ||| ваше здоровье - {1}", object1.name, object1.health);
            Console.WriteLine("");
            Console.WriteLine("название шлема - {0}", object2.namehelm);
            Console.WriteLine("");
            Console.WriteLine("название нагрудника - {0}", object3.nameShell);
            Console.WriteLine("");
            Console.WriteLine("название ботинок - {0}", object4.nameBoots);
            Console.WriteLine("Общий показатель брони равен: {0}", object1.armor);
            Console.WriteLine("Фактическое значение здоровья равно: {0}", object1.realHealth);
            Console.WriteLine("");
            Console.WriteLine("название оружия - {0} | минимальное значение урона - {1} | максимальное значение урона - {2} | среднеарифметическое - {4}", object5.nameWeapon, object5.minDamage, object5.maxDamage, object5.resulSetDamageParams, object5.GetDamage);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------Второй боец--------- ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Имя второго бойца - {0} ||| здоровье второго бойца - {1}", object6.Name, object6.health);
            Console.WriteLine("здоровье шлема - {0} | здоровье нагрудника - {1} | здоровье ботинок - {2}", object6.HealthHelm, object6.HealthShell, object6.HealthBoots);
            Console.WriteLine("Общий показатель брони равен второго бойца: {0}", object6.armor);
            Console.WriteLine("Фактическое здоровье второго бойца: {0}", object6.realHealth);
            Console.WriteLine("минимальное значение урона - {0} | максимальное значение урона - {1}", object6.mindamage, object6.maxdamage);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------Начало боя--------- ");
            var health1 = object1.RealHealth;
            var health2 = object6.RealHealth;
            var damage1 = object5.damage;
            var damage2 = object6.damage;
            while (object1.RealHealth >= 0 || object6.RealHealth >= 0)
            {

                float resultDamage = damage.Next(1, 10);
                if (resultDamage % 2 == 0)
                {
                    health1 -= damage2;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("здоровье {2} убавилось до - {0}, здоровье {3} - {1}", health1, health2, object1.Name, object6.Name);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("здоровье {2} - {0}, здоровье {3} убавилось до - {1}", health1, health2, object1.Name, object6.Name);
                    health2 -= damage1;
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Завершение боя");
                if (health1 <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("");
                    Console.WriteLine("*!*!*!*!*** Winner - Unit2 ***!*!*!*!*");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                else if (health2 <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("");
                    Console.WriteLine("*!*!*!*!*** Winner - {0} ***!*!*!*!*", object1.Name);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                
            }

        }
    }
}
