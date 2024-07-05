namespace W8_ITE5230_Lab8_Inclass.Entity
{
    public class Customer
    {
        public Customer() { }

        public int CustomerID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public override string? ToString()
        {
            return $"{Name}, {State}";
        }
    }
}
