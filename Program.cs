using System.Text;
using Newtonsoft.Json.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Saber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntToBinaryStringFormat(5);
            var data = new StringBuilder("AAA BBB AAA");
            RemoveDups(data);
            Console.WriteLine(data); 
        }

        static public string IntToBinaryStringFormat(int num)
        {
            string ToBinary(string s)
            {
                while (true)
                {
                    s += num % 2; 
                    num = num / 2;
                    if (num == 0)
                        break;
                }
                s = new string(s.ToCharArray().Reverse().ToArray()).PadLeft(31, '0');
                return s;
            }

            string result = "";
            if (num < 0)
            {
                num=Int32.MaxValue+num+1;
                result = ToBinary(result).PadLeft(32, '1');
            }
            else
            {
                result = ToBinary(result).PadLeft(32, '0');
            }
            Console.WriteLine(result);//так как по заданию функция должна печатать результат.
                                      //Альтернатива - создать в классе функцию Print(string text)
                                      //и передавать в нее результат работы текущей функции
            return result;
        }

        static public void RemoveDups(StringBuilder str)
        {
            StringBuilder result = new StringBuilder();
            result.Append(str[0]);

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] != str[i - 1])
                {
                    result.Append(str[i]);
                }
            }

            str.Clear();
            str.Append(result);
        }
        
    }
}