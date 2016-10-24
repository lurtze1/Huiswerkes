namespace Oefentoets_Design_Patterns.Wiskunde
{

    //Opgave 1
    internal class Wiskunde
    {
        private static Wiskunde _wiskunde;
        private static readonly object SyncLock = new object();


        /*Een getinstance zorgt ervoor dat het object alleen maar benaderbaar is van een punt.
         * Het zorgt er ook voor dat er meer een instancy is van de Wiskunde klasse.
         * 
        De Synchlock zorgt ervoor dat een systeem niet meerdere instanties van deze klasse kan aanmaken.*/

        public static Wiskunde GetInstance()
        {
            if (_wiskunde == null)
            {
                lock (SyncLock)
                {
                    _wiskunde = new Wiskunde();
                }
            }
            return _wiskunde;
        }

        public float Sum(float x, float y)
        {
            return x + y;
        }

        public float Subtract(float x, float y)
        {
            return x - y;
        }

        public float Divide(float x, float y)
        {
            return x/y;
        }

        public float Multiply(float x, float y)
        {
            return x*y;
        }
    }
}