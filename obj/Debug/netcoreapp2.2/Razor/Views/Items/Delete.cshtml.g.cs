#pragma checksum "D:\Projects\Programming\ToDoListEntity\todolist\Views\Items\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20333dbeb0737bf121b9a57426f0295210a55310"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Delete), @"mvc.1.0.view", @"/Views/Items/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/Delete.cshtml", typeof(AspNetCore.Views_Items_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20333dbeb0737bf121b9a57426f0295210a55310", @"/Views/Items/Delete.cshtml")]
    public class Views_Items_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoList.Models.Item>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Projects\Programming\ToDoListEntity\todolist\Views\Items\Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(61, 52, true);
            WriteLiteral("\r\n<h2>Are you sure you want to delete this?</h2>\r\n\r\n");
            EndContext();
            BeginContext(114, 47, false);
#line 9 "D:\Projects\Programming\ToDoListEntity\todolist\Views\Items\Delete.cshtml"
Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(161, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(164, 43, false);
#line 9 "D:\Projects\Programming\ToDoListEntity\todolist\Views\Items\Delete.cshtml"
                                             Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(207, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "D:\Projects\Programming\ToDoListEntity\todolist\Views\Items\Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(239, 44, true);
            WriteLiteral("    <input type=\"submit\" value=\"Delete\" />\r\n");
            EndContext();
#line 13 "D:\Projects\Programming\ToDoListEntity\todolist\Views\Items\Delete.cshtml"
}

#line default
#line hidden
            BeginContext(287, 40, false);
#line 14 "D:\Projects\Programming\ToDoListEntity\todolist\Views\Items\Delete.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
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
