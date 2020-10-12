using System;
using System.Windows.Forms;

namespace SP_Lab2
{
    public static class FactoryExtension
    {
        public static int ProfitBySum(this Factory factory, int sum, out int needWorkers, out int needMasters)
        {
            int potentialSummaryProfit;
            needWorkers = 0;
            needMasters = 0;

            for (;;)
            {
                int potentialManufactories = GetManufactories(factory.Workers + needWorkers, factory.Masters + needMasters); 
                int freeWorkers = factory.Workers + needWorkers - potentialManufactories * 10;
                int freeMasters = factory.Masters + needMasters - potentialManufactories;
                int tempWorkers = 0;
                int tempMasters = 0;
                
                if (freeWorkers / 10 > freeMasters)
                {
                    tempMasters = freeWorkers / 10;
                }
                else if(freeWorkers / 10 < freeMasters)
                {
                    tempWorkers = 10 - (factory.Workers + needWorkers) % 10;
                }
                else
                {
                    tempWorkers = 10 - (factory.Workers + needWorkers) % 10;
                    tempMasters = 1;
                }

                if (tempWorkers * factory.WorkerSalary + tempMasters * factory.MasterSalary < sum)
                {
                    needWorkers += tempWorkers;
                    needMasters += tempMasters;
                    sum -= tempWorkers * factory.WorkerSalary + tempMasters * factory.MasterSalary;
                }
                else
                {
                    break;
                }
            }

            potentialSummaryProfit = GetManufactories(factory.Workers + needWorkers, factory.Masters + needMasters) *
                                     (factory.MasterProfit + factory.WorkerProfit * 10);

            return potentialSummaryProfit - factory.GetCommonProfit();
        }

        public static int GetManufactories(int workers, int masters)
        {
            if (workers / 10 <= masters)
                return workers / 10;
            return masters;
        }

        public static Factory RandomFactory(int maxWorkerSalary = 100, int maxMasterSalary = 300, int maxWorkerProfit = 200, int maxMasterProfit = 400)
        {
            var random = new Random();
            return new Factory(random.Next(0, 1000).ToString(),
                random.Next(maxWorkerSalary),
                random.Next(maxMasterSalary),
                random.Next(maxWorkerSalary, maxWorkerProfit),
                random.Next(maxMasterSalary, maxMasterProfit));
        }
    }
    
    
}