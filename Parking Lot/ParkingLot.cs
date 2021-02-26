using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    class ParkingLot
    {
        //Fields
        private int LargeCar;
        private int MediumCar;
        private int SmallCar;

        //Constructors
        public ParkingLot(int setLargeCar = 1, int setMediumCar = 1, int setSmallCar = 1)
        {
            SetLargeCar(setLargeCar);
            SetMediumCar(setMediumCar);
            SetSmallCar(setSmallCar);
        }

        //Methods
        public void SetLargeCar(int setValue)
        {
            LargeCar = setValue;
        }

        public void SetMediumCar(int setValue)
        {
            MediumCar = setValue;
        }

        public void SetSmallCar(int setValue)
        {
            SmallCar = setValue;
        }

        public bool AddCar(string carType)
        {
            bool answer = true;
            if (carType == "Large")
            {
                if (LargeCar > 0)
                {
                    LargeCar -= 1;
                    answer = true; 
                }
                else
                {
                    answer = false;
                }
            }

            else if (carType == "Medium")
            {
                if (MediumCar > 0)
                {
                    MediumCar -= 1;
                    answer = true;
                }
                else
                {
                    answer = false;
                }
            }

            else if (carType == "Small")
            {
                if (SmallCar > 0)
                {
                    SmallCar -= 1;
                    answer = true;
                }
                else
                {
                    answer = false;
                }
            }
            return answer;
        }
        public int GetLargeCar()
        {
            return LargeCar;
        }
        public int GetMediumCar()
        {
            return MediumCar;
        }
        public int GetSmallCar()
        {
            return SmallCar;
        }

    }
}
