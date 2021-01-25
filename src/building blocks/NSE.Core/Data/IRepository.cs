using System;

namespace NSE.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        
    }

    public interface IAggregateRoot { }
}
