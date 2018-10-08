using System;

namespace Lixeon.Classes.Core.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
