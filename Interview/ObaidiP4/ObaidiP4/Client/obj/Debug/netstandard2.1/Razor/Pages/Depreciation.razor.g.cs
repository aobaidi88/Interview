#pragma checksum "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\Pages\Depreciation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49a3d82f047e69694294e92dbda34af0f645bf16"
// <auto-generated/>
#pragma warning disable 1591
namespace ObaidiP4.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\_Imports.razor"
using ObaidiP4.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\_Imports.razor"
using ObaidiP4.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\_Imports.razor"
using WebAssemblyMan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\Pages\Depreciation.razor"
using ObaidiP4.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/depreciations")]
    public partial class Depreciation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 style=\"font-family:\'Bookman Old Style\'; font-size:x-large\">Depreciation Calculator</h1>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\Pages\Depreciation.razor"
                         CalcDepreciation

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\Pages\Depreciation.razor"
                  ClassMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.AddMarkupContent(11, "<label class=\"col-sm-3 col-form-label\" for=\"StartValue\">Start Value: </label>\r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-sm-9");
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenElement(15, "input");
                __builder2.AddAttribute(16, "type", "number");
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\Pages\Depreciation.razor"
                                                              startValue

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => startValue = __value, startValue, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.AddMarkupContent(26, "<label class=\"col-sm-3 col-form-label\" for=\"SalvageValue\">Salvage Value:</label>\r\n        ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "col-sm-9");
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.OpenElement(30, "input");
                __builder2.AddAttribute(31, "type", "number");
                __builder2.AddAttribute(32, "class", "form-control");
                __builder2.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\Pages\Depreciation.razor"
                                                              salvageValue

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => salvageValue = __value, salvageValue, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n    ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.AddMarkupContent(41, "<label class=\"col-sm-3 col-form-label\" for=\"LifeTime\">Estimated Life Time of Asset:</label>\r\n        ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col-sm-9");
                __builder2.AddMarkupContent(44, "\r\n            ");
                __builder2.OpenElement(45, "input");
                __builder2.AddAttribute(46, "type", "number");
                __builder2.AddAttribute(47, "class", "form-control");
                __builder2.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\Pages\Depreciation.razor"
                                                              lifeTime

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lifeTime = __value, lifeTime, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n    ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.AddMarkupContent(56, "<label class=\"col-sm-3 col-form-label\" for=\"Age\">Age of Aseet in Years:</label>\r\n        ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "col-sm-9");
                __builder2.AddMarkupContent(59, "\r\n            ");
                __builder2.OpenElement(60, "input");
                __builder2.AddAttribute(61, "type", "number");
                __builder2.AddAttribute(62, "class", "form-control");
                __builder2.AddAttribute(63, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\Pages\Depreciation.razor"
                                                              age

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(64, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => age = __value, age, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n\r\n    ");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(70, "\r\n        ");
                __builder2.AddMarkupContent(71, "<label class=\"col-sm-3 col-form-label\">Type of Depreciation</label>\r\n        ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "col-sm-9");
                __builder2.AddMarkupContent(74, "\r\n");
#nullable restore
#line 40 "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\Pages\Depreciation.razor"
             foreach (var type in ClassMenu.DepreciationType)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(75, "                ");
                __builder2.OpenElement(76, "input");
                __builder2.AddAttribute(77, "type", "radio");
                __builder2.AddAttribute(78, "name", "depreciationType");
                __builder2.AddAttribute(79, "value", 
#nullable restore
#line 42 "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\Pages\Depreciation.razor"
                                                                    type

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(80, "id", 
#nullable restore
#line 42 "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\Pages\Depreciation.razor"
                                                                                type

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(81, "checked", 
#nullable restore
#line 43 "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\Pages\Depreciation.razor"
                                  radioValue.Equals(type, StringComparison.OrdinalIgnoreCase)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(82, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 43 "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\Pages\Depreciation.razor"
                                                                                                           OnChange

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n                ");
                __builder2.OpenElement(84, "label");
                __builder2.AddAttribute(85, "for", 
#nullable restore
#line 44 "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\Pages\Depreciation.razor"
                             type

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(86, 
#nullable restore
#line 44 "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\Pages\Depreciation.razor"
                                    type

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n");
#nullable restore
#line 45 "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\Pages\Depreciation.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(88, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n    ");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "form-group mb-0");
                __builder2.AddMarkupContent(93, "\r\n        ");
                __builder2.AddMarkupContent(94, "<button type=\"submit\" id=\"BtnRegister\" class=\"btn btn-primary\">\r\n            Calculate\r\n        </button>\r\n        ");
                __builder2.OpenElement(95, "button");
                __builder2.AddAttribute(96, "class", "btn btn-success");
                __builder2.AddAttribute(97, "type", "reset");
                __builder2.AddAttribute(98, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\Pages\Depreciation.razor"
                            () => Clear()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(99, "\r\n            Clear\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n    ");
                __builder2.OpenElement(102, "div");
                __builder2.AddMarkupContent(103, "\r\n        ");
                __builder2.OpenElement(104, "label");
                __builder2.AddAttribute(105, "style", "padding:5px");
                __builder2.AddContent(106, " Result: ");
                __builder2.AddContent(107, 
#nullable restore
#line 59 "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\Pages\Depreciation.razor"
                                             summary

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(108, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n    ");
                __builder2.OpenElement(111, "div");
                __builder2.AddMarkupContent(112, "\r\n        ");
                __builder2.OpenComponent<WebAssemblyMan.LineChart>(113);
                __builder2.AddAttribute(114, "InputLabels", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 62 "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\Pages\Depreciation.razor"
                                 radioValue

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(115, "InputSeries1", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 63 "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\Pages\Depreciation.razor"
                                  dataStr

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(116, "XAxisLabels", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 64 "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\Pages\Depreciation.razor"
                                 yearsStr

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(117, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "D:\C#\C#_.NET II\Projects\Project4\ObaidiP4\ObaidiP4\Client\Pages\Depreciation.razor"
       

    private BaseClass ClassMenu = new BaseClass();
    private double startValue, salvageValue;
    private int age, lifeTime;
    private string summary, radioValue = " ";
    private string dataStr = "", yearsStr = "";

    protected override void OnInitialized()
    {
        base.OnInitialized();
        CalcDepreciation();
        Clear();
        StateHasChanged();
    }

    private void OnChange(ChangeEventArgs args)
    {
        radioValue = args.Value.ToString();
    }

    private void CalcDepreciation()
    {
        List<int> yearsList = new List<int>();

        for (int i = 0; i <= age; ++i)
        {
            yearsList.Add(i);
        }
        yearsStr = String.Join(',', yearsList);

        if (radioValue == "Straight Line")
        {
            ClassMenu.DepreciationStraightLine.StartValue = startValue;
            ClassMenu.DepreciationStraightLine.SalvageValue = salvageValue;
            ClassMenu.DepreciationStraightLine.LifeTime = lifeTime;
            ClassMenu.DepreciationStraightLine.Age = age;
            summary = ClassMenu.DepreciationStraightLine.ToString() + radioValue;
            dataStr = ClassMenu.DepreciationStraightLine.str;
        }
        else if (radioValue == "Double Declining")
        {
            ClassMenu.DepreciationDoubleDeclining.StartValue = startValue;
            ClassMenu.DepreciationDoubleDeclining.SalvageValue = salvageValue;
            ClassMenu.DepreciationDoubleDeclining.LifeTime = lifeTime;
            ClassMenu.DepreciationDoubleDeclining.Age = age;
            summary = ClassMenu.DepreciationDoubleDeclining.ToString() + radioValue;
            dataStr = ClassMenu.DepreciationDoubleDeclining.str;
        }
        else
        {
            summary = "You must be select the depreciation type";
        }
    }

    private void Clear()
    {
        startValue = default;
        salvageValue = default;
        age = default;
        lifeTime = default;
        summary = default;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
