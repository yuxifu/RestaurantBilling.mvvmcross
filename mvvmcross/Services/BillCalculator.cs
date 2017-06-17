using System;
namespace RestaurantBilling.Core.Services
{
    public class BillCalculator : IBillCalculator
	{
		public double TipAmount(double subTotal, int gratuity)
		{
			return subTotal * gratuity / 100.0;
		}

		public double BillTotal(double subTotal, int gratuity)
		{
			return subTotal + TipAmount(subTotal, gratuity);
		}

		public double Gratuity(double subTotal, double tip)
		{
			// Ensure we don't divide by zero.
            return System.Math.Abs(tip) < Double.Epsilon ? 0 : subTotal / tip;
		}
	}
}

