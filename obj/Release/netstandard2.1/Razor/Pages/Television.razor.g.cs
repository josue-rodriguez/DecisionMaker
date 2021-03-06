#pragma checksum "C:\Users\josue\GitHub\DecisionMaker\Pages\Television.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "197d3e672881d1f2466bc39c96ce0bab1a727f2a"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/television")]
    public partial class Television : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>TV Shows</h3>\r\n\r\n\r\n<br>\r\n");
            __builder.OpenElement(1, "span");
            __builder.AddAttribute(2, "style", "font-size: 24px");
            __builder.AddContent(3, 
#nullable restore
#line 9 "C:\Users\josue\GitHub\DecisionMaker\Pages\Television.razor"
                               TV.Decision

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n<br>\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn-choose");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\josue\GitHub\DecisionMaker\Pages\Television.razor"
                                     (() => TV.MakeDecision())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Decide a TV Show");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n<hr>\r\n\r\n");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "class", "input-josue");
            __builder.AddAttribute(12, "placeholder", "e.g., Silicon Valley");
            __builder.AddAttribute(13, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\josue\GitHub\DecisionMaker\Pages\Television.razor"
                                                                                                                               AddChoiceOnEnter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\josue\GitHub\DecisionMaker\Pages\Television.razor"
                                                                           NewChoice

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewChoice = __value, NewChoice));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "btn-add");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\josue\GitHub\DecisionMaker\Pages\Television.razor"
                                  AddChoiceToChoices

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "Add Show");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "btn-choose");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\josue\GitHub\DecisionMaker\Pages\Television.razor"
                                     ClearLocalStorage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Clear All");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n");
            __builder.OpenElement(27, "ul");
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 22 "C:\Users\josue\GitHub\DecisionMaker\Pages\Television.razor"
     foreach (var choice in TV.Items)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "        ");
            __builder.OpenElement(30, "li");
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "span");
            __builder.AddContent(33, 
#nullable restore
#line 25 "C:\Users\josue\GitHub\DecisionMaker\Pages\Television.razor"
                   choice.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "class", "btn-remove");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\josue\GitHub\DecisionMaker\Pages\Television.razor"
                                                 (() => RemoveChoice(choice.Name))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(38, "x");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 28 "C:\Users\josue\GitHub\DecisionMaker\Pages\Television.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
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
