using ClassLibrary1.Interface;
using MagicOnion;
using MagicOnion.Server;
using MessagePack.Resolvers;
using MessagePack;

var Resolver = MessagePack.Resolvers.CompositeResolver.Create(
NativeDateTimeResolver.Instance,
NativeDecimalResolver.Instance,
DynamicGenericResolver.Instance,
ColorResolver.Instance,
ContractlessStandardResolver.Instance
);
var options = ContractlessStandardResolver.Options.WithResolver(Resolver);
MessagePackSerializer.DefaultOptions = options;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpc();
builder.Services.AddMagicOnion();

var app = builder.Build();

app.MapMagicOnionService();

app.MapGet("/", () => "Hello World!");

app.Run();
