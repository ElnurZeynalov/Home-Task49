#pragma checksum "C:\Users\ELNUR\Desktop\Home Task 2\ProniaWeb\ProniaWeb\Areas\AdminPanel\Views\Slide\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b78fa5659f171098ca0483a2536247c0fd592a9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Slide_Index), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Slide/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\ELNUR\Desktop\Home Task 2\ProniaWeb\ProniaWeb\Areas\AdminPanel\_ViewImports.cshtml"
using ProniaWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ELNUR\Desktop\Home Task 2\ProniaWeb\ProniaWeb\Areas\AdminPanel\_ViewImports.cshtml"
using ProniaWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b78fa5659f171098ca0483a2536247c0fd592a9f", @"/Areas/AdminPanel/Views/Slide/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbd0fcbf75b6c92676121a07cc2ee4996300acb1", @"/Areas/AdminPanel/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_AdminPanel_Views_Slide_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Slider>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img card-img-horizontal sw-11 h-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary mx-lg-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ELNUR\Desktop\Home Task 2\ProniaWeb\ProniaWeb\Areas\AdminPanel\Views\Slide\Index.cshtml"
  
    ViewData["Title"] = "Edit Slide";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Modal -->
  <div class=""modal fade"" id=""deleteModal"" tabindex=""-1"" aria-labelledby=""deleteModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
      <div class=""modal-content"">
        <div class=""modal-header"">
          <h5 class=""modal-title"" id=""exampleModalLabel"">Delete Slide İtem</h5>
          <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
        </div>
        <div class=""modal-body"">
            Do you want to delete,
        </div>
        <div class=""modal-footer"" id=""DeleteForm"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b78fa5659f171098ca0483a2536247c0fd592a9f6503", async() => {
                WriteLiteral("\r\n            <button type=\"submit\" class=\"btn btn-danger\">Yes</button>\r\n            <button type=\"button\" class=\"btn btn-secondary\" data-bs-dismiss=\"modal\">No</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
      </div>
    </div>
  </div>

<div id=""checkboxTable"">
    <div class=""mb-4 mb-lg-3 bg-transparent no-shadow d-none d-lg-block"">
        <div class=""row g-0"">
            <div class=""col-auto sw-11 d-none d-lg-flex""></div>
            <div class=""col"">
                <div class=""ps-5 pe-4 h-100"">
                    <div class=""row g-0 h-100 align-content-center custom-sort"">
                        <div class=""col-3 col-lg-3 d-flex flex-column mb-lg-0 pe-3 d-flex"">
                            <div class=""text-muted text-small text-center cursor-pointer sort"" data-sort=""name"">TITLE</div>
                        </div>
                        <div class=""col-2 col-lg-3 d-flex flex-column pe-1 justify-content-center"">
                            <div class=""text-muted text-small text-center  cursor-pointer sort"" data-sort=""email"">DESCRIPTION</div>
                        </div>
                        <div class=""col-2 col-lg-3 d-flex flex-column pe-1 justify-content-cent");
            WriteLiteral(@"er"">
                            <div class=""text-muted text-small text-center  cursor-pointer sort"" data-sort=""phone"">DISCOUNT PERCENT</div>
                        </div>
                        <div class=""col-3 col-lg-2 d-flex flex-column pe-1 justify-content-center"">
                            <div class=""text-muted text-small text-center  cursor-pointer sort"" data-sort=""group"">ACTIONS</div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Items Container Start -->
");
#nullable restore
#line 52 "C:\Users\ELNUR\Desktop\Home Task 2\ProniaWeb\ProniaWeb\Areas\AdminPanel\Views\Slide\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card mb-2\">\r\n            <div class=\"row g-0 h-100 sh-lg-9 position-relative\">\r\n                <a href=\"Products.Detail.html\" class=\"col-auto position-relative h-100\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b78fa5659f171098ca0483a2536247c0fd592a9f10469", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2740, "~/assets/images/slider/inner-img/", 2740, 33, true);
#nullable restore
#line 57 "C:\Users\ELNUR\Desktop\Home Task 2\ProniaWeb\ProniaWeb\Areas\AdminPanel\Views\Slide\Index.cshtml"
AddHtmlAttributeValue("", 2773, item.Image, 2773, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </a>
                <div class=""col py-4 py-lg-0"">
                    <div class=""ps-5 pe-4 h-100"">
                        <div class=""row g-0 h-100 align-content-center"">
                            <div class=""col-12 col-lg-3 d-flex flex-column pe-1 mb-2 mb-lg-0 align-items-center  justify-content-center order-2"">
                                <div class=""lh-1 text-alternate"">");
#nullable restore
#line 63 "C:\Users\ELNUR\Desktop\Home Task 2\ProniaWeb\ProniaWeb\Areas\AdminPanel\Views\Slide\Index.cshtml"
                                                            Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            </div>
                            <div class=""col-12 col-lg-3 d-flex flex-column pe-1 mb-2 mb-lg-0 align-items-center  justify-content-center order-3"">
                                <div class=""lh-1 text-alternate"">");
#nullable restore
#line 66 "C:\Users\ELNUR\Desktop\Home Task 2\ProniaWeb\ProniaWeb\Areas\AdminPanel\Views\Slide\Index.cshtml"
                                                            Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            </div>
                            <div class=""col-12 col-lg-3 d-flex flex-column pe-1 mb-2 mb-lg-0 align-items-center  justify-content-center order-4"">
                                <div class=""lh-1 text-alternate"">");
#nullable restore
#line 69 "C:\Users\ELNUR\Desktop\Home Task 2\ProniaWeb\ProniaWeb\Areas\AdminPanel\Views\Slide\Index.cshtml"
                                                            Write(item.DiscountPercent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n                            <div class=\"col-12 col-lg-2 d-flex flex-row pe-1 mb-2 mb-lg-0 align-items-center justify-content-center order-5\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b78fa5659f171098ca0483a2536247c0fd592a9f14206", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\ELNUR\Desktop\Home Task 2\ProniaWeb\ProniaWeb\Areas\AdminPanel\Views\Slide\Index.cshtml"
                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <span type=\"button\" class=\"btn btn-outline-danger\" data-bs-toggle=\"modal\" data-bs-target=\"#deleteModal\" data-id=\"");
#nullable restore
#line 73 "C:\Users\ELNUR\Desktop\Home Task 2\ProniaWeb\ProniaWeb\Areas\AdminPanel\Views\Slide\Index.cshtml"
                                                                                                                                            Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" >Delete</span>  \r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 80 "C:\Users\ELNUR\Desktop\Home Task 2\ProniaWeb\ProniaWeb\Areas\AdminPanel\Views\Slide\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <!-- Items Container Start -->\r\n    <!-- List Items End -->\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM"" crossorigin=""anonymous""></script>
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
<script>
    let url = $(""#DeleteForm form"").attr(""action"")
     $(""span[type='button']"").click(function(){
         console.log(typeof $(this).attr(""data-id""))
         $(""#DeleteForm form"").attr(""action"", url + ""/"" + $(this).attr(""data-id""))
     })
</script>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Slider>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591