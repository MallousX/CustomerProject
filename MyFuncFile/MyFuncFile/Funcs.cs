namespace MyFuncFile
{
    public class Funcs
    {
        // returns current date in (exp. March 4, 2023)

        public string GetformattedDate()
        {
            string formattedDate = DateTime.Now.ToString("MMMM d, yyyy");
            return formattedDate;
        }


    }
}
