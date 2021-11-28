using System;

namespace TaskPlanner.Application.Common.Exceptions
{
    class BoardNotFoundException : ApplicationException
    {
        public BoardNotFoundException(string name, object key)
            : base($"entity {name} was not found by the following key: {key}") { }
        
    }
}
