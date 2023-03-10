using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3.Model
{
    internal class MyInfo
    {
        delegate void ChangingInformation();
        event ChangingInformation ciEvent;


        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    ciEvent?.Invoke();
                }
            }
        }

        public MyInfo(string name)
        {
            _name = name;
            ciEvent += delegate ()
            {
                Console.WriteLine("Имя изменилось");
            };
        }
    }
}
