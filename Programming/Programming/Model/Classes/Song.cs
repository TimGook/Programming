using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Содержит информацию о песне.
    /// </summary>
    class Song
    {
        /// <summary>
        /// Время проигрывания в секундах.
        /// </summary>
        private int _runTimeInSeconds;

        /// <summary>
        /// Задаёт и возвращает название песни.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Задаёт и возвращает название группы.
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        /// Задаёт и возвращает время проигрывания в секундах. Дожно быть больше 0.
        /// </summary>
        public int RunTimeInSeconds
        {
            get
            {
                return _runTimeInSeconds;
            }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _runTimeInSeconds = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="name"> Названеи песни. </param>
        /// <param name="group"> Название группы. </param>
        /// <param name="runTimeInSeconds"> Время проигрывания в секундах. Дожно быть больше 0. </param>
        public Song(string name, string group, int runTimeInSeconds)
        {
            Name = name;
            Group = group;
            RunTimeInSeconds = runTimeInSeconds;
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Song"/>.
        /// </summary>
        public Song()
        {

        }
    }
}
