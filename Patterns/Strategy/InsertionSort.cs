using System.Text;

namespace Patterns.Strategy
{
    internal class InsertionSort : ISorting
    {
        public string Sort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1] > key))
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }

                array[j] = key;
            }
            StringBuilder builder = new StringBuilder();

            foreach (var item in array)
            {
                builder.Append(item.ToString());
            }

            return builder.ToString();
        }

        private void Swap(ref int e1, ref int e2)
        {
            var temp = e1;

            e1 = e2;

            e2 = temp;
        }
    }
}
