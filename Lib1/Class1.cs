using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_1
{
    public class Car
    {
        string _marka;

        int _numOfCylinders;

        double _horsePower, _kW;

        public string Marka
        {
            get => _marka;
            set { if (value == "") _marka = null; else { _marka = value; } }
        }

        public double HorsePower
        {
            get => _horsePower;
            set { if (value >= 0) _horsePower = value; }
        }
        public double KW
        {
            get => _kW;
            set { if (value >= 0) _kW = value; }
        }

        public int NumOfCylinders
        {
            get => _numOfCylinders;
            set { _numOfCylinders = value; }
        }

        public Car()
        {
            _marka = "Lada";
            _numOfCylinders = 4;
            _horsePower = 106;
            _kW = 77.96;
        }


        /// <summary>
        /// Метод меняет параметры автомобиля
        /// </summary>
        /// <param name="marka">Марка автомобиля</param>
        /// <param name="numOfCylinders">Кол-во целиндров</param>
        /// <param name="kW"></param>
        public void SetParams(string marka, int numOfCylinders, double kW)
        {
            Marka = marka;
            NumOfCylinders = numOfCylinders;
            KW = kW;
            HorsePower = kW * 1.36;
        }

        /// <summary>
        /// Метод меняет параметры автомобиля
        /// </summary>
        /// <param name="marka">Марка автомобиля</param>
        /// <param name="numOfCylinders">Кол-во целиндров</param>
        public void SetParams(string marka, int numOfCylinders)
        {
            Marka = marka;
            NumOfCylinders = numOfCylinders;
        }

        /// <summary>
        /// Метод меняет параметры автомобиля
        /// </summary>
        /// <param name="marka">Марка автомобиля</param>
        /// <param name="kW"></param>
        public void SetParams(string marka, double kW)
        {
            Marka = marka;
            KW = kW;
        }
    }
}
