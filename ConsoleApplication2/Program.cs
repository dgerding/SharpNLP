using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        private static string mModelPath = @"C:\Projects\DotNet\OpenNLP\OpenNLP\Models\";
        private static OpenNLP.Tools.SentenceDetect.MaximumEntropySentenceDetector mSentenceDetector;

        static void Main(string[] args)
        {
            if (mSentenceDetector == null)
            {
                mSentenceDetector = new OpenNLP.Tools.SentenceDetect.EnglishMaximumEntropySentenceDetector(mModelPath + "EnglishSD.nbin");
            }

            var test = mSentenceDetector.SentenceDetect("Not a chance. Hi! Mr. Arnold L. Watson is a big guy. I'm three sentences.  Are you?");
        }
    }
}


