using system;

namespace Programming_Qs___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Original text: ");
            string text = Console.ReadLine();
            string compressed = "";
            for (int i = 0; i < text.Length; i++)
            {
                int counter = 0;
                char letter = text[i];
                compressed += Convert.ToString(letter);
                int j = i + 1;
                counter = 1;
                while (j < text.Length -1)
                {
                    if (text[j] == letter)
                    {
                        counter++;
                        j++;
                    }
                    else
                    {
                        break;
                    }
                }
                compressed += " " + Convert.ToString(counter);
            }
            Console.WriteLine($"Compressed text: {compressed}");
        }
    }
}
