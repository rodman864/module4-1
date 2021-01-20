using System;
namespace module3.Module
{
    public class BirthdayCake<T>
    {
        public BirthdayCake()
        {
        }
        public T Flavor { get; set; }

        public T getMyFlavor()
        {
            return Flavor;
        }

    }
}
