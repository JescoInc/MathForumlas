using System;

namespace Formula.BasicMath
{
    public static class InterestingPhysics
    {
        public static int MassEnergyEquivalence(int mass, int lightspeed)
        {
            // E = MC2
            // Wanted to make it more readable, so I broke it down.
            int result = mass * (lightspeed);
            int energy = result * (mass * (lightspeed));

            return energy;
        }

        public static int LoanPayment(int amount, double interestRate, int Payments)
        {
            // M = P * (J / (1 - (1 + J) - N))
            int rates = (amount * (Convert.ToInt32(interestRate) / (1 - (1 + Convert.ToInt32(interestRate))))) - Payments;

            return rates;
        }

        public static int Gravity(int gravitationalConstant, int mass1, int mass2, int distance)
        {
            // F = Gm1m2 / d(squared)

            int results = gravitationalConstant * mass1 * mass2 / (distance * distance);

            return results;
        }
    }
}
