// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Lab_ConditionalAndListRendering
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Projects\Blazor_git\ConditionalAndListRendering\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Projects\Blazor_git\ConditionalAndListRendering\_Imports.razor"
using Lab_ConditionalAndListRendering;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "c:\Projects\Blazor_git\ConditionalAndListRendering\App.razor"
       
  private class Word {
    public string EN { get; set; }
    public string NL { get; set; }
  }

  private string fromLanguage = "English";
  private string toLanguage = "Nederlands";
  private Word[] words = { 
    new Word { EN = "one", NL = "een" },
    new Word { EN = "two", NL = "twee" },
    new Word { EN = "three", NL = "drie" }
  };
  private int progress = 0;

  // Step 5: Use switch
  private string firstLanguage = "EN";

  private int year = DateTime.Now.Year;

  private void ProgressPlusTen() {
    this.progress += 10;
  }

  private void SwitchLanguage() {
    firstLanguage = firstLanguage == "EN" ? "NL" : "EN";
  }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
