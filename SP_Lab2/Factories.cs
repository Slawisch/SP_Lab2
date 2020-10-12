using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace SP_Lab2
{
    public static class Factories
    {
        private static List<Factory> _factories = new List<Factory>();
        public static int Length
        {
            get => _factories.Count;
        }

        public static void AddFactory(Factory factory)
        {
            _factories.Add(factory);
        }

        public static Factory GetFactoryByIndex(int index)
        {
            return _factories[index];
        }

        public static void DeleteFactory(int index)
        {
            _factories.RemoveAt(index);
        }
        
        public static void MergeFactories<T>(T indices) where T: IList<int>
        {
            var finalFactory = GetFactoryByIndex(indices[0]);
            for (var i = 1; i < indices.Count; i++)
            {
                int index = indices[i];
                finalFactory += GetFactoryByIndex(index);
                    
            }

            for (int i = indices.Count - 1; i >= 0; i--)
            {
                DeleteFactory(indices[i]);
            }
            
            AddFactory(finalFactory);
        }
    }
}