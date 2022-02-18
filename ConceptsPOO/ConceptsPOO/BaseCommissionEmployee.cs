namespace ConceptsPOO
{
    public class BaseCommissionEmployee : CommissionEmployee
    {
        public decimal Base { get; set; }

        public override decimal GetValueToPay()
        {
            return Base + base.GetValueToPay();
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
            $"\n\t Base.................: {$"{Base:C2}",18}"; 
        }
    }
}
