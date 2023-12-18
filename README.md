## WindowsForm/Src_ActiveDirectory/WinFormsApp1/

A tool that connects to ActiveDirectory and lists ActiveDirectory properties.

I previously created a tool that connects to ActiveDirectory in a Windows Forms app and lists ActiveDirectory properties.

When you change the connection destination and click the "Search" button, ActiveDirectory property names and values will be listed in the "Results" column.
- Change (domain) to the domain you belong to, such as ○○.co.jp.
- Change (user account name) and (user account password) to the account used when logging into the Windows OS.

[Source code explanation page](https://blog.unikktle.com/activedirectory%e3%81%b8%e6%8e%a5%e7%b6%9a%e3%81%97-activedirectory%e3%81%ae%e3%83%97%e3%83%ad%e3%83%91%e3%83%86%e3%82%a3%e3%82%92%e3%83%aa%e3%82%b9%e3%83%88%e3%82%a2%e3%83%83%e3%83%97%e3%81%99/)

---

## WindowsForm/Src_ActiveReports/SectionReportApplication1/

GrapeCity ActiveReports for .NET 16.0J Section Report (SectionReport) development steps

When developing an app to run on Windows, you currently use Visual Studio 2022 to implement it in a .Net Core project (.NET 7.0), but in a .Net Core project, the ActiveReports report designer is Since it cannot be used, it is necessary to create a separate .Net Framework project for the report designer. I have summarized the steps involved.

Visual Studio project creation
Create a .Net Framework project for editing report designer
A project where only the design of the section report is changed.
This project is not eligible for release as a .Net Core app.

Select “ActiveReports 16.0J Section Report Application”.

Create a .Net Core project for release
Project for release of section report application.
This time, select "Windows Forms App" from the .Net Core family.

Install ActiveReports Nuget package
Add the section report to your .Net Core project and install the Nuget packages related to ActiveReports.

caveat
ActiveReports is not fully compatible with .Net Core projects, so the NU1701 warning will be output, but you can ignore it as it can be executed without any problems.

Section report creation
Edit section report
"ActiveReports 16.0J Section Report Application" has one section report file (SectionReport1.cs) created by default, so we will use it this time.

When debugging a report designer editing project
By debugging the report designer editing project, you can confirm that any value is displayed in the TextBox field.

Add section report to .Net Core projects
Add the section report created on the report designer editing project side to the .Net Core project side as a link.
By adding it as a link, the entity of the section report will not be divided into multiple projects, and the contents edited in the report designer editing project can be immediately reflected in the .Net Core project.

When opening a section report on the .Net Core project side
When you open a section report on the .Net Core project side, the report designer is not displayed, but the code-behind source code is displayed.

Create a report viewer for a .Net Core project
Open a Windows form on the .Net Core project side and drag and paste "ActiveReports 16 > GrapeCity.ActiveReports.Viewer.Win.Viewer" from the toolbar to the Windows form.

When debugging a .Net Core project
Similar to the report designer editing project, you can also debug section reports in .Net Core projects.
This will be used as a release project.

[YouTube](https://youtu.be/-7_c86laC64)
[Source code explanation page](https://blog.unikktle.com/grapecity-activereports-for-net-16-0j-%e3%81%ae%e3%82%bb%e3%82%af%e3%82%b7%e3%83%a7%e3%83%b3%e3%83%ac%e3%83%9d%e3%83%bc%e3%83%88sectionreport-%e9%96%8b%e7%99%ba%e6%89%8b%e9%a0%86/)

---

## WindowsForm/Src_ActiveReports/SectionReportApplication2/

Use the ActiveReports section report created in a .Net Framework project in a .Net Core project.In the sample created last time, the values entered from the Windows Form screen on the .Net Core side will be displayed in the section report. It has been improved.

.Net Framework project for editing report designer
Explanation of source code changes.

SectionReportApplication1/DataModel1.cs
- Added DataModel1 data class to simplify processing when displaying dynamic values in the textbox of section reports.

SectionReportApplication1/Form1.cs
・Delete unnecessary using.
- Since a dynamic value is now displayed in the Textbox of the section report, change the DataModel1 data class to be passed to the section report from the Windows form.

SectionReportApplication1/SectionReport1.cs
Change the value displayed in the TextBox of the section report from a fixed string to the Text1 member variable of the DataModel1 data class received from the constructor parameter.

SectionReportApplication1/SectionReportApplication1.csproj
-Upgraded the .Net Framework version from v4.7.2 to the latest v4.8.
- Create a new source file for the DataModel1 data class on the ".Net Framework project for report designer editing" side.
*For the DataModel1 data class, the same source file is used in the ".Net Framework project for report designer editing" and the ".Net Core project for release."

.Net Core project for release
Explanation of source code changes.

/WinFormsApp1/Form2.cs　Form2.Designer.cs　Form2.resx
-Create a new input screen.
-Clicking the "button1" button launches the report viewer screen where the entered values are displayed.
-The input value is retained in the DataModel1 data class and the DataModel1 data class is passed to the report viewer screen.

/WinFormsApp1/Form1.cs
- On the report viewer screen, change the DataModel1 data class received from the constructor parameter to be passed to the section report.

/WinFormsApp1/Program.cs
- The flow of calling the report viewer screen from the input screen has been changed, so the screen displayed when the application starts is changed from the report viewer screen to the input screen.

/WinFormsApp1/WinFormsApp1.csproj
- The DataModel1 data class created on the ".Net Framework project for report designer editing" side is added as a link and incorporated as a reference on the ".Net Core project for release" side.

[YouTube](https://youtu.be/zlHOK1KWLRg)
[Source code explanation page](https://blog.unikktle.com/grapecity-activereports-for-net-16-0j-%e3%81%ae%e3%82%bb%e3%82%af%e3%82%b7%e3%83%a7%e3%83%b3%e3%83%ac%e3%83%9d%e3%83%bc%e3%83%88sectionreport-%e9%96%8b%e7%99%ba%e6%89%8b%e9%a0%86-v2/)

---

## WindowsForm/Src_ActiveReports/SectionReportApplication3/

The sample I created last time was improved so that the values entered from the Windows form screen on the .Net Core side are displayed in the section report, and I changed it to a general form that prints on A4 paper.

### .Net Framework project for editing report designer
Explanation of source code changes

/SectionReportApplication1/SectionReportApplication1.csproj
Change DataModel1 data class to ReportDataModel data class.

/SectionReportApplication1/DataModel1.cs /SectionReportApplication1/ReportDataModel.cs
Change DataModel1 data class to ReportDataModel data class.
Adding data items corresponding to the items added to the section report.

/SectionReportApplication1/Form1.cs
Change DataModel1 data class to ReportDataModel data class.

/SectionReportApplication1/SectionReport1.Designer.cs /SectionReportApplication1/SectionReport1.resx
The report layout has been changed to a general form consisting of a header and details.

pageHeder is an area that is output on all pages.
This time, we have provided "Report No" and "Date" columns.

groupHeader1 is an area that is output only on the first page by setting "RepeatStyle=None" in the property.
This time, we have provided "Title" and "Description" columns.

groupHeader2 is an area that is output on all pages by setting "RepeatStyle=All" in the property.
This time, the column title of the detailed data output to the detail area is set as a fixed character string.

detail is a table area that is output on all pages.
This time, the detailed data is divided into three columns.

pageFooter is an area that is output on all pages.
This time, the current page number and total page number are displayed.

/SectionReportApplication1/SectionReport1.cs
Associate the items added to the section report with the ReportDataModel data class.


### .Net Core project for release
Explanation of source code changes.

/WinFormsApp1/WinFormsApp1.csproj
Change the DataModel1 data class added as a link to the ReportDataModel data class.

/WinFormsApp1/Form1.Designer.cs
The size of the report viewer screen has been expanded to make it easier to view A4 reports.

/WinFormsApp1/Form1.cs
Change DataModel1 data class to ReportDataModel data class.

/WinFormsApp1/Form2.Designer.cs
As the number of items in the report has increased, we have also added items to the input screen.
It is easy to understand which items on the input screen correspond to which items in the section report by watching the YouTube video.

/WinFormsApp1/Form2.cs
Associate the items added to the input screen with the ReportDataModel data class.


### supplement
Paper size settings
To set the paper size for printing a report, such as A4 or B5, select "Printer Settings" under "Report Settings" from the "Property Settings Dialog" that is displayed in the properties when you click the gray area of the report in the report designer. > Paper size”.
This time I set it to the general "A4".

Add groupHeader
A groupHeader can be added by right-clicking on the background in the report designer and selecting Insert > Group Header/Footer.


[YouTube](https://youtu.be/GpqsDrjXrkw)
[Source code explanation page](https://blog.unikktle.com/grapecity-activereports-for-net-16-0j-%e3%81%ae%e3%82%bb%e3%82%af%e3%82%b7%e3%83%a7%e3%83%b3%e3%83%ac%e3%83%9d%e3%83%bc%e3%83%88sectionreport-%e9%96%8b%e7%99%ba%e6%89%8b%e9%a0%86-v3/)

---

## WindowsForm/Src_ActiveReports/SectionReportApplication4/

The sample I created last time displayed the section report on the Viewer screen, but I created a sample that outputs a PDF file without displaying the Viewer screen.

### .Net Core project for release

Install GrapeCity.ActiveReports.Export.Pdf.ja Nuget package.
Added "PDF" button to output PDF file.

Added an event handler for the "PDF" button that outputs a PDF file.
Reference the GrapeCity.ActiveReports.Export.Pdf.ja Nuget package using GrapeCity.ActiveReports.Export.Pdf.Section; and in the button2_Click event handler, create section report data using the same process as the sample created last time, and create a new Create a section report instance with SectionReport1(reportDataModel);, build it with sectionReport1.Run();, and output the PDF file with export.Export(sectionReport1.Document, @”C:\temp\sample4.pdf”); I am.

[YouTube](https://youtu.be/Cwba68ayuo8)
[Source code explanation page](https://blog.unikktle.com/grapecity-activereports-for-net-16-0j-%e3%81%ae%e3%82%bb%e3%82%af%e3%82%b7%e3%83%a7%e3%83%b3%e3%83%ac%e3%83%9d%e3%83%bc%e3%83%88sectionreport-%e9%96%8b%e7%99%ba%e6%89%8b%e9%a0%86-v4/)

---

## WindowsForm/Src_ActiveReports/SectionReportApplication5/

GrapeCity ActiveReports for .NET 16.0J Section Report (SectionReport) Development Procedure v5

In the sample created last time, data was bound to one section report file (SectionReport1.cs), displayed on the Viewer screen, and outputted as a PDF file, but data was bound to multiple section report format files and one I have created a sample that displays as one report on the Viewer screen and outputs it as a PDF file.

Create new section report files for the cover section and summary section.
Add the section report files for the cover section and summary section newly created on the ".Net Framework project for report designer editing" side as links.
Added processing to the section report viewer to combine and display section report files for the cover section, details section, and summary section.

[YouTube](https://youtu.be/mIqr7IJmiFw)
[Source code explanation page](https://blog.unikktle.com/grapecity-activereports-for-net-16-0j-%e3%81%ae%e3%82%bb%e3%82%af%e3%82%b7%e3%83%a7%e3%83%b3%e3%83%ac%e3%83%9d%e3%83%bc%e3%83%88sectionreport-%e9%96%8b%e7%99%ba%e6%89%8b%e9%a0%86-v5/)

---

## WindowsForm/Src_AirQualityMetrics/

A simple processing dialog implemented in a Windows Forms app.

The Windows Form app implemented in Japan's District Ranking with Good Air 2023 has a simple implementation of the processing dialog, and can be used as a reference if you want to quickly implement the processing dialog.

The processing on the processing dialog side simply displays the value passed to the StatusText property in the txtStatus text box.

If you exclude detailed processing of file operations/DB operations from the click event processing of the "Import CSV file" button and only display confirmation/completion message boxes, task execution, and display/hide processing dialogs, the following will occur.
- Changed btnCsvFileImport_Click button click event handler to an asynchronous method by adding async.
- File import/DB processing is implemented in Task.Run() and executed in a separate thread.
- After starting a task in another thread, display the processing dialog using ProcessingDialog.ShowDialog(), and keep the processing dialog displayed until the await task is finished.
- Each time the number of imported files increases, the progress text is passed to the processingDialog.StatusText property through processingDialog.Invoke().
- By executing processingDialog.Close() through processingDialog.Invoke() during the final processing in Task.Run(), the ProcessingDialog processing dialog is closed when the file import/DB processing is finished.

[YouTube](https://youtu.be/gh1q7Hn2scU)
[Source code explanation page](https://blog.unikktle.com/windows%e3%83%95%e3%82%a9%e3%83%bc%e3%83%a0%e3%82%a2%e3%83%97%e3%83%aa%e3%81%a7%e5%ae%9f%e8%a3%85%e3%81%99%e3%82%8b%e3%82%b7%e3%83%b3%e3%83%97%e3%83%ab%e3%81%aa%e5%87%a6%e7%90%86%e4%b8%ad%e3%83%80/)

---

## WindowsForm/Src_FileToHexadecimal/

I created a tool that reads a file and displays the contents in hexadecimal.

[YouTube](https://youtu.be/eHT8rxkJ1G8)
[Source code explanation page](https://blog.unikktle.com/%e3%83%95%e3%82%a1%e3%82%a4%e3%83%ab%e3%81%ae%e5%86%85%e5%ae%b9%e3%82%9216%e9%80%b2%e6%95%b0%e3%81%a7%e8%a1%a8%e7%a4%ba%e3%81%99%e3%82%8b%e3%83%84%e3%83%bc%e3%83%ab/)

---

## WindowsForm/Src_GcMultiRow/WinFormsApp1

Grid development procedure for single row multi-column layout using GcMultiRow(GrapeCity.Win.MultiRow) for Windows Forms 11.2

GcMultiRow created a grid screen sample with a single row and multiple rows layout that cannot be realized with the standard DataGridView of the Visual Studio Windows Forms application.
The checkbox column has one row and two columns, and the text box column and button column have one row and one column, arranged vertically.
Create a .NET 7.0 "Windows Forms App" project in Visual Studio 2022.
Install GrapeCity.Win.MultiRow Nuget package.
Click "GcMultiRow" in the toolbox and add his GcMultiRow to the form.
A grid with a one-row, two-column layout is implemented when displayed on the screen.
In the click event of GcMultiRow, when a button on GcMultiRow is clicked, the matrix position index value of the button and the value entered in the text box on the same line are displayed in a message box.

[YouTube](https://youtu.be/3SO0wy_tBOs)
[Source code explanation page](https://blog.unikktle.com/gcmultirowgrapecity-win-multirow-for-windows-forms-11-2-%e3%82%92%e4%bd%bf%e3%81%a3%e3%81%9f1%e8%a1%8c%e8%a4%87%e6%95%b0%e6%ae%b5%e3%83%ac%e3%82%a4%e3%82%a2%e3%82%a6%e3%83%88%e3%81%ae%e3%82%b0/)

---

## WindowsForm/Src_GcMultiRow/WinFormsApp2

I added the ability to filter by header row to the sample I created last time.

The behavior when selecting "Sort in ascending order, Sort in descending order, Select all, Blank cells, Non-blank cells" and the list of deduplicated cell values and filters listed in the filter options are as follows. It is a standard feature of GcMultiRow, so no implementation is required.

Added data class to bind with GcMultiRow control.

Set the option to display the options "Sort Ascending, Sort Descending, Select All, Blank Cells, Non-Blank Cells" and the option to automatically list the values displayed/entered in cells in the filter to true. Add a filter to the 2nd column HeaderCell (TextBox Culoumn).

Bind an instance of a data class.
GcMultiRow's filter will not work unless you bind the data class.

Use DataField to set which item in the data class is linked to which column in the GcMultiRow control.

[YouTube](https://youtu.be/Dy6bC0hHHOM)
[Source code explanation page](https://blog.unikktle.com/gcmultirowgrapecity-win-multirow-for-windows-forms-11-2-%e3%82%92%e4%bd%bf%e3%81%a3%e3%81%9f1%e8%a1%8c%e8%a4%87%e6%95%b0%e6%ae%b5%e3%83%ac%e3%82%a4%e3%82%a2%e3%82%a6%e3%83%88%e3%81%ae%e3%82%b0-2/)

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

## WindowsForm/Src_MagicOnion_v5/

gRPC Communication (Windows Forms) v5 with .NET 6.0 and MagicOnion

Added a setting to cancel the maximum 30MB communication limit of the WEB server.
The added settings remove the maximum 30MB communication limit (changed to 1024MB maximum) when VisualStudio is debug-executed, hosted on a Kestrel server, and hosted on an IIS server.

"Microsoft.AspNetCore.Server.Kestrel.Core.BadHttpRequestException: 'Request body too large. The max request body size is 30000000 bytes.'" will result in an error.

If all items are not checked in "Debug > Window > Exception Settings" in Visual Studio, "Microsoft.AspNetCore.Server.Kestrel.Core.BadHttpRequestException: 'Request body too large. The max request body size is 30000000 bytes.'" error, but "Grpc.Core.RpcException: 'Status(StatusCode=”Unknown”, Detail=”Exception was thrown by handler.”)'" error in MagicOnion communication processing I got addicted to it.

[Source code explanation page](https://blog.unikktle.com/net-6-0%e3%81%a8magiconion%e3%81%a7%e5%ae%9f%e7%8f%be%e3%81%99%e3%82%8bgrpc%e9%80%9a%e4%bf%a1%ef%bc%88windows%e3%83%95%e3%82%a9%e3%83%bc%e3%83%a0%ef%bc%89v5/)

---

## WindowsForm/Src_MagicOnion_v6/

gRPC communication (Windows Forms) v6 realized with .NET 6.0 and MagicOnion

Modified the Key of the model class that communicates with MagicOnion from a string to a numerical index. As a result, the amount of data and memory used when MagicOnion communicates can be reduced to about half.

[Source code explanation page](https://blog.unikktle.com/net-6-0%e3%81%a8magiconion%e3%81%a7%e5%ae%9f%e7%8f%be%e3%81%99%e3%82%8bgrpc%e9%80%9a%e4%bf%a1%ef%bc%88windows%e3%83%95%e3%82%a9%e3%83%bc%e3%83%a0%ef%bc%89v6/)

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

## WindowsForm/Src_VisualStudioWorkFolderDelete/

Tool to delete Visual Studio bin/obj folder all at once

If you save or back up multiple Visual Studio solution folders for a large project, the bin/obj folder will exceed 100GB and take up space on the disk, but there are too many Visual Studio solution folders. It takes a lot of time to open each Visual Studio solution in Visual Studio and clean it, or to search and delete the bin/obj folder from Windows Explorer. I created a tool to delete all obj folders at once.

[YouTube](https://youtu.be/gB1RRXQpr3I)
[Source code explanation page](https://blog.unikktle.com/visual-studio%e3%81%ae-bin-obj%e3%83%95%e3%82%a9%e3%83%ab%e3%83%80%e3%82%92%e7%ba%8f%e3%82%81%e3%81%a6%e5%89%8a%e9%99%a4%e3%81%99%e3%82%8b%e3%83%84%e3%83%bc%e3%83%ab/)

---

## WindowsForm/Src_WindowsEventLogIssue/

I wrote a tool that publishes Windows event logs.

[YouTube](https://youtu.be/jSWIYQwwtfY)
[Source code explanation page](https://blog.unikktle.com/windows%e3%82%a4%e3%83%99%e3%83%b3%e3%83%88%e3%83%ad%e3%82%b0%e3%82%92%e7%99%ba%e8%a1%8c%e3%81%99%e3%82%8b%e3%83%84%e3%83%bc%e3%83%ab/)

---

