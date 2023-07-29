using MagicOnion;
using ClassLibrary1.Model;

namespace ClassLibrary1.Interface
{
    // Defines .NET interface as a Server/Client IDL.
    // The interface is shared between server and client.
    public interface IMyFirstService : IService<IMyFirstService>
    {
        // The return type must be `UnaryResult<T>` or `UnaryResult`.
        UnaryResult<int> SumAsync(int x, int y);

        UnaryResult<ModelClassA> Sum2Async(ModelClassA modelClassA1, ModelClassA modelClassA2);
        
    }
}
