#pragma checksum "C:\Users\gomes\Documents\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acdacb8d57baa4de5bee15af01364c95d4a404c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Emprestimo_Listagem), @"mvc.1.0.view", @"/Views/Emprestimo/Listagem.cshtml")]
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
#line 1 "C:\Users\gomes\Documents\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gomes\Documents\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\gomes\Documents\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acdacb8d57baa4de5bee15af01364c95d4a404c8", @"/Views/Emprestimo/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Emprestimo_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<Emprestimo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "5000", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "5", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "15", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "20", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "50", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "70", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "100", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Usuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Livro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/book.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\gomes\Documents\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
  
    ViewData["Title"] = "Listagem de Empr??stimos";
    if(string.Compare(Context.Session.GetString("user"),"admin")==0){
        Layout = "_AdminLayout";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
.pagination {
  display: inline-block;
}
ul {
    list-style-type: none;

}
.alert{
    color: yellow;
}

.normal{
    color: green;
}

.pagination li {
  color: black;
  float: left;
  padding: 8px 16px;
  text-decoration: none;
  transition: background-color .3s;
  border: 1px solid #ddd;
  margin: 0 4px;
  cursor: pointer;
}

.pagination li.active {
  background-color:  red;
  color: white;
  border: 1px solid red;
}

.pagination li:hover:not(.active) {background-color: #ddd;}
</style>
<div class=""container"">
		<center><h2>Escolha o n??mero de linhas</h2></center>
				<div class=""form-group""> 	<!--		Show Numbers Of Rows 		-->
			 		<select class  =""form-control"" name=""state"" id=""maxRows"">
						 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acdacb8d57baa4de5bee15af01364c95d4a404c88866", async() => {
                WriteLiteral("Mostra todas as linhas");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acdacb8d57baa4de5bee15af01364c95d4a404c810054", async() => {
                WriteLiteral("5");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acdacb8d57baa4de5bee15af01364c95d4a404c811234", async() => {
                WriteLiteral("10");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acdacb8d57baa4de5bee15af01364c95d4a404c812403", async() => {
                WriteLiteral("15");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acdacb8d57baa4de5bee15af01364c95d4a404c813572", async() => {
                WriteLiteral("20");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acdacb8d57baa4de5bee15af01364c95d4a404c814741", async() => {
                WriteLiteral("50");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acdacb8d57baa4de5bee15af01364c95d4a404c815910", async() => {
                WriteLiteral("70");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acdacb8d57baa4de5bee15af01364c95d4a404c817079", async() => {
                WriteLiteral("100");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t</select>\r\n\t\t\t \t\t\r\n\t\t\t  \t</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acdacb8d57baa4de5bee15af01364c95d4a404c818356", async() => {
                WriteLiteral("\r\n        <div class=\"form-group mb-2\">\r\n            <select name=\"TipoFiltro\" class=\"form-control\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acdacb8d57baa4de5bee15af01364c95d4a404c818741", async() => {
                    WriteLiteral("Usu??rio");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acdacb8d57baa4de5bee15af01364c95d4a404c819982", async() => {
                    WriteLiteral("Livro");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </select>
        </div>
        <div class=""form-group mb-2 mx-sm-3"">
            <input type=""text"" placeholder=""Filtro"" name=""Filtro"" class=""form-control"" />
        </div>
        <button type=""submit"" class=""btn btn-primary mb-2"">Pesquisar</button>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
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

<div class=""row"">
    <div class=""col-md-12"">
        <table id=""Livro"" class=""table table-striped""> 
            <thead>
                <tr><th>Id</th>
                <th>Usuario</th>
                <th>Data Empr??stimo</th>
                <th>Data Devolu????o</th>
                <th>Livro</th>
                <th>Autor</th>
                <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 90 "C:\Users\gomes\Documents\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                 if(Model.Count > 0)
                {
                    var dateTime = DateTime.Now;
                    var date = dateTime.Date;
                    foreach(Emprestimo e in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    \r\n                    <td>");
#nullable restore
#line 97 "C:\Users\gomes\Documents\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                   Write(e.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 98 "C:\Users\gomes\Documents\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                   Write(e.NomeUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 99 "C:\Users\gomes\Documents\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                   Write(e.DataEmprestimo.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 100 "C:\Users\gomes\Documents\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                     if(DateTime.Compare(@e.DataDevolucao,date)<0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><p class=\"text-danger\">");
#nullable restore
#line 101 "C:\Users\gomes\Documents\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                          Write(e.DataDevolucao.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>");
#nullable restore
#line 101 "C:\Users\gomes\Documents\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                                                                               }

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Users\gomes\Documents\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                     if(DateTime.Compare(@e.DataDevolucao,date)==0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><p class=\"alert\">");
#nullable restore
#line 103 "C:\Users\gomes\Documents\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                    Write(e.DataDevolucao.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>");
#nullable restore
#line 103 "C:\Users\gomes\Documents\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                                                                         }

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "C:\Users\gomes\Documents\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                      if(DateTime.Compare(@e.DataDevolucao,date)>0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><p class=\"normal\">");
#nullable restore
#line 105 "C:\Users\gomes\Documents\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                     Write(e.DataDevolucao.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>");
#nullable restore
#line 105 "C:\Users\gomes\Documents\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                                                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 106 "C:\Users\gomes\Documents\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                   Write(e.Livro.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 107 "C:\Users\gomes\Documents\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                   Write(e.Livro.Autor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 3433, "\"", 3464, 2);
            WriteAttributeValue("", 3440, "/Emprestimo/Edicao/", 3440, 19, true);
#nullable restore
#line 108 "C:\Users\gomes\Documents\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 3459, e.Id, 3459, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 110 "C:\Users\gomes\Documents\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                }}

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 115 "C:\Users\gomes\Documents\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
 if(Model.Count==0){
   

#line default
#line hidden
#nullable disable
            WriteLiteral("     <center><h2 class=\"text-danger\">Nenhum registro encontrado</h2></center> \r\n     <br>\r\n     <center>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "acdacb8d57baa4de5bee15af01364c95d4a404c829141", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</center> \r\n");
#nullable restore
#line 120 "C:\Users\gomes\Documents\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--		Start Pagination -->
<div class='pagination' >
				<nav>
				  <ul>
            
            <li data-page=""prev"" >
								     <span> < <span class=""sr-only"">(current)</span></span>
								    </li>
				   <!--	Here the JS Function Will Add the Rows -->
        <li data-page=""next"" id=""prev"">
								       <span> > <span class=""sr-only"">(current)</span></span>
								    </li>
				  </ul>
				</nav>
			</div>

</div> 


   

<script>
 getPagination('#Livro');
					//getPagination('.table-class');
					//getPagination('table');

		  /*					PAGINATION 
		  - on change max rows select options fade out all rows gt option value mx = 5
		  - append pagination list as per numbers of rows / max rows option (20row/5= 4pages )
		  - each pagination li on click -> fade out all tr gt max rows * li num and (5*pagenum 2 = 10 rows)
		  - fade out all tr lt max rows * li num - max rows ((5*pagenum 2 = 10) - 5)
		  - fade in all tr between (maxRows*PageNum) and (maxRows*pageNum)- Ma");
            WriteLiteral(@"xRows 
		  */
		 

function getPagination(table) {
  var lastPage = 1;

  $('#maxRows')
    .on('change', function(evt) {
      //$('.paginationprev').html('');						// reset pagination

     lastPage = 1;
      $('.pagination')
        .find('li')
        .slice(1, -1)
        .remove();
      var trnum = 0; // reset tr counter
      var maxRows = parseInt($(this).val()); // get Max Rows from select option

      if (maxRows == 5000) {
        $('.pagination').hide();
      } else {
        $('.pagination').show();
      }

      var totalRows = $(table + ' tbody tr').length; // numbers of rows
      $(table + ' tr:gt(0)').each(function() {
        // each TR in  table and not the header
        trnum++; // Start Counter
        if (trnum > maxRows) {
          // if tr number gt maxRows

          $(this).hide(); // fade it out
        }
        if (trnum <= maxRows) {
          $(this).show();
        } // else fade in Important in case if it ..
      }); //  was fade o");
            WriteLiteral(@"ut to fade it in
      if (totalRows > maxRows) {
        // if tr total rows gt max rows option
        var pagenum = Math.ceil(totalRows / maxRows); // ceil total(rows/maxrows) to get ..
        //	numbers of pages
        for (var i = 1; i <= pagenum; ) {
          // for each page append pagination li
          $('.pagination #prev')
            .before(
              '<li data-page=""' +
                i +
                '"">\
								  <span>' +
                i++ +
                '<span class=""sr-only"">(current)</span></span>\
								</li>'
            )
            .show();
        } // end for i
      } // end if row count > max rows
      $('.pagination [data-page=""1""]').addClass('active'); // add active class to the first li
      $('.pagination li').on('click', function(evt) {
        // on click each page
        evt.stopImmediatePropagation();
        evt.preventDefault();
        var pageNum = $(this).attr('data-page'); // get it's number

        var maxRows = par");
            WriteLiteral(@"seInt($('#maxRows').val()); // get Max Rows from select option

        if (pageNum == 'prev') {
          if (lastPage == 1) {
            return;
          }
          pageNum = --lastPage;
        }
        if (pageNum == 'next') {
          if (lastPage == $('.pagination li').length - 2) {
            return;
          }
          pageNum = ++lastPage;
        }

        lastPage = pageNum;
        var trIndex = 0; // reset tr counter
        $('.pagination li').removeClass('active'); // remove active class from all li
        $('.pagination [data-page=""' + lastPage + '""]').addClass('active'); // add active class to the clicked
        // $(this).addClass('active');					// add active class to the clicked
	  	limitPagging();
        $(table + ' tr:gt(0)').each(function() {
          // each tr in table not the header
          trIndex++; // tr index counter
          // if tr index gt maxRows*pageNum or lt maxRows*pageNum-maxRows fade if out
          if (
            trIndex > ma");
            WriteLiteral(@"xRows * pageNum ||
            trIndex <= maxRows * pageNum - maxRows
          ) {
            $(this).hide();
          } else {
            $(this).show();
          } //else fade in
        }); // end of for each tr in table
      }); // end of on click pagination list
	  limitPagging();
    })
    .val(10)
    .change();

  // end of on select change

  // END OF PAGINATION
}

function limitPagging(){
	// alert($('.pagination li').length)

	if($('.pagination li').length > 7 ){
			if( $('.pagination li.active').attr('data-page') <= 3 ){
			$('.pagination li:gt(5)').hide();
			$('.pagination li:lt(5)').show();
			$('.pagination [data-page=""next""]').show();
		}if ($('.pagination li.active').attr('data-page') > 3){
			$('.pagination li:gt(0)').hide();
			$('.pagination [data-page=""next""]').show();
			for( let i = ( parseInt($('.pagination li.active').attr('data-page'))  -2 )  ; i <= ( parseInt($('.pagination li.active').attr('data-page'))  + 2 ) ; i++ ){
				$('.pagination [dat");
            WriteLiteral(@"a-page=""'+i+'""]').show();

			}

		}
	}
}

$(function() {
  // Just to append id number for each row
  $('table tr:eq(0)').prepend('<th> ID </th>');

  var id = 0;

  $('table tr:gt(0)').each(function() {
    id++;
    $(this).prepend('<td>' + id + '</td>');
  });
});

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<Emprestimo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
