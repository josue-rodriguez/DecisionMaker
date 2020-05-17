#pragma checksum "C:\Users\josue\GitHub\DecisionMaker\Pages\Movies.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ad68ca2dc79aed83801ac9caa774bc2fad9125d"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies")]
    public partial class Movies : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\josue\GitHub\DecisionMaker\Pages\Movies.razor"
       
    public Activity2 movies = new Activity2 { };
    private string NewChoice;
    const string Key = "MovieList";

    // Add Choice to movies
    // Reload items on return
    protected override async Task OnInitializedAsync()
    {
        movies = await LocalStore.GetItemAsync<Activity2>(Key);

        if (movies == null || movies.Items.Count == 0)
        {
            movies = new Activity2 { };
        }

    }

    public async void UpdateLocalStorage()
    {
        await LocalStore.SetItemAsync(Key, movies);
    }

    public async void ClearLocalStorage()
    {
        movies.Items.Clear();
        await LocalStore.ClearAsync();
    }

    public void AddChoiceToChoices()

    {
        bool isNotEmpty = !string.IsNullOrWhiteSpace(NewChoice);
        bool isNewChoice = !movies.Items.Any(choice => choice.Name == NewChoice);

        if (isNotEmpty && isNewChoice)
        {
            var item = new Choice2 { Name = NewChoice };


            movies.Items.Add(item);

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
        var ItemToRemove = movies.Items.Single(choice => choice.Name == ChoiceToRemove);
        movies.Items.Remove(ItemToRemove);
        UpdateLocalStorage();
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService LocalStore { get; set; }
    }
}
#pragma warning restore 1591
