﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, описывающий список товаров.
    /// </summary>
    class Cart
    {
        /// <summary>
        /// Список товаров в корзине.
        /// </summary>
        private List<Item> items;

        /// <summary>
        /// Возвращает и задаёт список товаров в корзине.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return items;
            }
            set
            {
                items = value;
            }
        }

        /// <summary>
        /// Возвращает сумму стоимости всех товаров. Если список пусть, то возвращает значение "0.0".
        /// </summary>
        public double Amount
        {
            get
            {
                if (items == null || items.Count == 0)
                {
                    return 0.0;
                }
                return Items.Sum(item => item.Cost);
            }
        }
    }
}