using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class FizzBuzzUseInterface
    {
        private List<IConvertRule> rules;

        public FizzBuzzUseInterface()
        {
            rules = new List<IConvertRule>();
            rules.Add(new StandardConvertRule(3, "Fizz"));
            rules.Add(new StandardConvertRule(5, "Buzz"));
            rules.Add(new PassRule());
        }

        public string convert(int n)
        {
            var converted = "";
            foreach(IConvertRule rule in this.rules)
            {
                if (rule.match(n, converted))
                {
                    converted = rule.apply(n, converted);
                }
            }
            return converted;
        }

    }

    internal interface IConvertRule
    {
        public bool match(int n, string convert);
        public string apply(int n, string convert);
    }

    internal class StandardConvertRule : IConvertRule
    {
        private int divine { get; set; }
        private string translate { get; set; }

        public StandardConvertRule(int divine, string translate)
        {
            this.divine = divine;
            this.translate = translate;
        }

        public bool match(int n, string convert)
        {
            if (n % this.divine == 0) return true;
            return false;
        }
        public string apply(int n, string convert)
        {
            return convert += this.translate;
        }

    }

    internal class PassRule : IConvertRule
    {
        public bool match(int n, string convert)
        {
            if (convert.Length == 0) return true;
            return false;
        }

        public string apply(int n, string convert)
        {
            return n.ToString();
        }

    }
}
