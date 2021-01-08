using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
  public  class CalculateFactory
    {
		public ICalculate GetCalculate(String type)
		{
			ICalculate obj = null;

			if (type.ToLower().Equals("add"))
			{
				obj = new Add();
			}
			else if (type.ToLower().Equals("divide"))
			{
				obj = new Divide();
			}
			else
			{
				Console.WriteLine("no calculation");

			}
			return obj;
		}

	}
}
