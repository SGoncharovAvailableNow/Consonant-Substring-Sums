using Consonant_substring_sums.SubstringSumsResponse;

namespace Consonant_substring_sums.SubstringSums
{
    internal class SubstringSums
    {
        private readonly char[] _delimiterChars = { 'a', 'e', 'i', 'o', 'u', 'y' };

        private readonly Dictionary<char, int> _alphabet = new Dictionary<char, int>()
        {
            { 'b', 2 }, {'c', 3 }, {'d', 4 },
            { 'f', 6 }, { 'g', 7 }, {'h', 8 },
            { 'j', 10 }, {'k', 11 }, {'l', 12 },
            { 'm', 13 }, { 'n', 14 }, { 'p', 16 },
            { 'q', 17 }, { 'r', 18 }, { 's', 19 },
            { 't', 20 }, { 'v', 22 }, { 'w', 23 },
            { 'x', 24 }, { 'z', 26 }
        };

        private int _charSum = 0;

        public List<string> _testStrings = new List<string>()
        {
            "zodiacs",
            "strength",
            "",
            "     ",
            "ajnsdf jnaseij pirpnsdnboa 8wefywaqodbv jkanlodfuh gpqwe",
            "Allohha"
        };

        public SubstringSumResult SubtringSum(string innerString)
        {

            if (string.IsNullOrEmpty(innerString) || string.IsNullOrWhiteSpace(innerString) || innerString.Contains(" "))
            {
                return new SubstringSumResult
                {
                    Description = "Invalid parameters! English alphabet only, without spaces!",
                    Result = 0
                };
            }

            List<int> substringNumericValues = new List<int>();

            string[] splittedString = innerString.ToLower().Split(_delimiterChars);

            foreach (string substing in splittedString)
            {
                var charsInSubstring = substing.ToCharArray();

                _charSum = 0;

                foreach (char ch in charsInSubstring)
                {
                    if (_alphabet.ContainsKey(ch))
                    {
                        _charSum += _alphabet.GetValueOrDefault(ch);
                    }
                }

                substringNumericValues.Add(_charSum);
            }

            return new SubstringSumResult
            {
                Description = innerString,
                Result = substringNumericValues.Max()
            };
        }

        public int ReturnMaxSubstringSum(string innerString)
        {
            return innerString.Split(_delimiterChars, StringSplitOptions.RemoveEmptyEntries).Max(x => x.Sum(c => c - 96));
        }

        public int SubstringsMaxSum(string str)
        {
            return str.ToLowerInvariant().Split(_delimiterChars, StringSplitOptions.RemoveEmptyEntries).Max(x => x.Sum(c => c - 'a' + 1));
        }

        public void ShowResult(SubstringSumResult result)
        {
            Console.WriteLine($"{result.Description} \t Result: {result.Result} \n");
        }

    }
}
