using System;
using System.Collections.Generic;
using Lixeon.Classes.Core.Domain.Events;

namespace Lixeon.Classes.Core.Domain.Interfaces
{
    public interface IHandler<T> : IDisposable where T : IDomainEvent
    {
        void Handle(T args);
        IEnumerable<T> Notify();
        bool HasNotifications();
        List<T> GetValues();
    }
}