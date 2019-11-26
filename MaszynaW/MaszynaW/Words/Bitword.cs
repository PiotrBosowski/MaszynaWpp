namespace MaszynaW.Bitwords
{
    public class Bitword
    {
        public Bitword(int len, int val = 0)
        {
            length = len;
            Value = val;
        }

        private readonly int length;
        public int Length
        {
            get => length;
        }
        private int value;
        private int Value
        {
            get => value;
            set => this.value = value << 32-length >> 32-length; //32 - intsize
        }

        public void Set(Bitword WordToAssign) => Value = WordToAssign.Value;
        public void Set(int ValueToAssign) => Value = ValueToAssign;
        public int Get() => value;
        internal void Clear() => value = 0;

        public static Bitword ResolveConflict(Bitword original, Bitword intruder)
        {
            return new Bitword(original.length, original.value & intruder.value); //TODO: make sure it works with different lengths
        }

        public static Bitword operator++(Bitword toIncrement)
        {
            toIncrement.Value += 1;
            return toIncrement;
        }
        public static Bitword operator--(Bitword toDecrement)
        {
            toDecrement.Value -= 1;
            return toDecrement;
        }

        public static Bitword operator+(Bitword first, Bitword second)
        {
            first.Value += second.value;
            return first;
        }
        public static Bitword operator-(Bitword first, Bitword second)
        {
            first.Value -= second.value;
            return first;
        }
    }
}
