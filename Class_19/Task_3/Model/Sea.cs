using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Task_3.Model
{
    [Serializable]
    class Sea : Prototype
    {
        string name;
        double depth;
        List<string> fishes;
        public Sea(string name, double depth, List<string> fishes)
        {
            this.name = name;
            this.depth = depth;
            this.fishes = fishes;
        }
        public Prototype Clone()
        {
            return this.MemberwiseClone() as Prototype;
        }
        public object DeepCopy()
        {
            object sea = null;
            using (MemoryStream tempStream = new MemoryStream())
            {
                BinaryFormatter binFormatter = new BinaryFormatter(null,
                    new StreamingContext(StreamingContextStates.Clone));

                binFormatter.Serialize(tempStream, this);
                tempStream.Seek(0, SeekOrigin.Begin);

                sea = binFormatter.Deserialize(tempStream);
            }
            return sea;
        }
        public void GetInfo()
        {
            string info = $"Название моря: {name} \nГлубина моря: {depth} \nРыбки в море: ";
            foreach(string fish in fishes)
            {
                info = info + fish + ", ";
            }
            info = info.Substring(0, info.Length - 2);
            Console.WriteLine(info);
        }

        public void AddFish(string fish)
        {
            fishes.Add(fish);
        }
    }
}
