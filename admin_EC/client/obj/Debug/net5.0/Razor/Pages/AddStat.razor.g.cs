#pragma checksum "C:\Users\hieu0\Desktop\admin_EC\client\Pages\AddStat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad3a02d008390f09ef9d771d019e5e6a4e439337"
// <auto-generated/>
#pragma warning disable 1591
namespace Admin.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hieu0\Desktop\admin_EC\client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hieu0\Desktop\admin_EC\client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hieu0\Desktop\admin_EC\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hieu0\Desktop\admin_EC\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hieu0\Desktop\admin_EC\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hieu0\Desktop\admin_EC\client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hieu0\Desktop\admin_EC\client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hieu0\Desktop\admin_EC\client\_Imports.razor"
using Admin.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hieu0\Desktop\admin_EC\client\_Imports.razor"
using Admin.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\AddStat.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\AddStat.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\AddStat.razor"
using Admin.Models.Suchimnu;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-stat")]
    public partial class AddStat : Admin.Pages.AddStatComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Admin.Models.Suchimnu.Stat>>(7);
                __builder2.AddAttribute(8, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Admin.Models.Suchimnu.Stat>(
#nullable restore
#line 12 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\AddStat.razor"
                                   stat

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Visible", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\AddStat.razor"
                                                    stat != null

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Submit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Admin.Models.Suchimnu.Stat>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Admin.Models.Suchimnu.Stat>(this, 
#nullable restore
#line 12 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\AddStat.razor"
                                                                                                               Form0Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(12, "div");
                    __builder3.AddAttribute(13, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(14, "class", "row");
                    __builder3.OpenElement(15, "div");
                    __builder3.AddAttribute(16, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(17);
                    __builder3.AddAttribute(18, "Text", "Visits");
                    __builder3.AddAttribute(19, "Component", "Visits");
                    __builder3.AddAttribute(20, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(21, "\n              ");
                    __builder3.OpenElement(22, "div");
                    __builder3.AddAttribute(23, "class", "col-md-9");
                    __Blazor.Admin.Client.Pages.AddStat.TypeInference.CreateRadzenNumeric_0(__builder3, 24, 25, "display: block; width: 100%", 26, "Visits", 27, 
#nullable restore
#line 20 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\AddStat.razor"
                                                                                  stat.Visits

#line default
#line hidden
#nullable disable
                    , 28, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => stat.Visits = __value, stat.Visits)), 29, () => stat.Visits);
                    __builder3.AddMarkupContent(30, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(31);
                    __builder3.AddAttribute(32, "Component", "Visits");
                    __builder3.AddAttribute(33, "Text", "Visits is required");
                    __builder3.AddAttribute(34, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(35, "\n            ");
                    __builder3.OpenElement(36, "div");
                    __builder3.AddAttribute(37, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(38, "class", "row");
                    __builder3.OpenElement(39, "div");
                    __builder3.AddAttribute(40, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(41);
                    __builder3.AddAttribute(42, "Text", "Last Visit");
                    __builder3.AddAttribute(43, "Component", "LastVisit");
                    __builder3.AddAttribute(44, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(45, "\n              ");
                    __builder3.OpenElement(46, "div");
                    __builder3.AddAttribute(47, "class", "col-md-9");
                    __Blazor.Admin.Client.Pages.AddStat.TypeInference.CreateRadzenDatePicker_1(__builder3, 48, 49, "dd/MM/yyyy", 50, "width: 100%", 51, "LastVisit", 52, 
#nullable restore
#line 32 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\AddStat.razor"
                                                                                             stat.LastVisit

#line default
#line hidden
#nullable disable
                    , 53, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => stat.LastVisit = __value, stat.LastVisit)), 54, () => stat.LastVisit);
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(55, "\n            ");
                    __builder3.OpenElement(56, "div");
                    __builder3.AddAttribute(57, "class", "row");
                    __builder3.OpenElement(58, "div");
                    __builder3.AddAttribute(59, "class", "col offset-sm-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(60);
                    __builder3.AddAttribute(61, "ButtonType", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 38 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\AddStat.razor"
                                          ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(62, "Icon", "save");
                    __builder3.AddAttribute(63, "Text", "Save");
                    __builder3.AddAttribute(64, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 38 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\AddStat.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(65, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(66);
                    __builder3.AddAttribute(67, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 40 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\AddStat.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(68, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(69, "Text", "Cancel");
                    __builder3.AddAttribute(70, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\AddStat.razor"
                                                                                                              Button2Click

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Admin.Client.Pages.AddStat
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenNumeric_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDatePicker_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Object __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DateFormat", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "Name", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591