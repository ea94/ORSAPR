﻿using System;

namespace Thermos
{
    /// <summary>
    /// Класс хранит значение и ограничения.
    /// </summary>
    public class Parameter
    {
        #region Fields

        /// <summary>
        /// Значение.
        /// </summary>
        private double _value;

        /// <summary>
        /// Минимально возможное значение.
        /// </summary>
        private double _min;

        /// <summary>
        /// Максимально возможное значение.
        /// </summary>
        private double _max;

        #endregion

        #region Methods
        /// <summary>
        /// Событие об изменении параметра.
        /// </summary>
        public event EventHandler ParameterChanged;

        /// <summary>
        /// Сеттер и геттер значения.
        /// </summary>
        public double Value 
        {
            get { return _value; }
            set {
                if (_value == value)
                    return;
                GetValue(value, out _value);
            }
        }

        /// <summary>
        /// Метод обрабатывающий событие изменяющее значение.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="finalValue"></param>
        private void GetValue(double value, out double  finalValue)
        {
            finalValue = value;
            Validate();
            if (ParameterChanged != null)
            {
                ParameterChanged(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Сеттер и геттер минимального значения.
        /// </summary>
        public double Min 
        {
            get { return _min; }
            set
            {
                if (_min == value)
                    return;
                GetValue(value, out _min);
            }
        }

        /// <summary>
        /// Сеттер и геттер максимального значения.
        /// </summary>
        public double Max 
        {
            get { return _max; }
            set
            {
                if (_max == value)
                    return;
                _max = value;
                Validate();
                GetValue(value, out _max);
            }
        }

        /// <summary>
        /// Конструктор параметра.
        /// </summary>
        /// <param name="value">Начальное значение</param>
        /// <param name="min">Начальное минимальное значение</param>
        /// <param name="max">Начальное максимальное значение</param>
        public Parameter(double min, double value , double max)
        {
           _value = value;
            _min = min;
            _max = max;
            Validate();
            if (value >= Min && value <= Max)
            {
                _value = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Проверка на выход значения за допустимый диапазон.
        /// </summary>
        public void Validate()
        {
            if (Value > Max)
            {
                _value = Max;
            }
            if (Value < Min)
            {
                _value = Min;
            }
        }

        #endregion
    }
}
