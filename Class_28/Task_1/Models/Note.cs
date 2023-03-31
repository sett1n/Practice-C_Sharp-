using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Models
{
    public class Note
    {
        public string Surname { get; set; }
        public string Birthday { get; set; }
        public string NumberPhone { get; set; }
        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine($"------->Surname is {Surname}")
                .AppendLine($"\tbrthday is {Birthday}")
                .AppendLine($"\tphone number is {NumberPhone}")
                .ToString();
        }
    }
}
