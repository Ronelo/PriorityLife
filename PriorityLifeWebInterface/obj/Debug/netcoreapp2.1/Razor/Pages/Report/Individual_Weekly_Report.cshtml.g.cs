#pragma checksum "C:\Users\Administrator\Documents\Projects\PriorityLife\PriorityLifeWebInterface\Pages\Report\Individual_Weekly_Report.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "964d26469ad490d596b2b207fe960bff2c3910fca8a01edf4c657aaed7fc766d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PriorityLifeWebInterface.Pages.Report.Pages_Report_Individual_Weekly_Report), @"mvc.1.0.razor-page", @"/Pages/Report/Individual_Weekly_Report.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Report/Individual_Weekly_Report.cshtml", typeof(PriorityLifeWebInterface.Pages.Report.Pages_Report_Individual_Weekly_Report), null)]
namespace PriorityLifeWebInterface.Pages.Report
{
    #line default
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Administrator\Documents\Projects\PriorityLife\PriorityLifeWebInterface\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity

    ;
#line 2 "C:\Users\Administrator\Documents\Projects\PriorityLife\PriorityLifeWebInterface\Pages\_ViewImports.cshtml"
using PriorityLifeWebInterface

    ;
#line 3 "C:\Users\Administrator\Documents\Projects\PriorityLife\PriorityLifeWebInterface\Pages\_ViewImports.cshtml"
using PriorityLifeWebInterface.Data

#line default
#line hidden
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"964d26469ad490d596b2b207fe960bff2c3910fca8a01edf4c657aaed7fc766d", @"/Pages/Report/Individual_Weekly_Report.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"234d2f96be75839c4fb9208c629e6237b0de9a8e836147661096b49a0ac5625f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Report_Individual_Weekly_Report : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ui.jqgrid.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/jqgrid-i18n/grid.locale-en.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/jquery-jqgrid-4.13.2.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/jqgrid-listcrudredirect.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Report/Individual_Daily_Report", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: gold"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Report/Individual_Weekly_Report", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Report/Individual_MTD_Report", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Report/Individual_YTD_Report", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Report/Individual_Advance_Report", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "CreateDocument", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Administrator\Documents\Projects\PriorityLife\PriorityLifeWebInterface\Pages\Report\Individual_Weekly_Report.cshtml"
  
    ViewData["Title"] = "Individual IP Weekly Report";

#line default
#line hidden

            BeginContext(146, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("AdditionalCss", async() => {
                BeginContext(172, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(178, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "964d26469ad490d596b2b207fe960bff2c3910fca8a01edf4c657aaed7fc766d9064", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(234, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(239, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("AdditionalJavaScript", async() => {
                BeginContext(272, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(278, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "964d26469ad490d596b2b207fe960bff2c3910fca8a01edf4c657aaed7fc766d10733", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = 
#line 12 "C:\Users\Administrator\Documents\Projects\PriorityLife\PriorityLifeWebInterface\Pages\Report\Individual_Weekly_Report.cshtml"
                                                                             true

#line default
#line hidden
                ;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(366, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(372, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "964d26469ad490d596b2b207fe960bff2c3910fca8a01edf4c657aaed7fc766d12990", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = 
#line 13 "C:\Users\Administrator\Documents\Projects\PriorityLife\PriorityLifeWebInterface\Pages\Report\Individual_Weekly_Report.cshtml"
                                                                       true

#line default
#line hidden
                ;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(454, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(460, 81, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "964d26469ad490d596b2b207fe960bff2c3910fca8a01edf4c657aaed7fc766d15241", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = 
#line 14 "C:\Users\Administrator\Documents\Projects\PriorityLife\PriorityLifeWebInterface\Pages\Report\Individual_Weekly_Report.cshtml"
                                                                      true

#line default
#line hidden
                ;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(541, 4016, true);
                WriteLiteral(@"

    <script type=""text/javascript"">
        var urlAndMethod = '/Report/Individual_Weekly_Report';

        $(function () {
            $('#list-grid').jqGrid({
                url: '/Report/Individual_Weekly_Report?handler=GridData',
                datatype: 'json',
                mtype: 'GET',
                colNames: ['Rank', 'WritingAgent', 'Amount', 'Upline1', 'Upline2', 'Upline3', 'Upline4', 'Upline5', 'Upline6', 'Upline7', 'Upline8', 'Upline9', 'Upline10', 'AIG', 'AMERICO', 'MOO', 'GLOBAL', 'ROYAL', 'TRANS', 'ATHENE', 'AMAM', 'PROSPERITY', 'REAL SHIELD'],
                colModel: [
                    { name: 'Num', index: 'Num', align: 'right', width: 100 },
                    { name: 'WritingAgent', index: 'WritingAgent', align: 'left' },
                    { name: 'Amount', index: 'Amount', align: 'right', formatter: 'currency', formatoptions: { decimalPlaces: 2, prefix: ""$"" } },
                    { name: 'Upline1', index: 'Upline1', align: 'left' },
                    { n");
                WriteLiteral(@"ame: 'Upline2', index: 'Upline2', align: 'left' },
                    { name: 'Upline3', index: 'Upline3', align: 'left' },
                    { name: 'Upline4', index: 'Upline4', align: 'left' },
                    { name: 'Upline5', index: 'Upline5', align: 'left' },
                    { name: 'Upline6', index: 'Upline6', align: 'left' },
                    { name: 'Upline7', index: 'Upline7', align: 'left' },
                    { name: 'Upline8', index: 'Upline8', align: 'left' },
                    { name: 'Upline9', index: 'Upline9', align: 'left' },
                    { name: 'Upline10', index: 'Upline10', align: 'left' },
                    { name: 'AIG', index: 'AIG', align: 'right', formatter: 'currency', formatoptions: { decimalPlaces: 2, prefix: ""$"" } },
                    { name: 'AMERICO', index: 'AMERICO', align: 'right', formatter: 'currency', formatoptions: { decimalPlaces: 2, prefix: ""$"" } },
                    { name: 'MOO', index: 'MOO', align: 'right', formatter: 'cur");
                WriteLiteral(@"rency', formatoptions: { decimalPlaces: 2, prefix: ""$"" } },
                    { name: 'GLOBAL', index: 'GLOBAL', align: 'right', formatter: 'currency', formatoptions: { decimalPlaces: 2, prefix: ""$"" } },
                    { name: 'ROYAL', index: 'ROYAL', align: 'right', formatter: 'currency', formatoptions: { decimalPlaces: 2, prefix: ""$"" } },
                    { name: 'TRANS', index: 'TRANS', align: 'right', formatter: 'currency', formatoptions: { decimalPlaces: 2, prefix: ""$"" } },
                    { name: 'ATHENE', index: 'ATHENE', align: 'right', formatter: 'currency', formatoptions: { decimalPlaces: 2, prefix: ""$"" } },
                    { name: 'AMAM', index: 'AMAM', align: 'right', formatter: 'currency', formatoptions: { decimalPlaces: 2, prefix: ""$"" } },
                    { name: 'PROSPERITY', index: 'PROSPERITY', align: 'right', formatter: 'currency', formatoptions: { decimalPlaces: 2, prefix: ""$"" } },
                    { name: 'RSHIELD', index: 'RSHIELD', align: 'right', formatte");
                WriteLiteral(@"r: 'currency', formatoptions: { decimalPlaces: 2, prefix: ""$"" } }
                ],
                pager: $('#list-pager'),
                rowNum: 10,
                pageable: true,
                jsonReader:
                {
                    page: ""d.page""
                },
                rowList: [5, 10, 20, 50],
                sortname: 'Id',
                sortorder: ""asc"",
                viewrecords: true,
                caption: 'Individual Reports',
                height: '100%',
                width: '1400',
                gridComplete: function () {

                }
            });
        });

        // rename the page parameter to _page because asp.net core razor's page model
        // does not recognize the page parameter when passed
        $.extend(jQuery.jgrid.defaults, {
            prmNames: {
                page: ""_page""
            }
        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(4560, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(4567, 17, false);
            Write(
#line 80 "C:\Users\Administrator\Documents\Projects\PriorityLife\PriorityLifeWebInterface\Pages\Report\Individual_Weekly_Report.cshtml"
     ViewData["Title"]

#line default
#line hidden
            );
            EndContext();
            BeginContext(4584, 168, true);
            WriteLiteral("</h2>\r\n<br />\r\n<br />\r\n<div id=\"errorConfirmationDialog\"></div>\r\n<div id=\"errorDialog\"></div>\r\n\r\n<div>\r\n    <ul class=\"nav\">\r\n        <li style=\"display: inline-block\">");
            EndContext();
            BeginContext(4752, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "964d26469ad490d596b2b207fe960bff2c3910fca8a01edf4c657aaed7fc766d22366", async() => {
                BeginContext(4798, 5, true);
                WriteLiteral("Daily");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4807, 49, true);
            WriteLiteral("</li>\r\n        <li style=\"display: inline-block\">");
            EndContext();
            BeginContext(4856, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "964d26469ad490d596b2b207fe960bff2c3910fca8a01edf4c657aaed7fc766d23810", async() => {
                BeginContext(4934, 6, true);
                WriteLiteral("Weekly");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4944, 49, true);
            WriteLiteral("</li>\r\n        <li style=\"display: inline-block\">");
            EndContext();
            BeginContext(4993, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "964d26469ad490d596b2b207fe960bff2c3910fca8a01edf4c657aaed7fc766d25338", async() => {
                BeginContext(5037, 3, true);
                WriteLiteral("MTD");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5044, 49, true);
            WriteLiteral("</li>\r\n        <li style=\"display: inline-block\">");
            EndContext();
            BeginContext(5093, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "964d26469ad490d596b2b207fe960bff2c3910fca8a01edf4c657aaed7fc766d26780", async() => {
                BeginContext(5137, 3, true);
                WriteLiteral("YTD");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5144, 49, true);
            WriteLiteral("</li>\r\n        <li style=\"display: inline-block\">");
            EndContext();
            BeginContext(5193, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "964d26469ad490d596b2b207fe960bff2c3910fca8a01edf4c657aaed7fc766d28222", async() => {
                BeginContext(5241, 11, true);
                WriteLiteral("Search Date");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5256, 136, true);
            WriteLiteral("</li>\r\n    </ul>\r\n</div>\r\n<br />\r\n<br />\r\n\r\n<table id=\"list-grid\"></table>\r\n<div id=\"list-pager\"></div>\r\n\r\n<br />\r\n<br />\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(5392, 232, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "964d26469ad490d596b2b207fe960bff2c3910fca8a01edf4c657aaed7fc766d29790", async() => {
                BeginContext(5490, 127, true);
                WriteLiteral("\r\n        <div>\r\n            <input type=\"submit\" value=\"EXPORT EXCEL\" style=\"width:150px;height:27px\" />\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5624, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PriorityLifeWebInterface.Pages.Report.Individual_Weekly_ReportModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PriorityLifeWebInterface.Pages.Report.Individual_Weekly_ReportModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PriorityLifeWebInterface.Pages.Report.Individual_Weekly_ReportModel>)PageContext?.ViewData;
        public PriorityLifeWebInterface.Pages.Report.Individual_Weekly_ReportModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
