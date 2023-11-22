using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.DopMission4
{
    /// <summary>
    /// Содержит информацию о ребёнке.
    /// </summary>
    class Kid:Person
    {
        /// <summary>
        /// Любимая игрушка.
        /// </summary>
        private string _favoriteToy;

        /// <summary>
        /// Задаёт и возвращает название любимой игрушки.
        /// </summary>
        public string FavoriteToy
        {
            get
            {
                return _favoriteToy;
            }
            set
            {
                _favoriteToy = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр ребёнка.
        /// </summary>
        /// <param name="firstName">Имя.</param>
        /// <param name="lastName">Фамилия.</param>
        /// <param name="age">Возраст.</param>
        /// <param name="favoriteToy">Любимая игрушка.</param>
        public Kid(string firstName, string lastName, int age, string favoriteToy) : base(firstName, lastName, age)
        {
            FavoriteToy = favoriteToy;
        }
    }
}
