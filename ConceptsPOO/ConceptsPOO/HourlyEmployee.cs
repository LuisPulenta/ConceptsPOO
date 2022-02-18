namespace ConceptsPOO
{
    public class HourlyEmployee : Employee
    {
        public float Hours { get; set; }
        public decimal HourValue { get; set; }

        public override decimal GetValueToPay()
        {
            return HourValue * (decimal)Hours;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
            $"\n\t Hours................: {$"{Hours:N2}",18}" +
            $"\n\t HourValue............: {$"{HourValue:C2}",18}" +
            $"\n\t Value to pay.........: {$"{GetValueToPay():C2}",18}";
        }
    }
}
