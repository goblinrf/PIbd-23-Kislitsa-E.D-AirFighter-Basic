﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirFighter
{
    public class EntityAirFighter
    {
        /// <summary>
        /// Скорость
        /// </summary>
        public int Speed { get; private set; }
        /// <summary>
        /// Вес
        /// </summary>
        public double Weight { get; private set; }
        /// <summary>
        /// Основной цвет
        /// </summary>
        public Color BodyColor { get; private set; }
        /// <summary>
        /// Дополнительный цвет (для опциональных элементов)
        /// </summary>
        public Color AdditionalColor { get; private set; }
        /// <summary>
        /// Признак (опция) наличия обвеса
        /// </summary>
        public bool Racket { get; private set; }
        /// <summary>
        /// Признак (опция) наличия антикрыла
        /// </summary>
        public bool Wing { get; private set; }
        /// <summary>
        /// Признак (опция) наличия гоночной полосы
        /// </summary>

        /// <summary>
        /// Шаг перемещения автомобиля
        /// </summary>
        public double Step => (double)Speed * 100 / Weight;
        /// <summary>
        /// Инициализация полей объекта-класса спортивного автомобиля
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="bodyColor">Основной цвет</param>
        /// <param name="additionalColor">Дополнительный цвет</param>
        /// <param name="racket">Признак наличия обвеса</param>
        /// <param name="wing"

        public void Init(int speed, double weight, Color bodyColor, Color
        additionalColor, bool racket, bool wing)
        {
            Speed = speed;
            Weight = weight;
            BodyColor = bodyColor;
            AdditionalColor = additionalColor;
            Racket = racket;
            Wing = wing;

        }
    }
}

