namespace UsingCSharp
{
    public partial class Person
    {
        public string FullName { get; set; }
        public string UsualCurrency { get; set; }
        public decimal Goal { get; set; }
        public int MonthsToSave { get; set; }
        
        public Person()
        {

        }

        public Person(string fullName, string usualCurrency, decimal goal, int monthsToSave)
        {
            FullName = fullName;
            UsualCurrency = usualCurrency;
            Goal = goal;
            MonthsToSave = monthsToSave;
        }
    }
}
