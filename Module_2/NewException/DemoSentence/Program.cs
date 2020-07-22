using System;

namespace DemoSentence
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //try
            //{
            //    var s = new Sentence("");
            //    Console.WriteLine(s.GetFirstCharacter());
            //}catch(NullReferenceException e)
            //{
            //    Console.WriteLine($"{e.GetType().Name},{e.Message}");
            //}
            var sentence = new Sentence("abc");
            try
            {
                Console.WriteLine(sentence.GetFirstCharacter());
            }catch(NullReferenceException e)
            {
                Console.WriteLine($"{e.GetType().Name},{e.Message}");
            }
            
        }
    }
    public class Sentence
    {
        private string value { get; set; }
        public Sentence(string s)
        {
            value = s;
        }
        public string Value { get => value; }
        public char GetFirstCharacter()
        {
            if(value != "")
            {
                return this.Value[0];
            }
            else
            {
                throw new NullReferenceException();
            }
        }

    }
}
