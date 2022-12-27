using System;

namespace LineComparisonOOPs
{
    class LineComparisonOOPs
    {
        private int[] arr = new int[4];

        public int[] Arr
        {
            get
            {
                return arr;
            }
            set
            {
                arr = value;
            }
        }

        public double length()
        {
            System.Console.WriteLine("Enter x1 y1 and x2 y2 respectively");
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            System.Console.WriteLine("Coordinates are : ");

            for (int i = 0; i < Arr.Length; i++)
            {
                System.Console.WriteLine(Arr[i] + " ");
            }

            int x1 = Arr[0], y1 = Arr[1], x2 = Arr[2], y2 = Arr[3];

            double length = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            return length;
        }

        public void EqualityOfTwoLines()
        {
            double lineOne = length();
            double lineTwo = length();

            bool checkEqual = lineOne.Equals(lineTwo);

            if (checkEqual == true)
            {
                System.Console.WriteLine("Lines are equal");
            }
            else
            {
                System.Console.WriteLine("Lines are not equal");
            }
        }


    }
}