namespace MyFuncFile
{
    public class PhoneModel
    {
        //DataFields
        public string? PhoneNumber { get; }

        //Constructor
        public PhoneModel(string inputPhoneNumber)
        {
            PhoneNumber = FormatPhoneNumber(inputPhoneNumber);
        }

        //Functions
        public string FormatPhoneNumber(string input)
        {

            if (input.Length < 10)//checking for just 10 numbers
            {
                Console.WriteLine("you dumb");
                throw new ArgumentException("your retarded");
            }

            string areaCode = input.Substring(0, 3);
            string firstThree = input.Substring(3, 3);
            string lastFour = input.Substring(6);
            return ("(" + areaCode + ") " + firstThree + "-" + lastFour);
        }
    }
}
