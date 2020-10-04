using System;

namespace SP_Lab2
{
    public class Factory : ICloneable
    {
        public readonly string Name;
        public int Workers { get; private set; }
        public int Masters { get; private set; }
        private int _manufactories;
        private int _workerSalary;
        private int _MasterSalary;
        private int _workerProfit;
        private int _masterProfit;

        public Factory(string name = "NONAME")
        {
            Name = name;
        }

        public object Clone()
        {
            throw new NotImplementedException("Factory.Clone() not implemented");
        }

        public void HireWorker()
        {
            
        }

        public void HireMaster()
        {
            
        }

        public void DismissWorker()
        {
            
        }

        public void DismissMaster()
        {
            
        }
        
        
    }
}