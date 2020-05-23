#pragma checksum "C:\Users\josue\GitHub\DecisionMaker\Pages\Television.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "197d3e672881d1f2466bc39c96ce0bab1a727f2a"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/television")]
    public partial class Television : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\josue\GitHub\DecisionMaker\Pages\Television.razor"
       
    //public Activity TV = new Activity { };
    private string NewChoice;
    const string Key = "TVList";

    // Add Choice to TV
    // Reload items on return
    protected override async Task OnInitializedAsync()
    {
        TV = await LocalStore.GetItemAsync<Activity>(Key);

        if (TV == null || TV.Items.Count == 0)
        {
            TV = new Activity { };
        }

    }

    public async void UpdateLocalStorage()
    {
        await LocalStore.SetItemAsync(Key, TV);
    }

    public async void ClearLocalStorage()
    {
        TV.Items.Clear();
        await LocalStore.ClearAsync();
    }

    public void AddChoiceToChoices()

    {
        bool isNotEmpty = !string.IsNullOrWhiteSpace(NewChoice);
        bool isNewChoice = !TV.Items.Any(choice => choice.Name == NewChoice);

        if (isNotEmpty && isNewChoice)
        {
            var item = new Choice { Name = NewChoice };


            TV.Items.Add(item);

            NewChoice = string.Empty;

            UpdateLocalStorage();
        }

    }

    // Method for adding choices on "Enter"
    public void AddChoiceOnEnter(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            AddChoiceToChoices();
        }
    }


    // Method for removing a choice
    public void RemoveChoice(string ChoiceToRemove)
    {
        var ItemToRemove = TV.Items.Single(choice => choice.Name == ChoiceToRemove);
        TV.Items.Remove(ItemToRemove);
        UpdateLocalStorage();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Activity TV { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService LocalStore { get; set; }
    }
}
#pragma warning restore 1591
