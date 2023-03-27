namespace WorkWithGeneric
{
    public class FlashMemory : IVolumable
    {
        string producer;
        int capacity;
        public FlashMemory(string prod = "Kingston", int cap = 16)
        {
            producer = prod; capacity = cap;
        }
        public string Producer
        {
            get => producer;
        }
        public int Capacity
        {
            get => capacity;
        }
        public override string ToString()
        {
            return $"Flas({producer},{capacity}Gb)";
        }
        public double Volume()
        {
            return this.Capacity;
        }
    }
    public class HardDrive : IVolumable
    {
        public enum ConsumerSegment { Desktop, Mobile, External };

        private int capacity;
        private bool formatted;
        private ConsumerSegment segment;
        private double performance;

        public HardDrive(ConsumerSegment s, int cap, double per)
        {
            capacity = cap; formatted = false; segment = s; performance = per;
        }
        public override string ToString()
        {
            return $"HDD>>>{segment},{capacity}Gb,{performance}Kbpms";
        }
        public bool Formatted
        {
            get => formatted;
        }
        public void format() => formatted = true;
        public double Volume() => formatted ? capacity : 0.0;
        public double Performance => performance;
    }
}
