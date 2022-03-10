namespace LoginPage
{
    public class Validator
    {
        public int MinLength { get; set; }
        public int MaxLength { get; set; }

        public Validator()
        {
            MinLength = 4;
            MaxLength = 16;
        }

        public string Validate(string arg)
        {
            if (string.IsNullOrEmpty(arg))
            {
                return " is required.";
            }
            else if (arg.Length < MinLength || arg.Length > MaxLength)
                return $" Must be between {MinLength} and {MaxLength}";
            else
                return null;
        }
    }
}