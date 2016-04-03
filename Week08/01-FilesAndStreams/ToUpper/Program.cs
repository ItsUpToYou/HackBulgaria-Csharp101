namespace ToUpper
{
    using System.Collections.Generic;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            string txtLine = string.Empty;
            List<string> text = new List<string>();

            using (StreamReader sr = new StreamReader("TestText.txt"))
            {
                while (true)
                {
                    txtLine = sr.ReadLine();
                    if (txtLine == null) break;

                    text.Add(txtLine);
                }

            }

            using (StreamWriter sw = new StreamWriter("TestTextNew.txt"))
            {
                foreach (var letter in text)
                {
                    sw.WriteLine(letter.ToUpper());
                }
            }
        }
    }
}
