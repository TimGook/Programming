using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Song
    {
        private int _runTimeInSeconds;

        public string Name { get; set; }

        public string Group { get; set; }

        public int RunTimeInSeconds
        {
            get
            {
                return _runTimeInSeconds;
            }
            set
            {
                if (!Validator.AssertOnPositiveValue(value))
                {
                    throw new ArgumentException("неправильно введёно время песни");
                }
                _runTimeInSeconds = value;
            }
        }

        //Конструкторы
        public Song(string name, string group, int runTimeInSeconds)
        {
            Name = name;
            Group = group;
            RunTimeInSeconds = runTimeInSeconds;
        }

        public Song()
        {

        }
    }
}
