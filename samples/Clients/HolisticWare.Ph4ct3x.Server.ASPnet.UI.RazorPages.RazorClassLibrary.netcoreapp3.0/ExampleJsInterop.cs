using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace HolisticWare.Ph4ct3x.Server.ASPnet.UI.RazorPages.RazorClassLibrary.netcoreapp3._0
{
    public class ExampleJsInterop
    {
        public static ValueTask<string> Prompt(IJSRuntime jsRuntime, string message)
        {
            // Implemented in exampleJsInterop.js
            return jsRuntime.InvokeAsync<string>(
                "exampleJsFunctions.showPrompt",
                message);
        }
    }
}
