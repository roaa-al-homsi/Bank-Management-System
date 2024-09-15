namespace BankSystemValidation
{
    public static class Validation
    {
        static public bool ISNumber(string Text)
        {
            return (int.TryParse(Text, out int Answer) && Text != "");

        }




    }
}
