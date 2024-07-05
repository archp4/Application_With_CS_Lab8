namespace W8_ITE5230_Lab8_Inclass.Entity
{
    public class State
    {
        public State() { }

        public string StateCode { get; set; }

        public string StateName { get; set; }

        public override string? ToString()
        {
            return $"{StateName}";
        }
    }
}
