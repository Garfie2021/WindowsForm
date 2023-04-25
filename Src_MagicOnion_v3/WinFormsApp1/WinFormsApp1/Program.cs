using ClassLibrary1.Interface;
using MessagePack.Resolvers;
using MessagePack;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var Resolver = MessagePack.Resolvers.CompositeResolver.Create(
            NativeDateTimeResolver.Instance,
            NativeDecimalResolver.Instance,
            DynamicGenericResolver.Instance,
            ColorResolver.Instance,
            ContractlessStandardResolver.Instance
            );
            var options = ContractlessStandardResolver.Options.WithResolver(Resolver);
            MessagePackSerializer.DefaultOptions = options;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}