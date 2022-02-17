namespace ConceptsPOO
{
    public class CommissionEmployee:Employee
    {
        public float CommissionPercentaje { get; set; }
        public decimal Sales { get; set; }

        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPercentaje;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
            $"\n\t Commission percentaje: {$"{CommissionPercentaje:P2}",18}" +
            $"\n\t Sales................: {$"{Sales:C2}",18}" +
            $"\n\t Value to pay.........: {$"{GetValueToPay():C2}",18}";
        }
    }
}