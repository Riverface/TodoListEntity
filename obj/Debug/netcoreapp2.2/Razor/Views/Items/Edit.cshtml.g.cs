#pragma checksum "D:\Projects\Programming\ToDoListEntity\todolist\Views\Items\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a7ddb7b620b650b5b9203c6c6008f9eb7bafaa8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Edit), @"mvc.1.0.view", @"/Views/Items/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/Edit.cshtml", typeof(AspNetCore.Views_Items_Edit))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a7ddb7b620b650b5b9203c6c6008f9eb7bafaa8", @"/Views/Items/Edit.cshtml")]
    public class Views_Items_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoList.Models.Item>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Projects\Programming\ToDoListEntity\todolist\Views\Items\Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(61, 39, true);
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n<h4>Edit this task: ");
            EndContext();
            BeginContext(101, 43, false);
#line 9 "D:\Projects\Programming\ToDoListEntity\todolist\Views\Items\Edit.cshtml"
               Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(144, 9, true);
            WriteLiteral("</h4>\r\n\r\n");
            EndContext();
#line 11 "D:\Projects\Programming\ToDoListEntity\todolist\Views\Items\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(188, 37, false);
#line 13 "D:\Projects\Programming\ToDoListEntity\todolist\Views\Items\Edit.cshtml"
Write(Html.HiddenFor(model => model.ItemId));

#line default
#line hidden
            EndContext();
            BeginContext(234, 41, false);
#line 15 "D:\Projects\Programming\ToDoListEntity\todolist\Views\Items\Edit.cshtml"
Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(282, 42, false);
#line 16 "D:\Projects\Programming\ToDoListEntity\todolist\Views\Items\Edit.cshtml"
Write(Html.EditorFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(333, 29, false);
#line 18 "D:\Projects\Programming\ToDoListEntity\todolist\Views\Items\Edit.cshtml"
Write(Html.Label("Select category"));

#line default
#line hidden
            EndContext();
            BeginContext(369, 31, false);
#line 19 "D:\Projects\Programming\ToDoListEntity\todolist\Views\Items\Edit.cshtml"
Write(Html.DropDownList("CategoryId"));

#line default
#line hidden
            EndContext();
            BeginContext(404, 42, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\r\n");
            EndContext();
#line 22 "D:\Projects\Programming\ToDoListEntity\todolist\Views\Items\Edit.cshtml"
}

#line default
#line hidden
            BeginContext(449, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(455, 40, false);
#line 24 "D:\Projects\Programming\ToDoListEntity\todolist\Views\Items\Edit.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(495, 4, true);
            WriteLiteral("</p>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoList.Models.Item> Html { get; private set; }
    }
}
#pragma warning restore 1591
