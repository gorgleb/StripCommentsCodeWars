using System;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Data;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace CodeWars
{
    class Program
    {

        static void Main(string[] args)
        {
            string text = "bananas apple ! sex";
            string[] commentSymbols = new string[] { "!", "#" };

            Console.WriteLine(Kata.StripComments(text,commentSymbols));  

        }


    }




    
    public static class Kata
    {
        public static string StripComments(string text, string[] commentSymbols)
        {
            List<string> result = text.Split(new char[] { ' ' }).ToList();
            List<string> comment = new List<string>(commentSymbols);
            //List<string> output = new List<string>();
            //output = from u in result from c in comment where  select u;
            foreach (string r in result)
            {
                foreach (string c in comment)
                {
                    if (r.Equals(c))
                    {
                        result.Remove(r);
                        

                    }

                }
                Console.WriteLine(result.ToString());
                
            }
            return "asd";
        }
    }

}
     




    