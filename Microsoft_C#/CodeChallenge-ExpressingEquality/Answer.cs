namespace CodeChallenge_ExpressingEquality
{
    public struct Answer
    {
        // Change these Boolean values to control whether you see 
        // the expected result and/or hints.
        public static Boolean ShowExpectedResult = false;
        public static Boolean ShowHints = false;

        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime HireDate { get; set; }

        // Custom operator == implementation
        public static bool operator ==(Answer a, Answer b) =>
        a.Name == b.Name && a.Age == b.Age && a.HireDate == b.HireDate;

        // Custom operator!= implementation
        public static bool operator !=(Answer a, Answer b) => !(a == b);
    }
}
