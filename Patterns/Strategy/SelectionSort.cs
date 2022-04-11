using System.Text;

namespace Patterns.Strategy
{
    internal class SelectionSort : ISorting
    {
        public string Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int index = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[index])
                        index = j;
                }
                int smallerNumber = array[index];
                array[index] = array[i];
                array[i] = smallerNumber;
            }
            StringBuilder builder = new StringBuilder();

            foreach (var item in array)
            {
                builder.Append(item.ToString());
            }

            return builder.ToString();
        }
    }
}
