namespace DotNetTraining.Lesson1.Variables
{
    public class DataTypesExample
    {
        public void InitialiseBoolVariables()
        {
            bool alive = true;
            bool isDead = false;
        }

        public void InitialiseByteVariables()
        {
            byte bit1 = 1;
            byte bit2 = 102;
        }

        public void InitialiseSByteVariables()
        {
            sbyte bit1 = -101;
            sbyte bit2 = 102;
        }

        public void InitialiseShortVariables()
        {
            short n1 = -1;
            short n2 = 102;
        }

        public void InitialiseUShortVariables()
        {
            ushort n1 = 1;
            ushort n2 = 102;
        }

        public void InitialiseIntVariables()
        {
            System.Int32 a = -10;
            int b = 0b101; //5
            int c = 0xFF; //255
        }

        public void InitialiseUIntVariables()
        {
            uint a = 10;
            uint b = 0b101;
            uint c = 0xFF;
        }

        public void InitialiseLongVariables()
        {
            long a = -10;
            long b = 0b101;
            long c = 0xFF;
        }

        public void InitialiseULongVariables()
        {
            ulong a = 10UL;
            ulong b = 0b101;
            ulong c = 0xFF;
        }

        public void InitialiseCharVariables()
        {
            char a = 'A';
            char b = '\x5A';
            char c = '\u0420';
        }

        public void InitialiseStringVariables()
        {
            string hello = "Hello";
            string word = "world";
        }

        public void InitialiseObjectVariables()
        {
            object a = 22;
            object b = 3.14;
            object c = "hello code";
        }

        public void InitialiseFloatDecimalVariables()
        {
            float a = 3.14F;
            float b = 30.6f;

            decimal c = 1005.8M;
            decimal d = 334.8m;

            var e = 10.2m;
        }
    }
}