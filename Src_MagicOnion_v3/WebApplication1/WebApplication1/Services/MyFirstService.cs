using MagicOnion.Server;
using MagicOnion;
using ClassLibrary1.Interface;
using ClassLibrary1.Model;
using System.Drawing;

namespace WebApplication1.Services
{
    // Implements RPC service in the server project.
    // The implementation class must inherit `ServiceBase<IMyFirstService>` and `IMyFirstService`
    public class MyFirstService : ServiceBase<IMyFirstService>, IMyFirstService
    {
        // `UnaryResult<T>` allows the method to be treated as `async` method.
        public async UnaryResult<int> SumAsync(int x, int y)
        {
            Console.WriteLine($"Received:{x}, {y}");
            return x + y;
        }

        public async UnaryResult<ModelClassA> Sum2Async(ModelClassA modelClassA1, ModelClassA modelClassA2)
        {
            var ModelClassA = new ModelClassA()
            {
                IntA = modelClassA1.IntA + modelClassA2.IntA,
                StringA = modelClassA1.StringA + modelClassA2.StringA,
                ColorA = Color.FromArgb(11, 22, 33)
            };

            return ModelClassA;
        }

    }
}
