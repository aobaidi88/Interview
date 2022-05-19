﻿using System;
using System.Collections.Generic;

namespace ObaidiP4.Shared
{
   public class DepreciationStraightLine
    {
        protected double startValue;
        protected double salvageValue;
        protected int lifeTime;
        protected int age;
                            
        public double StartValue { get { return startValue; } set { startValue = value; Calc(); }}
        public double SalvageValue { get { return salvageValue; } set { salvageValue = value; Calc(); } }
        public int LifeTime { get { return lifeTime; } set { lifeTime = value; Calc(); } }
        public int Age { get { return age; } set { age = value; Calc(); } }
        public double EndValue { get; protected set; }
        public string str { get; protected set; }
        public List<double> data { get; protected set; }

        public DepreciationStraightLine(double startValue, double salvageValue, int lifeTime, int age)
        {
            this.startValue = startValue;
            this.salvageValue = salvageValue;
            this.lifeTime = lifeTime;
            this.age = age;
            Calc();
        }

        public DepreciationStraightLine() : this(0, 0, 0, 0)
        {
        }

        public virtual void Calc()
        {
            data = new List<double>();
            str = "";
            double assetCost, annualDepreciation, rate;
            rate = (1.0 / lifeTime);
            assetCost = (startValue - salvageValue);
            annualDepreciation = (assetCost * rate);
            EndValue = startValue;
            data.Add(startValue / 100.0);
        for (int i = 0; i < age ; i++)
            {
                EndValue -= annualDepreciation;
                data.Add(EndValue / 100.0);
            }
            str = String.Join(',', data);
        }

        public override string ToString()
        {
            string summary = $"Start Value of: ${StartValue} and Salvage Value of: ${SalvageValue} after {LifeTime} years, has a value of ${EndValue} at year {Age} using ";
            return summary;
        }
    }
}
