using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;

Console.WriteLine("Hello, Console!");

return 0;

public partial class MyClass
{
    [JSExport]
    internal static string Greeting()
    {
        int r = PrintLine(42);
        var text = $"Hello, World! Greetings from node version: {GetNodeVersion()}, result: {r}";
        
        return text;
    }

    [JSImport("node.process.version", "main.mjs")]
    internal static partial string GetNodeVersion();

    [DllImport("native-lib", EntryPoint="print_line")]
    static extern int PrintLine(int x);
}
