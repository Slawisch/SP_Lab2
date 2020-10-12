using System;

namespace SP_Lab2
{
    public class Factory : IComparable
    {
        public readonly string Name;
        public int Workers { get; private set; }
        public int Masters { get; private set; }
        public int Manufactories { get; private set; }
        public int WorkerSalary { get; }
        public int MasterSalary { get; }
        public readonly int WorkerProfit;
        public readonly int MasterProfit;

        public Factory(string name = "NONAME", int workerSalary = 0, int masterSalary = 0, int workerProfit = 0, int masterProfit = 0)
        {
            Name = name;
            WorkerSalary = workerSalary;
            MasterSalary = masterSalary;
            WorkerProfit = workerProfit;
            MasterProfit = masterProfit;
        }

        private void UpdateManufactories()
        {
            if (Workers / 10 <= Masters)
                Manufactories = Workers / 10;
            else Manufactories = Masters;
        }

        public Factory(Factory factory)
        {
            Name = factory.Name;
            Workers = factory.Workers;
            Masters = factory.Masters;
            Manufactories = factory.Manufactories;
            WorkerSalary = factory.WorkerSalary;
            MasterSalary = factory.MasterSalary;
            WorkerProfit = factory.WorkerProfit;
            MasterProfit = factory.MasterProfit;
            UpdateManufactories();
        }

        public int CompareTo(object obj)
        {
            switch (obj)
            {
                case null:
                    return 1;
                case Factory factory:
                    return Manufactories.CompareTo(factory.Manufactories);
                default:
                    throw new ArgumentException("Comparable object is not Factory");
            }
        }

        public void HireWorker(int workers = 1)
        {
            Workers += workers;
            UpdateManufactories();
        }

        public void HireMaster(int masters = 1)
        {
            Masters += masters;
            UpdateManufactories();
        }

        public void DismissWorker(int workers = 1)
        {
            if(workers > Workers)
                throw new ArgumentException("Can't dismiss more workers than factory have");
            Workers -= workers;
            UpdateManufactories();
        }

        public void DismissMaster(int masters = 1)
        {
            if(masters > Masters)
                throw new ArgumentException("Can't dismiss more masters than factory have");
            Masters -= masters;
            UpdateManufactories();
        }

        public int GetCommonSalary()
        {
            return Manufactories * MasterSalary + Manufactories * 10 * WorkerSalary;
        }

        public int GetCommonProfit()
        {
            return Manufactories * MasterProfit + Manufactories * 10 * WorkerProfit;
        }

        public static Factory operator + (Factory factory1, Factory factory2)
        {
            return new Factory(factory1)
            {
                Manufactories = factory1.Manufactories + factory2.Manufactories,
                Masters = factory1.Masters + factory2.Masters, 
                Workers = factory1.Workers + factory2.Workers
            };
        }

        public override string ToString()
        {
            return
                $"Name: {Name}; Manufactories: {Manufactories}; Workers: {Workers}; Masters: {Masters}; Common salary: {GetCommonSalary()}; Common profit: {GetCommonProfit()}; Worker salary: {WorkerSalary}; Master salary: {MasterSalary}; Worker profit: {WorkerProfit}; Master profit: {MasterProfit}";
        }
    }
}