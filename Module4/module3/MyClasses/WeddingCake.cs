using System;
namespace module3.MyClasses
{
    public class WeddingCake <T>
    {
        public WeddingCake()
        {

        }

        public T Flavor { get; set; }

        public T getMyFlavor()
        {
            return Flavor;
        }

    }

}
