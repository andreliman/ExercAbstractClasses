namespace ExercAbstractClasses.Entities
{
    internal class Individual : Payer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(double healthExpenditures, string name, double anualIncome) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double result = 0.00;

            if (AnualIncome < 20000 && HealthExpenditures <= 0)
            {
                result += (AnualIncome * 0.15);
            }
            else if (AnualIncome < 2000 && HealthExpenditures > 0)
            {
                result += (AnualIncome * 0.15) - (HealthExpenditures * 0.5);
            }
            else if (AnualIncome >= 2000 && HealthExpenditures <= 0)
            {
                result += (AnualIncome * 0.25);
            }
            else
            {
                result += (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
            }
            return result;
        }

    }
}
