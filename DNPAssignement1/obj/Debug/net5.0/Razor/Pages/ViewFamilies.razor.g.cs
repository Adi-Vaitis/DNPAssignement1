#pragma checksum "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\ViewFamilies.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6d9cc010af744d7366c9435c3ca568a2ef8c495"
// <auto-generated/>
#pragma warning disable 1591
namespace DNPAssignement1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\_Imports.razor"
using DNPAssignement1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\_Imports.razor"
using DNPAssignement1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\ViewFamilies.razor"
using FileData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\ViewFamilies.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ViewFamilies")]
    public partial class ViewFamilies : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ViewFamilies </h3>\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, " Search(ID, first name, last name): ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\ViewFamilies.razor"
                                                                      (arg) => Search(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width:50px");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 8 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\ViewFamilies.razor"
 if (familiesToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\ViewFamilies.razor"
}
else if (!familiesToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<p><em>There is no family added, but you can add some.</em></p>");
#nullable restore
#line 19 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\ViewFamilies.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table");
            __builder.AddMarkupContent(11, "<thead><tr><th>Family ID</th> <th>Adults</th> <th>Children</th> <th>Street name</th> <th>House number</th></tr></thead>\n        ");
            __builder.OpenElement(12, "tbody");
#nullable restore
#line 29 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\ViewFamilies.razor"
         foreach (var item in familiesToShow)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "tr");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 32 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\ViewFamilies.razor"
                     item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n                ");
            __builder.OpenElement(17, "td");
#nullable restore
#line 34 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\ViewFamilies.razor"
                     foreach (var adult in item.Adults)
                    {
                        

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, 
#nullable restore
#line 36 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\ViewFamilies.razor"
                         adult.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(19, "<br>");
#nullable restore
#line 39 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\ViewFamilies.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n                ");
            __builder.OpenElement(21, "td");
#nullable restore
#line 42 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\ViewFamilies.razor"
                     if (item.Children != null)
                    {
                        foreach (var child in item.Children)
                        {
                            

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, 
#nullable restore
#line 46 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\ViewFamilies.razor"
                             child.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(23, "<br>");
#nullable restore
#line 49 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\ViewFamilies.razor"
                        }
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, 
#nullable restore
#line 53 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\ViewFamilies.razor"
                         string.Empty

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 53 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\ViewFamilies.razor"
                                     
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n                ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 56 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\ViewFamilies.razor"
                     item.StreetName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(28, " ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 56 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\ViewFamilies.razor"
                                               item.HouseNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 58 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\ViewFamilies.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 61 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\ViewFamilies.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\ViewFamilies.razor"
       
    private FileContext fileContext;
    private IList<Family> familiesToShow;

    protected override async Task OnInitializedAsync()
    {
        fileContext = new();
        familiesToShow = fileContext.Families;
    }

    private void Search(ChangeEventArgs changeEventArgs)
    {
        int? search = null;
        string? searchAdult = null;
        try
        {
            search = int.Parse(changeEventArgs.Value.ToString());
        }
        catch (Exception e)
        {
            search = null;
            searchAdult = changeEventArgs.Value.ToString();
        }
        if (search != null)
        {
            familiesToShow = fileContext.Families.Where(t => t.Id == search).ToList();
        }
        else if (searchAdult != null)
        {
            familiesToShow = fileContext.Families.Where(t =>
            {
                string names = "";
                foreach (var a in t.Adults)
                {
                    names += a.FirstName.ToLower() + a.LastName.ToLower();
                }
                return names.Contains(searchAdult.ToLower());
            }).ToList();
        }
        else
        {
            familiesToShow = fileContext.Families;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FileContext FileContext { get; set; }
    }
}
#pragma warning restore 1591
