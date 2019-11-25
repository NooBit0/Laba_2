using System;

namespace InputPropertyCircle
{
    public static class Input
    {
        public static int InputProperty(int limitation)
        {
            int property;

            while (!int.TryParse(Console.ReadLine(), out property) || property < limitation)
            {
            }

            return property;
        }

        public static int InputProperty()
        {
            int property;

            while (!int.TryParse(Console.ReadLine(), out property))
            {
            }

            return property;
        }
    }
}
