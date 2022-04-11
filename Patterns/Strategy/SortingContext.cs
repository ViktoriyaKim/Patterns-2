namespace Patterns.Strategy
{
    internal class SortingContext
    {
        private ISorting _sorting;

        public SortingContext(ISorting strategy)
        {
            _sorting = strategy;
        }

        public string SortArray(int[] array)
        {
            return _sorting.Sort(array);
        }
    }
}
