using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing14
{
   public class Frational
    {
        private int numerator;
        private int denominator;
        private decimal result;
        public int Numerator
        {
            get { return numerator; }
            set { this.numerator = value; }
        }
        public int Denominator
        {
            get { return denominator; }
            set { this.denominator = value; }
        }
        public Frational(int numerator, int denominator)
        {
            this.Denominator = denominator;
            this.Numerator = numerator;
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(this.Numerator + "/" + this.denominator);
            builder.Append(" or ");
            builder.Append(this.Numerator / this.Denominator);
            result = this.Numerator / this.Denominator;
            return result.ToString();
        }

    }
}
