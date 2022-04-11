namespace Patterns.Iterator
{
    internal interface IAggregate
    {
        IIterator GetIterator();
    }
}
