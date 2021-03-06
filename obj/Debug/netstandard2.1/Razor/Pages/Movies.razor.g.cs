#pragma checksum "C:\Users\josue\GitHub\DecisionMaker\Pages\Movies.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fc433706733400aae3f6ccca576c727eb9070f8"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>Movies</h3>\r\n\r\n\r\n<hr>\r\n\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "class", "input-josue");
            __builder.AddAttribute(3, "placeholder", "e.g., The Room");
            __builder.AddAttribute(4, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\josue\GitHub\DecisionMaker\Pages\Movies.razor"
                                                                                                                         AddChoiceOnEnter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\josue\GitHub\DecisionMaker\Pages\Movies.razor"
                                                                     NewChoice

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewChoice = __value, NewChoice));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "class", "btn-add");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\josue\GitHub\DecisionMaker\Pages\Movies.razor"
                                  AddChoiceToChoices

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, "Add Movie");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "btn-choose");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\josue\GitHub\DecisionMaker\Pages\Movies.razor"
                                     ClearLocalStorage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Clear All");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n    ");
            __builder.OpenElement(18, "ul");
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 21 "C:\Users\josue\GitHub\DecisionMaker\Pages\Movies.razor"
         foreach (var choice in movies.Items)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "            ");
            __builder.OpenElement(21, "li");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "span");
            __builder.AddContent(24, 
#nullable restore
#line 24 "C:\Users\josue\GitHub\DecisionMaker\Pages\Movies.razor"
                       choice.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "class", "btn-remove");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\josue\GitHub\DecisionMaker\Pages\Movies.razor"
                                                     (() => RemoveChoice(choice.Name))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, "x");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 27 "C:\Users\josue\GitHub\DecisionMaker\Pages\Movies.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\josue\GitHub\DecisionMaker\Pages\Movies.razor"
       
    //public Activity movies = new Activity { };
    private string NewChoice;
    const string Key = "MovieList";

    // Reload items on return, or initiate new list if empty
    protected override async Task OnInitializedAsync()
    {
        movies = await LocalStore.GetItemAsync<Activity>(Key);

        if (movies == null || movies.Items.Count == 0)
        {
            movies = new Activity { };
        }

    }

    // Method to save list to local storage
    public async void UpdateLocalStorage()
    {
        await LocalStore.SetItemAsync(Key, movies);
    }

    // Method to clear local storage
    public async void ClearLocalStorage()
    {
        movies.Items.Clear();
        await LocalStore.ClearAsync();
    }

    // Method for adding option to choices
    public void AddChoiceToChoices()

    {
        bool isNotEmpty = !string.IsNullOrWhiteSpace(NewChoice);
        bool isNewChoice = !movies.Items.Any(choice => choice.Name == NewChoice);

        if (isNotEmpty && isNewChoice)
        {
            var item = new Choice { Name = NewChoice };


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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Activity movies { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService LocalStore { get; set; }
    }
}
#pragma warning restore 1591
