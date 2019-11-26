namespace MaszynaW.Components
{
    public abstract class Component
    {
        protected readonly int WordLength; //every component is exactly specified in matter of the length of words its using

        public Component(int wordLength)
        {
            WordLength = wordLength;
        }

        //DEBUG
        //public abstract void Info();

        //public abstract void ClockTick(); //every component need to do an action after the clock ticks, f.e. a bus will reset its state
    }
}
