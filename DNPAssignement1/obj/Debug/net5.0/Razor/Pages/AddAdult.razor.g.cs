#pragma checksum "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\AddAdult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54cc7c5d1ba030ade4e188e1342a78d1acbbdbf9"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\AddAdult.razor"
                  newAdult

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\AddAdult.razor"
                                            AddNewAdultToFamily

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddContent(5, " ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group");
                __builder2.AddMarkupContent(10, "\n        Family ID: <br>\n        ");
                __builder2.OpenElement(11, "select");
                __builder2.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\AddAdult.razor"
                       familyID

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => familyID = __value, familyID));
                __builder2.SetUpdatesAttributeName("value");
#nullable restore
#line 12 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\AddAdult.razor"
             if (fileContext?.Families != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\AddAdult.razor"
                 foreach (var family in fileContext.Families)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(14, "option");
                __builder2.AddAttribute(15, "value", 
#nullable restore
#line 16 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\AddAdult.razor"
                                    family.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(16, 
#nullable restore
#line 16 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\AddAdult.razor"
                                                family.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 17 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\AddAdult.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\AddAdult.razor"
                 
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 21 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\AddAdult.razor"
     if(familyID==0)
        {
            string request ="First, you have to select a family ID";
            

#line default
#line hidden
#nullable disable
                __builder2.AddContent(17, 
#nullable restore
#line 24 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\AddAdult.razor"
             request

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 24 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\AddAdult.razor"
                    
        }else{

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group");
                __builder2.AddMarkupContent(20, " First Name:<br> ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "rows", "4");
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\AddAdult.razor"
                                                                               newAdult.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.FirstName = __value, newAdult.FirstName))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdult.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\n    ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group");
                __builder2.AddMarkupContent(29, " Last Name:<br> ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "rows", "4");
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\AddAdult.razor"
                                                                              newAdult.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.LastName = __value, newAdult.LastName))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdult.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\n    ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-group");
                __builder2.AddMarkupContent(38, " Hair Color:<br> ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(39);
                __builder2.AddAttribute(40, "rows", "4");
                __builder2.AddAttribute(41, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\AddAdult.razor"
                                                                               newAdult.HairColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.HairColor = __value, newAdult.HairColor))));
                __builder2.AddAttribute(43, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdult.HairColor));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\n    ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group");
                __builder2.AddMarkupContent(47, " Eye Color:<br> ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(48);
                __builder2.AddAttribute(49, "rows", "4");
                __builder2.AddAttribute(50, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\AddAdult.razor"
                                                                              newAdult.EyeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.EyeColor = __value, newAdult.EyeColor))));
                __builder2.AddAttribute(52, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdult.EyeColor));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\n    ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "form-group");
                __builder2.AddMarkupContent(56, " Age:<br> ");
                __Blazor.DNPAssignement1.Pages.AddAdult.TypeInference.CreateInputNumber_0(__builder2, 57, 58, "4", 59, 
#nullable restore
#line 30 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\AddAdult.razor"
                                                                          newAdult.Age

#line default
#line hidden
#nullable disable
                , 60, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.Age = __value, newAdult.Age)), 61, () => newAdult.Age);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\n    ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "form-group");
                __builder2.AddMarkupContent(65, " Weight:<br> ");
                __Blazor.DNPAssignement1.Pages.AddAdult.TypeInference.CreateInputNumber_1(__builder2, 66, 67, "4", 68, 
#nullable restore
#line 31 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\AddAdult.razor"
                                                                             newAdult.Weight

#line default
#line hidden
#nullable disable
                , 69, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.Weight = __value, newAdult.Weight)), 70, () => newAdult.Weight);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\n    ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "form-group");
                __builder2.AddMarkupContent(74, " Height:<br> ");
                __Blazor.DNPAssignement1.Pages.AddAdult.TypeInference.CreateInputNumber_2(__builder2, 75, 76, "4", 77, 
#nullable restore
#line 32 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\AddAdult.razor"
                                                                             newAdult.Height

#line default
#line hidden
#nullable disable
                , 78, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.Height = __value, newAdult.Height)), 79, () => newAdult.Height);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\n    ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "form-group");
                __builder2.AddMarkupContent(83, " Gender:<br> ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(84);
                __builder2.AddAttribute(85, "rows", "4");
                __builder2.AddAttribute(86, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\AddAdult.razor"
                                                                           newAdult.Sex

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.Sex = __value, newAdult.Sex))));
                __builder2.AddAttribute(88, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdult.Sex));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\n    ");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "form-group");
                __builder2.AddMarkupContent(92, " Job:<br> ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(93);
                __builder2.AddAttribute(94, "rows", "4");
                __builder2.AddAttribute(95, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\AddAdult.razor"
                                                                        newAdult.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(96, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.JobTitle.JobTitle = __value, newAdult.JobTitle.JobTitle))));
                __builder2.AddAttribute(97, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdult.JobTitle.JobTitle));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\n    ");
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "class", "form-group");
                __builder2.AddMarkupContent(101, " Salary:<br> ");
                __Blazor.DNPAssignement1.Pages.AddAdult.TypeInference.CreateInputNumber_3(__builder2, 102, 103, "4", 104, 
#nullable restore
#line 35 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\AddAdult.razor"
                                                                             newAdult.JobTitle.Salary

#line default
#line hidden
#nullable disable
                , 105, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.JobTitle.Salary = __value, newAdult.JobTitle.Salary)), 106, () => newAdult.JobTitle.Salary);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\n    ");
                __builder2.AddMarkupContent(108, "<p class=\"actions\"><button class=\"btn btn-outline-dark\" type=\"submit\">Create</button></p>");
#nullable restore
#line 38 "C:\Users\vaiti\RiderProjects\DNPAssignement1\DNPAssignement1\Pages\AddAdult.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
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
namespace __Blazor.DNPAssignement1.Pages.AddAdult
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "rows", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "rows", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "rows", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "rows", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
