using MaszynaW.Components;
using MaszynaW.Bitwords;

namespace MaszynaW.MaszynaW.Components.Devices
{
    abstract class Device : Component
    {
        public Device(int wordLength) : base(wordLength)
        {
            content = new Bitword(WordLength);
        }
        protected Bitword content;
        public Bitword Content
        {
            get => content;
            set
            {
                content.Set(value);
            }
        }
    }
}
