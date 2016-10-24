using System;

namespace Huiswerk.Simpleton
{
    internal class Joshua
    {
        private static Joshua TheRealOG;
        private static readonly object SynchLock = new object();

        private Joshua()
        {
        }

        public static Joshua getInstance()
        {
            if (TheRealOG == null)
            {
                lock (SynchLock)
                {
                    TheRealOG = new Joshua();
                }
            }
            return TheRealOG;
        }

        public static void Preach()
        {
            Console.WriteLine("Smite is gud gam");
        }
    }
}