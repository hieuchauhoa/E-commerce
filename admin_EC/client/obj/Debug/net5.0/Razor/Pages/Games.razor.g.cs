#pragma checksum "C:\Users\hieu0\Desktop\admin_EC\client\Pages\Games.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1d4e6d6e1c45d955c70668fb086e384f504bf34"
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
#line 5 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\Games.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\Games.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\Games.razor"
using Admin.Models.Suchimnu;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/games")]
    public partial class Games : Admin.Pages.GamesComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(3);
                __builder2.AddAttribute(4, "Size", "H1");
                __builder2.AddAttribute(5, "Text", "Games");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(11);
                __builder2.AddAttribute(12, "Icon", "add_circle_outline");
                __builder2.AddAttribute(13, "style", "margin-bottom: 10px");
                __builder2.AddAttribute(14, "Text", "Add");
                __builder2.AddAttribute(15, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\Games.razor"
                                                                                               Button0Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSplitButton>(17);
                __builder2.AddAttribute(18, "Icon", "get_app");
                __builder2.AddAttribute(19, "style", "margin-left: 10px; margin-bottom: 10px");
                __builder2.AddAttribute(20, "Text", "Export");
                __builder2.AddAttribute(21, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.Blazor.RadzenSplitButtonItem>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.Blazor.RadzenSplitButtonItem>(this, 
#nullable restore
#line 16 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\Games.razor"
                                                                                                               Splitbutton0Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenSplitButtonItem>(23);
                    __builder3.AddAttribute(24, "Text", "Excel");
                    __builder3.AddAttribute(25, "Value", "xlsx");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenSplitButtonItem>(27);
                    __builder3.AddAttribute(28, "Text", "CSV");
                    __builder3.AddAttribute(29, "Value", "csv");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(31);
                __builder2.AddAttribute(32, "Placeholder", "Search ...");
                __builder2.AddAttribute(33, "style", "display: block; margin-bottom: 10px; width: 100%");
                __builder2.AddAttribute(34, "Name", "Textbox0");
                __builder2.AddAttribute(35, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\Games.razor"
                                                                                                                                     async(args) => {search = $"{args.Value}";await grid0.GoToPage(0);await grid0.Reload();}

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<Admin.Models.Suchimnu.Game>>(37);
                __builder2.AddAttribute(38, "AllowFiltering", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\Games.razor"
                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "FilterMode", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 26 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\Games.razor"
                                                                       Radzen.FilterMode.Advanced

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "AllowPaging", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\Games.razor"
                                                                                                                true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "AllowSorting", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\Games.razor"
                                                                                                                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Admin.Models.Suchimnu.Game>>(
#nullable restore
#line 26 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\Games.razor"
                                                                                                                                                 getGamesResult

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "Count", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\Games.razor"
                                                                                                                                                                         getGamesCount

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "LoadData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.LoadDataArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.LoadDataArgs>(this, 
#nullable restore
#line 26 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\Games.razor"
                                                                                                                                                                                                                                      Grid0LoadData

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(45, "RowDoubleClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.DataGridRowMouseEventArgs<Admin.Models.Suchimnu.Game>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.DataGridRowMouseEventArgs<Admin.Models.Suchimnu.Game>>(this, 
#nullable restore
#line 26 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\Games.razor"
                                                                                                                                                                                                                                                                      Grid0RowDoubleClick

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(46, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Admin.Models.Suchimnu.Game>>(47);
                    __builder3.AddAttribute(48, "Property", "Id");
                    __builder3.AddAttribute(49, "Title", "Id");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Admin.Models.Suchimnu.Game>>(51);
                    __builder3.AddAttribute(52, "Property", "Title");
                    __builder3.AddAttribute(53, "Title", "Title");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(54, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Admin.Models.Suchimnu.Game>>(55);
                    __builder3.AddAttribute(56, "Property", "Description");
                    __builder3.AddAttribute(57, "Title", "Description");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(58, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Admin.Models.Suchimnu.Game>>(59);
                    __builder3.AddAttribute(60, "Property", "ShortDescription");
                    __builder3.AddAttribute(61, "Title", "Short Description");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Admin.Models.Suchimnu.Game>>(63);
                    __builder3.AddAttribute(64, "Property", "ImageUrl");
                    __builder3.AddAttribute(65, "Title", "Image Url");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(66, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Admin.Models.Suchimnu.Game>>(67);
                    __builder3.AddAttribute(68, "Property", "Price");
                    __builder3.AddAttribute(69, "Title", "Price");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(70, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Admin.Models.Suchimnu.Game>>(71);
                    __builder3.AddAttribute(72, "Property", "OriginalPrice");
                    __builder3.AddAttribute(73, "Title", "Original Price");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(74, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Admin.Models.Suchimnu.Game>>(75);
                    __builder3.AddAttribute(76, "Property", "IsActive");
                    __builder3.AddAttribute(77, "Title", "Is Active");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(78, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Admin.Models.Suchimnu.Game>>(79);
                    __builder3.AddAttribute(80, "Property", "CategoryId");
                    __builder3.AddAttribute(81, "SortProperty", "Category.Name");
                    __builder3.AddAttribute(82, "GroupProperty", "Category.Name");
                    __builder3.AddAttribute(83, "FilterProperty", "Category.Name");
                    __builder3.AddAttribute(84, "Title", "Category");
                    __builder3.AddAttribute(85, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Admin.Models.Suchimnu.Game>)((data) => (__builder4) => {
#nullable restore
#line 46 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\Games.razor"
__builder4.AddContent(86, data.Category?.Name);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(87, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Admin.Models.Suchimnu.Game>>(88);
                    __builder3.AddAttribute(89, "Property", "StudioId");
                    __builder3.AddAttribute(90, "SortProperty", "Studio.Name");
                    __builder3.AddAttribute(91, "GroupProperty", "Studio.Name");
                    __builder3.AddAttribute(92, "FilterProperty", "Studio.Name");
                    __builder3.AddAttribute(93, "Title", "Studio");
                    __builder3.AddAttribute(94, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Admin.Models.Suchimnu.Game>)((data) => (__builder4) => {
#nullable restore
#line 51 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\Games.razor"
__builder4.AddContent(95, data.Studio?.Name);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(96, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Admin.Models.Suchimnu.Game>>(97);
                    __builder3.AddAttribute(98, "Property", "CreateDate");
                    __builder3.AddAttribute(99, "FormatString", "{0:dd/MM/yyyy}");
                    __builder3.AddAttribute(100, "Title", "Create Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(101, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Admin.Models.Suchimnu.Game>>(102);
                    __builder3.AddAttribute(103, "Property", "LatestUpdate");
                    __builder3.AddAttribute(104, "FormatString", "{0:dd/MM/yyyy}");
                    __builder3.AddAttribute(105, "Title", "Latest Update");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(106, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Admin.Models.Suchimnu.Game>>(107);
                    __builder3.AddAttribute(108, "Filterable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 58 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\Games.razor"
                                                                                 false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(109, "Sortable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 58 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\Games.razor"
                                                                                                  false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(110, "Width", "70px");
                    __builder3.AddAttribute(111, "TextAlign", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 58 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\Games.razor"
                                                                                                                                 TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(112, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Admin.Models.Suchimnu.Game>)((adminModelsSuchimnuGame) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(113);
                        __builder4.AddAttribute(114, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 60 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\Games.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(115, "Icon", "close");
                        __builder4.AddAttribute(116, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#nullable restore
#line 60 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\Games.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(117, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\Games.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, adminModelsSuchimnuGame)

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddEventStopPropagationAttribute(118, "onclick", 
#nullable restore
#line 60 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\Games.razor"
                                                                                                                                                                                                       true

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddComponentReferenceCapture(119, (__value) => {
#nullable restore
#line 26 "C:\Users\hieu0\Desktop\admin_EC\client\Pages\Games.razor"
                              grid0 = (Radzen.Blazor.RadzenDataGrid<Admin.Models.Suchimnu.Game>)__value;

#line default
#line hidden
#nullable disable
                }
                );
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
#pragma warning restore 1591
