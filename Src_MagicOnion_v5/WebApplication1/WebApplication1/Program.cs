using ClassLibrary1.Interface;
using MagicOnion;
using MagicOnion.Server;
using MessagePack.Resolvers;
using MessagePack;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.AspNetCore.Hosting;

var Resolver = CompositeResolver.Create(
    NativeDateTimeResolver.Instance,
    NativeDecimalResolver.Instance,
    DynamicGenericResolver.Instance,
    ColorResolver.Instance,
    ContractlessStandardResolver.Instance
);
var options = ContractlessStandardResolver.Options.WithResolver(Resolver)
    .WithCompression(MessagePackCompression.Lz4Block);
MessagePackSerializer.DefaultOptions = options;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel(options =>
{
    options.ConfigureEndpointDefaults(endpointOptions =>
    {
        endpointOptions.Protocols = HttpProtocols.Http2;
        endpointOptions.KestrelServerOptions.Limits.MaxRequestBodySize = int.MaxValue;
    });
}).UseIIS();

builder.Services.Configure<IISServerOptions>(options =>
{
    options.MaxRequestBodySize = int.MaxValue;
});

builder.Services.AddGrpc();
builder.Services.AddMagicOnion();

var app = builder.Build();

app.MapMagicOnionService();

app.MapGet("/", () => "Hello World!");

app.Run();
