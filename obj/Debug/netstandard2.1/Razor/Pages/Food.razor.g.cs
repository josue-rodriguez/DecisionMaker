#pragma checksum "C:\Users\josue\GitHub\DecisionMaker\Pages\Food.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09d3774e88bfed00d362d2774e47f21114d60d08"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/food")]
    public partial class Food : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Foods</h3>\r\n\r\n\r\n<br>\r\n\r\n\r\n<hr>\r\n\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "class", "input-josue");
            __builder.AddAttribute(3, "placeholder", "e.g., de Vere\'s Irish Pub");
            __builder.AddAttribute(4, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\josue\GitHub\DecisionMaker\Pages\Food.razor"
                                                                                                                                 AddChoiceOnEnter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\josue\GitHub\DecisionMaker\Pages\Food.razor"
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
#line 17 "C:\Users\josue\GitHub\DecisionMaker\Pages\Food.razor"
                                  AddChoiceToChoices

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, "Add Food");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "btn-choose");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\josue\GitHub\DecisionMaker\Pages\Food.razor"
                                     ClearLocalStorage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Clear All");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n");
            __builder.OpenElement(18, "ul");
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 21 "C:\Users\josue\GitHub\DecisionMaker\Pages\Food.razor"
     foreach (var choice in foods.Items)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "        ");
            __builder.OpenElement(21, "li");
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "span");
            __builder.AddContent(24, 
#nullable restore
#line 24 "C:\Users\josue\GitHub\DecisionMaker\Pages\Food.razor"
                   choice.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "class", "btn-remove");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\josue\GitHub\DecisionMaker\Pages\Food.razor"
                                                 (() => RemoveChoice(choice.Name))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, "x");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 27 "C:\Users\josue\GitHub\DecisionMaker\Pages\Food.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\josue\GitHub\DecisionMaker\Pages\Food.razor"
       
   // public Activity foods = new Activity { };
    private string NewChoice;
    const string Key = "FoodList";

    // Add Choice to foods
    // Reload items on return
    protected override async Task OnInitializedAsync()
    {
        foods = await LocalStore.GetItemAsync<Activity>(Key);

        if (foods == null || foods.Items.Count == 0)
        {
            foods = new Activity { };
        }

    }

    public async void UpdateLocalStorage()
    {
        await LocalStore.SetItemAsync(Key, foods);
    }

    public async void ClearLocalStorage()
    {
        foods.Items.Clear();
        await LocalStore.ClearAsync();
    }

    public void AddChoiceToChoices()

    {
        bool isNotEmpty = !string.IsNullOrWhiteSpace(NewChoice);
        bool isNewChoice = !foods.Items.Any(choice => choice.Name == NewChoice);

        if (isNotEmpty && isNewChoice)
        {
            var item = new Choice { Name = NewChoice };


            foods.Items.Add(item);

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
        var ItemToRemove = foods.Items.Single(choice => choice.Name == ChoiceToRemove);
        foods.Items.Remove(ItemToRemove);
        UpdateLocalStorage();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Activity foods { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService LocalStore { get; set; }
    }
}
#pragma warning restore 1591
