namespace ExercAbstractClasses.Entities
{
    internal class Company : Payer
    {
        public int NumberOfEmployees { get; set; }

        public Company()
        {
        }

        public Company(int numberOfEmployees, string name, double anualIncome) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double result = 0.00;

            if (NumberOfEmployees <= 10)
            {
                result += AnualIncome * 0.16;
            }
            else
            {
                result += AnualIncome * 0.14;
            }

            return result;
        }
    }
}
