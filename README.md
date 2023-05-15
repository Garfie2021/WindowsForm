## WindowsForm/Src_FileToHexadecimal/

I created a tool that reads a file and displays the contents in hexadecimal.

[YouTube](https://youtu.be/eHT8rxkJ1G8)
[Source code explanation page](https://blog.unikktle.com/%e3%83%95%e3%82%a1%e3%82%a4%e3%83%ab%e3%81%ae%e5%86%85%e5%ae%b9%e3%82%9216%e9%80%b2%e6%95%b0%e3%81%a7%e8%a1%a8%e7%a4%ba%e3%81%99%e3%82%8b%e3%83%84%e3%83%bc%e3%83%ab/)

---

## WindowsForm/Src_MagicOnion/

gRPC communication realized with .NET 6.0 and MagicOnion (Windows Forms).

I created a sample that performs gRPC communication processing from a .NET 6.0 Windows Forms application using the MagicOnion NuGet package.

When migrating a client-server system implemented with .Net Framework to .NET 6.0, you can easily migrate to a client-server system using gRPC communication by using the MagicOnion Nuget package.

It is recommended to migrate a client-server system implemented with .Net Framework + WCF to HTTP/2 gRPC communication rather than migrate to .NET 6.0 + WCF Core and continue communicating with the old HTTP protocol.

With MagicOnion, you can easily implement gRPC communication in a client/server system.
When developing a client-server system with .NET, it seems that implementing gRPC communication with MagicOnion will become the mainstream for communication processing.

The MagicOnion project site on GitHub has a MagicOnion development repository, installation instructions, etc., and is easy to understand.

[YouTube](https://youtu.be/lA2U4IHPYdE)
[Source code explanation page](https://blog.unikktle.com/net-6-0%e3%81%a8magiconion%e3%81%a7%e5%ae%9f%e7%8f%be%e3%81%99%e3%82%8bgrpc%e9%80%9a%e4%bf%a1%ef%bc%88windows%e3%83%95%e3%82%a9%e3%83%bc%e3%83%a0%ef%bc%89/)

---

## WindowsForm/Src_MagicOnion_v2/

gRPC communication (Windows Forms) v2 realized with .NET 6.0 and MagicOnion.

I created a sample that performs gRPC communication processing from a .NET 6.0 Windows Forms application using the MagicOnion NuGet package.
I added a pattern that uses a data class to the sample created last time.
When communicating data classes with MagicOnion, serialization/deserialization using MessagePack is essential.

When migrating a client-server system implemented with .Net Framework to .NET 6.0, you can easily migrate to a client-server system using gRPC communication by using the MagicOnion Nuget package.

It is recommended to migrate a client-server system implemented with .Net Framework + WCF to HTTP/2 gRPC communication rather than migrate to .NET 6.0 + WCF Core and continue communicating with the old HTTP protocol.

With MagicOnion, you can easily implement gRPC communication in a client/server system.
When developing a client-server system with .NET, it seems that implementing gRPC communication with MagicOnion will become the mainstream for communication processing.

The MagicOnion project site on GitHub has a MagicOnion development repository, installation instructions, etc., and is easy to understand.

[YouTube](https://youtu.be/iqGtoW0jokY)
[Source code explanation page](https://blog.unikktle.com/net-6-0%e3%81%a8magiconion%e3%81%a7%e5%ae%9f%e7%8f%be%e3%81%99%e3%82%8bgrpc%e9%80%9a%e4%bf%a1%ef%bc%88windows%e3%83%95%e3%82%a9%e3%83%bc%e3%83%a0%ef%bc%89v2/)

---

## WindowsForm/Src_MagicOnion_v3/

gRPC communication (Windows Forms) v3 realized with .NET 6.0 and MagicOnion.

Using the MagicOnion NuGet package to perform gRPC communication processing from a .NET 6.0 Windows Forms application. There was a problem that it did not pass to the server side.
The sample created this time solves those problems by setting the Resolver when starting the client-side and server-side apps.

When using the ColorFormatter/ColorResolver inside MessagePack, even if the value is passed from the server to the client, the value is not passed from the client to the server.

The process to set Resolver should be added on both server side and client side.

[YouTube](https://youtu.be/aIHyY4QlOHU)
[Source code explanation page](https://blog.unikktle.com/net-6-0%e3%81%a8magiconion%e3%81%a7%e5%ae%9f%e7%8f%be%e3%81%99%e3%82%8bgrpc%e9%80%9a%e4%bf%a1%ef%bc%88windows%e3%83%95%e3%82%a9%e3%83%bc%e3%83%a0%ef%bc%89v3/)

---

## WindowsForm/Src_MagicOnion_v4/

gRPC communication realized with .NET 6.0 and MagicOnion (Windows Forms) v4.

From a .NET 6.0 Windows Forms application, using the MagicOnion NuGet package, gRPC communication processing Added processing to Lz4 compression of serialized MessagePack communication data to the sample created last time.

Just add WithCompression(MessagePackCompression.Lz4Block) to ContractlessStandardResolver.Options on both client and server.

[Source code explanation page](https://blog.unikktle.com/net-6-0%e3%81%a8magiconion%e3%81%a7%e5%ae%9f%e7%8f%be%e3%81%99%e3%82%8bgrpc%e9%80%9a%e4%bf%a1%ef%bc%88windows%e3%83%95%e3%82%a9%e3%83%bc%e3%83%a0%ef%bc%89v4/)

---

## WindowsForm/Src_Static/
Even if a method is declared static, variables declared within the method are not shared among multiple threads, and static member variables of the class are shared.

Variables declared inside a static method are not shared between multiple threads, just like variables declared inside a while loop cannot be used outside of the variable scope specification.

From this, we can see that it is safe to use static methods that are executed in stack memory in multithreaded applications.

[YouTube]()
[Source code explanation page](https://blog.unikktle.com/c%e3%83%9e%e3%83%ab%e3%83%81%e3%82%b9%e3%83%ac%e3%83%83%e3%83%89%e3%81%ab%e3%81%8a%e3%81%91%e3%82%8bstatic%e5%a4%89%e6%95%b0%e3%81%ae%e3%82%b9%e3%82%b3%e3%83%bc%e3%83%97/)

---

## WindowsForm/Src_Stub/
How to make a stub.
When developing an application that operates a third-party product that costs tens of millions of yen or more, the work environment is limited, such as being able to connect to the third-party product only locally, and not being able to connect to the third-party product from the local PC where the development work is performed. , it often happens that the debugging process does not proceed as expected.
In that case, by creating a Stub that matches the I/F specifications of the other company's product and using the Stub to proceed with debugging and testing on the local PC where the development work is performed, the speed and accuracy of the development work can be increased and The problem can only be a defect on the side of the other company's product.

If you pick up only the public methods from the I/F library (DLL) for operating the other company's product, which is provided as a set with the other company's product, and create a Stub that implements only the I/F side. , you can proceed with debugging and testing even locally where you cannot connect to other companies' products.

I/F libraries for connecting to other companies' products costing tens of millions of yen or more are often provided as DLLs.

It's not a mock (Moq), it's a stub.
There are too many people who can't tell the difference between a mock and a stub, and say, "That's a mock, right?" when talking about creating a stub.

I made it based on .Net Core, but it will be the same implementation in .Net Framework.

[YouTube](https://youtu.be/NLudWJL09aI)
[YouTube](https://youtu.be/DOx0tYWG63M)
[Source code explanation page](https://blog.unikktle.com/%e3%82%b9%e3%82%bf%e3%83%96%ef%bc%88stub%ef%bc%89%e3%81%ae%e4%bd%9c%e3%82%8a%e6%96%b9/)

---

## WindowsForm/Src_Stub_v2/
The application implemented in [How to create a stub](https://blog.unikktle.com/%e3%82%b9%e3%82%bf%e3%83%96%ef%bc%88stub%ef%bc%89%e3%81%ae%e4%bd%9c%e3%82%8a%e6%96%b9/) has a fixed return value of the stub, and every time I changed the return value and tested it, I had to modify the source code and build again.
This time, we have added a separate application (stub controller) that can dynamically change the return value of the stub even while the main application is running, allowing for more flexible testing.

From Visual Studio 2022 + .NET 6.0, it is now possible to develop Windows Forms applications like .Net Framework.
Visual Studio 2022 is not quite stable, and recently, I have finally implemented a Windows Forms app with Visual Studio 2022 + .NET 6.0, and am no longer annoyed by strange movements.
In the development of Windows Forms apps in Visual Studio 2019 + .NET 5.0, the Binding of DataGridView was incomplete and unusable, but in Visual sStudio 2022 + .NET 6.0, Visual Studio 2019 + .Net Framwork 4.8. About 1 environment, you can implement a Windows Forms application crisply.

[YouTube](https://youtu.be/xtd0bcDob_E)
[Source code explanation page](https://blog.unikktle.com/%e3%82%b9%e3%82%bf%e3%83%96%ef%bc%88stub%ef%bc%89%e3%81%ae%e4%bd%9c%e3%82%8a%e6%96%b9-v2/)

---

## WindowsForm/Src_TaskRun_Invoke/

Dealing with "Invalid cross-thread operation: The control was accessed from a thread other than the thread in which the control was created." Exception (Windows Forms)

In a Windows Forms app, if you operate a form control on the main thread from another thread, such as Task.Run(), an error message "System.InvalidOperationException: 'Invalid cross-thread operation: The control was created from a thread other than the thread in which the control was created Accessed.'” Exception occurs, but it is resolved by passing Invoke().

[YouTube](https://youtu.be/o6C6V8yALFc)
[Source code explanation page](https://blog.unikktle.com/%e3%80%8c%e6%9c%89%e5%8a%b9%e3%81%a7%e3%81%af%e3%81%aa%e3%81%84%e3%82%b9%e3%83%ac%e3%83%83%e3%83%89%e9%96%93%e3%81%ae%e6%93%8d%e4%bd%9c-%e3%82%b3%e3%83%b3%e3%83%88%e3%83%ad%e3%83%bc%e3%83%ab%e3%81%8c/)

---

## WindowsForm/Src_WindowsEventLogIssue/

I wrote a tool that publishes Windows event logs.

[YouTube](https://youtu.be/jSWIYQwwtfY)
[Source code explanation page](https://blog.unikktle.com/windows%e3%82%a4%e3%83%99%e3%83%b3%e3%83%88%e3%83%ad%e3%82%b0%e3%82%92%e7%99%ba%e8%a1%8c%e3%81%99%e3%82%8b%e3%83%84%e3%83%bc%e3%83%ab/)

---

