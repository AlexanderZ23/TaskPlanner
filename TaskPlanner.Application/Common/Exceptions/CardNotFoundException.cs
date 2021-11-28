using System;

namespace TaskPlanner.Application.Common.Exceptions
{
    class CardNotFoundException : ApplicationException
    {
        public CardNotFoundException(string name, object key)
            : base($"entity {name} was not found by the following key: {key}") { }

    }
}
