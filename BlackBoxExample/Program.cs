using System;

namespace BlackBoxExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            AdvancedNumberAnalysisAlgortihm ANAA = new AdvancedNumberAnalysisAlgortihm();
            Console.WriteLine(ANAA.simplePartWhichNeedsOutputFromComplexPart());
        }
    }

    class AdvancedNumberAnalysisAlgortihm
    {
        public double insanelyComplexPartThatWillTakeAllYear(double input)
        {
            //Not yet implemented
            return 3.134523;
        }

        public double simplePartWhichNeedsOutputFromComplexPart()
        {
            return 374 * insanelyComplexPartThatWillTakeAllYear(2.033);
        }
    }
}