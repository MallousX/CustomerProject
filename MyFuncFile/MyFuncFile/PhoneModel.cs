namespace MyFuncFile
{
    public class PhoneModel
    {
        //DataFields
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? PhoneNumber { get; }
        public string PhoneType { get; set; }

        //Constructor
        public PhoneModel(int id, int userId, string inputPhoneNumber, string phoneType)
        {
            Id = id;
            UserId = userId;
            PhoneType = phoneType;
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
