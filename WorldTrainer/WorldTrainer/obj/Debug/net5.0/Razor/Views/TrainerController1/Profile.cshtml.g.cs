#pragma checksum "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10d75ad5948332389c335d1bdb889a111cbae306"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TrainerController1_Profile), @"mvc.1.0.view", @"/Views/TrainerController1/Profile.cshtml")]
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
#line 1 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\_ViewImports.cshtml"
using WorldTrainer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\_ViewImports.cshtml"
using WorldTrainer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10d75ad5948332389c335d1bdb889a111cbae306", @"/Views/TrainerController1/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6503a8b6dd1d3d108e4840c4c085331f0c8f13de", @"/Views/_ViewImports.cshtml")]
    public class Views_TrainerController1_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WorldTrainer.Models.TrainerModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TrainerController1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditExp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditQua", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditSkill", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
  
    ViewData["Title"] = "Profile";
    var total = ViewBag.Exp.Count;
    var total1 = ViewBag.Qualification.Count;
    var total2 = ViewBag.Skill.Count;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Profile</h1>\r\n\r\n<div>\r\n    <h4>TrainerModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 17 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
       Write(Html.DisplayNameFor(model => model.TrainerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 20 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
       Write(Html.DisplayFor(model => model.TrainerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
       Write(Html.DisplayNameFor(model => model.TrainerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
       Write(Html.DisplayFor(model => model.TrainerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
       Write(Html.DisplayNameFor(model => model.TrainerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
       Write(Html.DisplayFor(model => model.TrainerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
       Write(Html.DisplayNameFor(model => model.TrainerPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
       Write(Html.DisplayFor(model => model.TrainerPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 41 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
       Write(Html.DisplayNameFor(model => model.TrainerAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 44 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
       Write(Html.DisplayFor(model => model.TrainerAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 48 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 51 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 56 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" |
</div>
<h2 style=""text-align:center"">Experinces</h2>
<table class=""table"">
    <thead>
        <tr>

            <th>ExperienceTechnology</th>
            <th>ExperienceDuration</th>
            <th>ExperiencePosition</th>
            <th>ExperienceLocation</th>
            <th>Edit</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 71 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
         for (int i = 0; i < total; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n            <th scope=\"row\" id=\"book_ids\">");
#nullable restore
#line 75 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
                                     Write(ViewBag.Exp[i].ExperienceTechnology);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th scope=\"row\">");
#nullable restore
#line 76 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
                       Write(ViewBag.Exp[i].ExperienceDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 77 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
           Write(ViewBag.Exp[i].ExperiencePosition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 78 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
           Write(ViewBag.Exp[i].ExperienceLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10d75ad5948332389c335d1bdb889a111cbae30611074", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
                                                                              WriteLiteral(ViewBag.Exp[i].ExperienceId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </td>\r\n        </tr>\r\n");
#nullable restore
#line 81 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n    ");
#nullable restore
#line 85 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
Write(Html.ActionLink("Add your Experience", "AddExp", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" 
</div>
<h2 style=""text-align:center"">Qualification Details</h2>
<table class=""table"">
    <thead>
        <tr>

            <th>High School Grade</th>
            <th>Jr college Grade</th>
            <th>Graduated Grade</th>
            <th>Extra Certifications</th>
            <th>Edit</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 100 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
         for (int i = 0; i < total1; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n            <th scope=\"row\">");
#nullable restore
#line 104 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
                       Write(ViewBag.Qualification[i].HighSchoolGrade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th scope=\"row\">");
#nullable restore
#line 105 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
                       Write(ViewBag.Qualification[i].JrcollegeGrade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 106 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
           Write(ViewBag.Qualification[i].GraduatedIn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 107 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
           Write(ViewBag.Qualification[i].ExtraCertifications);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10d75ad5948332389c335d1bdb889a111cbae30615950", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
                                                                              WriteLiteral(ViewBag.Qualification[i].QualificationId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </td>\r\n        </tr>\r\n");
#nullable restore
#line 110 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n    ");
#nullable restore
#line 114 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
Write(Html.ActionLink("Add your Qualification", "AddQua", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n</div>\r\n<h2 style=\"text-align:center\">Your Skills</h2>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n\r\n            <th>Sr.No</th>\r\n            <th>TechSkill_1</th>\r\n            <th>Edit</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 127 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
         for (int i = 0; i < total2; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n            <th scope=\"row\" id=\"book_ids\">");
#nullable restore
#line 131 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
                                     Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th scope=\"row\">");
#nullable restore
#line 132 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
                       Write(ViewBag.Skill[i].TechSkill_1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10d75ad5948332389c335d1bdb889a111cbae30620158", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 133 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
                                                                                WriteLiteral(ViewBag.Skill[i].SkillId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</th>\r\n        </tr>\r\n");
#nullable restore
#line 135 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n    ");
#nullable restore
#line 139 "C:\Users\X270\source\repos\WorldTrainer\WorldTrainer\Views\TrainerController1\Profile.cshtml"
Write(Html.ActionLink("Add your skills", "AddSkill", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WorldTrainer.Models.TrainerModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
