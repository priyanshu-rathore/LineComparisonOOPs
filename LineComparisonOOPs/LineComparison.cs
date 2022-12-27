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

        public int length()
        {

            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int x1 = Arr[0], y1 = Arr[1], x2 = Arr[2], y2 = Arr[3];

            double length = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));

            return (int)length;
        }


    }
}