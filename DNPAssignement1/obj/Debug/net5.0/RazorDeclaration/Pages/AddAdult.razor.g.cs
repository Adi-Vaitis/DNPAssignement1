// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DNPAssignement1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 1 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\AddAdult.razor"
using FileData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\AddAdult.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\AddAdult.razor"
using Models;

#line default
#line hidden
#nullable disable
    public partial class AddAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\AddAdult.razor"
       
    private Adult newAdult = new Adult()
    {
        JobTitle = new Job()
    };

    private int familyID=0;
    private FileContext fileContext;

    protected override async Task OnInitializedAsync()
    {
        fileContext = new();
    }
    private void AddNewAdultToFamily()
    {

        if (fileContext.Families.FirstOrDefault(t => t.Id == familyID).Adults == null)
        {
            fileContext.Families.FirstOrDefault(t => t.Id == familyID).Adults = new List<Adult>();
        }
        newAdult.Id = fileContext.Families.FirstOrDefault(t => t.Id == familyID).Adults.Count + 1;
        fileContext.Families.FirstOrDefault(t => t.Id == familyID).Adults.Add(newAdult);
        fileContext.SaveChanges();
        NavigationManager.NavigateTo("/ViewFamilies");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FileContext FileContext { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
