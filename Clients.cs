using System;
using System.Collections.Generic;
using System.Text;

namespace People_Credits
{
    public abstract class Clients
    {
		public enum EType
		{
			Base,
			Bad,
			Inner,
			Benefits
		}
		public string Name;
		public int Age { get; private set; }
		public abstract EType Type { get; }

		public Clients(string _name, int _age)
		{
			Name = _name;
			Age = _age;
		}


		public virtual string ShowCreditAmountAndProcent()
		{
	
			return string.Empty;
		}
		public virtual double MonthPayTest()
		{

			return double.NaN;
		}
	}
	
}
