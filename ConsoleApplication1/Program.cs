using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Computer
    {
        public static int daisu = 0;
        public int memory;
        public int disk;
        public string name;

        public static int GetCount()
        {
            return daisu;
        }

        public Computer(int computermemory
                           , int computerdisk
                           , string computerName)
        {
            memory = computermemory;
            disk = computerdisk;
            name = computerName;
            daisu = daisu + 1;
        }


        public string ComputerName
        {
            get
            {
                return name;
            }
            private set
            {
                ComputerName = value;

            }
        }
        public string installedOS;

        public string InstalledOS
        {
            get
            {
                return InstalledOS;
            }
            private set
            {
                installedOS = value;
            }
        }
        public void PrintSpec()
        {
            Console.WriteLine("Memory = {0}MB, Disk = {1}GB", memory, disk);
        }
    }
    class MainClass
    {
        static void Main()
        {
            Console.WriteLine("現在の台数 = {0}", Computer.GetCount());

            Computer computer1;
            computer1 = new Computer(1000, 0, "Sales01");
            computer1.installedOS = "Windows 8 Ultimate";
           
            Computer computer2;
            computer2 = new Computer(1600, 120, "Sailes02");
            computer2.installedOS = "Windows 7 Professional";

            Console.WriteLine("現在の台数 = {0}", Computer.GetCount());

            Console.WriteLine("{0}, {1}", computer1.name, computer1.installedOS);
            computer1.PrintSpec();
            Console.WriteLine("{0}, {1}", computer2.name, computer2.installedOS);
            computer2.PrintSpec();
        }

    }
}

