using Consonant_substring_sums.SubstringSums;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        var substringSum = new SubstringSums();

        //substringSum.ShowResult(substringSum.SubtringSum(substringSum._testStrings.First()));

        foreach (var item in substringSum._testStrings)
        {
            substringSum.ShowResult(substringSum.SubtringSum(item));
        }
    }
}