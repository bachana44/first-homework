namespace six_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("chaweret teqsti: ");
            string userText = Console.ReadLine();
            string firstLetter = userText[0].ToString().ToUpper();
            

            userText = userText.Replace(userText[0].ToString(),firstLetter);
            Console.WriteLine(userText);
            
        }
    }
}
