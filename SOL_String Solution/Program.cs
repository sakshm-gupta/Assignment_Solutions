namespace String_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "The quick brown fox jumps over the lazy dog";
            Console.WriteLine(s[12]);//1
            Console.WriteLine(s.Contains("is"));//2
            s = s + " and killed it";//3
            Console.WriteLine(s);//3
            Console.WriteLine(s.EndsWith("dogs"));//4
            Console.WriteLine(s.Equals("The quick brown Fox jumps over the lazy Dog"));//5
            Console.WriteLine(s.Equals("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG"));//6
            Console.WriteLine(s.Length);//7
            s = s.Replace("the", "a");
            Console.WriteLine(s);//9
            string[] arr = s.Split("over");//10
            Console.WriteLine(String.Join(",",arr));//10

            Console.WriteLine(s.ToLower());//12
            Console.WriteLine(s.ToUpper());//13
            Console.WriteLine(s.IndexOf("a"));//14
            Console.WriteLine(s.LastIndexOf("e"));//15
            Console.WriteLine(" enter the home directory of Tomcat server.");
            string path = Console.ReadLine();
            string Npath = @"WebApps/MyApps/Images" + path;
            Console.WriteLine(Npath);//16
            string poem = @"I WANDER'D lonely as a cloud" +(char)10+
                "That floats on high o'er vales and hills" + (char)10+
                "When all at once I saw a crowd" + (char)10 + "A host, of golden daffodils;Beside the lake, beneath the trees" + (char)10 +
                "Fluttering and dancing in the breeze.";//18
            Console.WriteLine(poem);
            





        }
    }
}