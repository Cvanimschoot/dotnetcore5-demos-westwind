#pragma checksum "C:\CPSC1517\Repos\cpsc-1517-workbook-may-2021-dgilleland\src\WestWind.Web\Pages\AdHoc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2706fe1b367e2dbe3044722dcd92f03608f91f52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApp.Pages.Pages_AdHoc), @"mvc.1.0.razor-page", @"/Pages/AdHoc.cshtml")]
namespace WebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\CPSC1517\Repos\cpsc-1517-workbook-may-2021-dgilleland\src\WestWind.Web\Pages\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2706fe1b367e2dbe3044722dcd92f03608f91f52", @"/Pages/AdHoc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09d1db1c25558096e535f8fd24d0fe24129c968a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AdHoc : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/AdHoc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\CPSC1517\Repos\cpsc-1517-workbook-may-2021-dgilleland\src\WestWind.Web\Pages\AdHoc.cshtml"
  
    var Paging = Model.Revamp;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2706fe1b367e2dbe3044722dcd92f03608f91f523399", async() => {
                WriteLiteral("Pagination Trials");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h1>\r\n\r\n\r\n<h2>Revamped Paginator</h2>\r\n\r\n<p>My revamp has ");
#nullable restore
#line 12 "C:\CPSC1517\Repos\cpsc-1517-workbook-may-2021-dgilleland\src\WestWind.Web\Pages\AdHoc.cshtml"
            Write(Model.Revamp.TotalItemCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" items. I am on page # <b>");
#nullable restore
#line 12 "C:\CPSC1517\Repos\cpsc-1517-workbook-may-2021-dgilleland\src\WestWind.Web\Pages\AdHoc.cshtml"
                                                                  Write(Model.Revamp.CurrentState.CurrentPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> of <i>");
#nullable restore
#line 12 "C:\CPSC1517\Repos\cpsc-1517-workbook-may-2021-dgilleland\src\WestWind.Web\Pages\AdHoc.cshtml"
                                                                                                                   Write(Model.Revamp.LastPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i> pages, showing items ?? to ??.</p>\r\n\r\n");
#nullable restore
#line 14 "C:\CPSC1517\Repos\cpsc-1517-workbook-may-2021-dgilleland\src\WestWind.Web\Pages\AdHoc.cshtml"
  
    foreach(var pageRef in Model.Revamp)
    {
        if(pageRef == Model.Revamp.CurrentPage) // I can use the == because of PageRef type being a C# 9 record type
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <b>");
#nullable restore
#line 19 "C:\CPSC1517\Repos\cpsc-1517-workbook-may-2021-dgilleland\src\WestWind.Web\Pages\AdHoc.cshtml"
          Write(pageRef.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n");
#nullable restore
#line 20 "C:\CPSC1517\Repos\cpsc-1517-workbook-may-2021-dgilleland\src\WestWind.Web\Pages\AdHoc.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2706fe1b367e2dbe3044722dcd92f03608f91f526535", async() => {
#nullable restore
#line 23 "C:\CPSC1517\Repos\cpsc-1517-workbook-may-2021-dgilleland\src\WestWind.Web\Pages\AdHoc.cshtml"
                                                                                             Write(pageRef.Text);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 614, "Page", 614, 4, true);
#nullable restore
#line 23 "C:\CPSC1517\Repos\cpsc-1517-workbook-may-2021-dgilleland\src\WestWind.Web\Pages\AdHoc.cshtml"
AddHtmlAttributeValue(" ", 618, pageRef.Page, 619, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-currentpage", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\CPSC1517\Repos\cpsc-1517-workbook-may-2021-dgilleland\src\WestWind.Web\Pages\AdHoc.cshtml"
                                                                       WriteLiteral(pageRef.Page);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentpage"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentpage", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentpage"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 24 "C:\CPSC1517\Repos\cpsc-1517-workbook-may-2021-dgilleland\src\WestWind.Web\Pages\AdHoc.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdHocModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AdHocModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AdHocModel>)PageContext?.ViewData;
        public AdHocModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
