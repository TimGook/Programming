﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Содержит информацию о товаре.
    /// </summary>
    class Item
    {
        /// <summary>
        /// Счётчик для <see cref="Id"/>.
        /// </summary>
        private static int _idCounter = 0;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Описание товара.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает идентификатор.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Возврашает и задаёт название товара. Не может быть больше 200 символов.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, "Name");
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт описание товара. Не может быть больше 1000 символов.
        /// </summary>
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, "Info");
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт стоимость товара. Не может быть больше 100 000 и меньше 0.
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                ValueValidator.AssertDoubleInRange(value, 100_000.0, 0.0, "Cost");
                _cost = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name"> Название товара. Не может быть больше 200 символов.</param>
        /// <param name="info"> Описание товара. Не может быть больше 1000 символов</param>
        /// <param name="cost"> Стоимость товара. Не можеть быть больше 100 000 и меньше 0.</param>
        public Item(string name, string info, int cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
            _idCounter++;
            Id = _idCounter;
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Item"/>.
        /// </summary>
        public Item()
        {
            _idCounter++;
            Id = _idCounter;
        }
    }
}