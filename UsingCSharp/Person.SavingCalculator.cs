namespace UsingCSharp
{
    public partial class Person
    {
        public decimal GetMyAmount()
        {
            return this.Goal/this.MonthsToSave;
        }
    }
}
