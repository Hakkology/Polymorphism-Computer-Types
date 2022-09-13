using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution
{

    abstract class Computer
    {
        public Computer(string type, string model, string cpu)
        {
            Type = type;
            Model = model;
            Cpu = cpu;
        }

        public virtual string Type { get; set; }
        public string Model { get; set; }
        public string Cpu { get; set; }
        public bool IsTurnedOn { get; set; } = false;

        public virtual string GetComputerType()
        {
            return Type;
        }

        public string GetComputerModel()
        {
            return Model;
        }

        public string GetComputerCpu()
        {
            return Cpu;
        }

        public bool GetComputerStatus()
        {
            return IsTurnedOn;
        }

        public bool SwitchComputerStatus()
        {
            IsTurnedOn = !IsTurnedOn;
            return IsTurnedOn;
        }
    }
    class PersonalComputer : Computer
    {
        public PersonalComputer(string model, string cpu) : base("", model, cpu)
        {
            Model = model;
            Cpu = cpu;
        }

        public override string Type { get { return "PersonalComputer"; } }
    }
    class Notebook : Computer
    {
        public Notebook(string model, string cpu): base("",model,cpu)
        {
            Model = model;
            Cpu = cpu;
        }

        public override string Type { get { return "Notebook"; } }
    }

    class Solution
    {
        static void Main()
        {
            Type baseType = typeof(Computer);
            if (!baseType.IsAbstract)
                throw new Exception($"{baseType.Name} type should be abstract");

            string str = Console.ReadLine();
            string[] strArr = str.Split(' ');
            Computer personalComputer = new PersonalComputer(strArr[0], strArr[1]);

            var computerType = personalComputer.GetComputerType();
            var computerModel = personalComputer.GetComputerModel();
            var computerCPU = personalComputer.GetComputerCpu();
            var computerStatus = personalComputer.GetComputerStatus() ? "on" : "off";

            Console.WriteLine($"PersonalComputer info: type - {computerType}, model - {computerModel}, CPU - {computerCPU}");
            Console.WriteLine($"PersonalComputer is turned {computerStatus}");

            Console.WriteLine("Switching");
            personalComputer.SwitchComputerStatus();
            computerStatus = personalComputer.GetComputerStatus() ? "on" : "off";
            Console.WriteLine($"PersonalComputer is turned {computerStatus}");

            Console.WriteLine("Switching");
            personalComputer.SwitchComputerStatus();
            computerStatus = personalComputer.GetComputerStatus() ? "on" : "off";
            Console.WriteLine($"PersonalComputer is turned {computerStatus}");

            str = Console.ReadLine();
            strArr = str.Split(' ');
            Computer notebook = new Notebook(strArr[0], strArr[1]);

            computerType = notebook.GetComputerType();
            computerModel = notebook.GetComputerModel();
            computerCPU = notebook.GetComputerCpu();
            computerStatus = notebook.GetComputerStatus() ? "on" : "off";

            Console.WriteLine($"Notebook info: type - {computerType}, model - {computerModel}, CPU - {computerCPU}");
            Console.WriteLine($"Notebook is turned {computerStatus}");

            Console.WriteLine("Switching");
            notebook.SwitchComputerStatus();
            computerStatus = notebook.GetComputerStatus() ? "on" : "off";
            Console.WriteLine($"Notebook is turned {computerStatus}");

            Console.WriteLine("Switching");
            notebook.SwitchComputerStatus();
            computerStatus = notebook.GetComputerStatus() ? "on" : "off";
            Console.WriteLine($"Notebook is turned {computerStatus}");
        }
    }
}
