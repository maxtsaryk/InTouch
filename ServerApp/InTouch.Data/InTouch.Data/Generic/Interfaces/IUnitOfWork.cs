using System;
using System.Threading.Tasks;

namespace InTouch.Data.Generic.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task SaveChanges();
    }
}
