using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2employee


{
    abstract class OperateCost
    {
        public double salary;
        public double tax;
        public string position;

        public abstract void ApplyBonus(double bonus, double grade);
        public abstract void ApplyTax();
        public abstract void ApplyPosition();
    }

    class Slave : OperateCost
    {
        public override void ApplyBonus(double bonus, double grade)
        {
            salary = (10000 + 2 * bonus) * grade;
        }

        public override void ApplyPosition()
        {
            throw new NotImplementedException();
        }

        public override void ApplyTax()
        {
            tax = salary * 0.31;
        }
    }

    class Warden : OperateCost
    {
        public override void ApplyBonus(double bonus, double grade)
        {
            salary = (100000 + 5 * bonus) * grade;
        }

        public override void ApplyPosition()
        {
            throw new NotImplementedException();
        }

        public override void ApplyTax()
        {
            tax = salary * 0.31;
        }
    }

    class Lord : OperateCost
    {
        public override void ApplyBonus(double bonus, double grade)
        {
            salary = (1000000 + 10 * bonus) * grade;
        }

        public override void ApplyPosition()
        {
            throw new NotImplementedException();
        }

        public override void ApplyTax()
        {
            tax = salary * 0.31;
        }
    }
}
