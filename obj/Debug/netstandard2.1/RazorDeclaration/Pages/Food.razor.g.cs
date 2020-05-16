#pragma checksum "C:\Users\josue\GitHub\DecisionMaker\Pages\Food.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4033814055d87e78f41940c9486576a6affda490"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DecisionMaker.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\josue\GitHub\DecisionMaker\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\josue\GitHub\DecisionMaker\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\josue\GitHub\DecisionMaker\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\josue\GitHub\DecisionMaker\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\josue\GitHub\DecisionMaker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\josue\GitHub\DecisionMaker\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\josue\GitHub\DecisionMaker\_Imports.razor"
using DecisionMaker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\josue\GitHub\DecisionMaker\_Imports.razor"
using DecisionMaker.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\josue\GitHub\DecisionMaker\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/food")]
    public partial class Food : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\josue\GitHub\DecisionMaker\Pages\Food.razor"
       
    private string newFood;
    public Activity foods = new Activity { Type = "Food" };

    // Method for adding foods on click
    private void AddFood()
    {
        if (!string.IsNullOrWhiteSpace(newFood))
        {
            foods.AddChoice(newFood);
            newFood = string.Empty;
        }
    }
    // Method for adding foods on "Enter"
    private void AddFoodOnEnter(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            AddFood();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591