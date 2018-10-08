using System;
using Lixeon.Classes.Core.Domain.Interfaces;

namespace Lixeon.Classes.Core.Domain.ValueObjects
{
    public class Aggregate : IAggregate
    {
        public Aggregate()
        {
            this.Id = Guid.NewGuid();
        }

        public Aggregate(Guid id)
        {
            this.Id = id;
        }

        public Guid Id { get; protected set; }
    }
}