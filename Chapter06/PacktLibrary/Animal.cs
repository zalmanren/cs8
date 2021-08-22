using System;
using static System.Console;
namespace Packt.Shared;

public class Animal:IDisposable
{
    public Animal()
    {

    }
    ~Animal()
    {
        if(disposed) return;
        Dispose(false); // 这里是在GC调用后再次调用的，不需要释放托管资源
    }
    bool disposed = false;
    public void Dispose()
    {
        Dispose(true); // 手动调用的时候，需要手动处理托管的数据
        GC.SuppressFinalize(this);
    }
    protected void Dispose(bool disposing)
    {
        if(disposed) return;
        // deallocate the *unmanaged* resource
        // ...
        if(disposing)
        {
            // deallocate any other *managed* resource
            // ...
        }
        disposed = true;
    }
}