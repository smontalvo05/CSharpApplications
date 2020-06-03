using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stevemontalvo_CE04
{
    class Car
    {
        string _make;
        string _model;
        string _color;
        float _mileage;
        int _year;

        public Car (string Make, string Model, string Color, float Mileage, int Year)
        {
            _color = Color;
            _make = Make;
            _mileage = Mileage;
            _year = Year;
            _model = Model;
            Program.GetLogger().LogD(Color);
            Program.GetLogger().LogD(Make);
            Program.GetLogger().LogD(Model);
            Program.GetLogger().LogD(Mileage.ToString());
            Program.GetLogger().LogD(Year.ToString());        

        }
      
        public void Drive(float mileage)
        {
            _mileage = mileage;
            Program.GetLogger().LogW(mileage.ToString());
        }
        

        public string Make
        {
            get
            {
                return _make;
            }

            set
            {
                _make = value;
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }

            set
            {
                _model = value;
            }
        }

        public string Color
        {
            get
            {
                return _color;
            }

            set
            {
                _color = value;
            }
        }

        public float Mileage
        {
            get
            {
                return _mileage;
            }

            set
            {
                _mileage = value;
            }
        }

        public int Year
        {
            get
            {
                return _year;
            }

            set
            {
                _year = value;
            }
        }
    }
}
