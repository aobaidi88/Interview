using System;
using System.Collections.Generic;

namespace ObaidiP4.Shared
{
    public class DepreciationDoubleDeclining:DepreciationStraightLine
    {
        public DepreciationDoubleDeclining(double startValue, double salvageValue, int lifeTime, int age)
        {
            this.startValue = startValue;
            this.salvageValue = salvageValue;
            this.lifeTime = lifeTime;
            this.age = age;
            Calc();
        }

        public DepreciationDoubleDeclining() : this(0, 0, 0, 0)
        {
        }
        public override void Calc()
        {
            data = new List<double>();
            str = "";
            double rate, balance;
            rate = ((1.0 / lifeTime) * 2);
            balance = rate * startValue;
            EndValue = startValue;
            data.Add(startValue / 100.0);
            for (int i = 0; i < age; i++)
            {
                EndValue -= balance;
                balance = (EndValue*rate);
                data.Add(EndValue / 100.0);
            }
            str = String.Join(',', data);
        }

        public override string ToString() => base.ToString();
    }
  }
