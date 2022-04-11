using System;

namespace Patterns.Iterator
{
    internal interface IIterator
    {
        bool HasNext();
        Object Next();

        Object Previous();
    }
}
