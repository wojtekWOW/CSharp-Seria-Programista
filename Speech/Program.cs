using System;
using System.Speech.Synthesis;

namespace Speech
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak(" Anna is the most beautiful girl in the world");            
        }
    }
}
