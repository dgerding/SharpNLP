using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenNLP;
using OpenNLP.Tools;

namespace ConsoleApp1
{
    public class Program
    {

        private string mModelPath= @"C:\Projects\DotNet\OpenNLP\OpenNLP\Models";

        private OpenNLP.Tools.SentenceDetect.MaximumEntropySentenceDetector mSentenceDetector;

        public void Main(string[] args)
        {
            if (mSentenceDetector == null)
            {
                mSentenceDetector = new OpenNLP.Tools.SentenceDetect.EnglishMaximumEntropySentenceDetector(mModelPath + "EnglishSD.nbin");
            }

            var test = mSentenceDetector.SentenceDetect("Hi! I'm three sentences.  Are you?");
        }
    }
}
