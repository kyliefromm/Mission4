#pragma checksum "/Users/kyliefromm/Documents/GitHub/Mission4/MovieCollection/Views/Home/Confirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94cfcccb89311ac9727f13d62f6f9b9f5f813b3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Confirmation), @"mvc.1.0.view", @"/Views/Home/Confirmation.cshtml")]
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
#line 1 "/Users/kyliefromm/Documents/GitHub/Mission4/MovieCollection/Views/_ViewImports.cshtml"
using MovieCollection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/kyliefromm/Documents/GitHub/Mission4/MovieCollection/Views/_ViewImports.cshtml"
using MovieCollection.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94cfcccb89311ac9727f13d62f6f9b9f5f813b3b", @"/Views/Home/Confirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4193ac9fc819843aae276788a0fb0c9029300161", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Confirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieCollection.Models.MovieForm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/kyliefromm/Documents/GitHub/Mission4/MovieCollection/Views/Home/Confirmation.cshtml"
  
    ViewData["Title"] = "Movie Submitted";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n\n    <h2>Movie has been added to the Database. Thank you!</h2>\n   \n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieCollection.Models.MovieForm> Html { get; private set; }
    }
}
#pragma warning restore 1591
