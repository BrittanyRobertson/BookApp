#pragma checksum "/Users/brittany/Documents/GitHub/BookApp/Pages/Admin/Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f2b016d5051370f2cf2ee4c83a74f4f2807f0ee"
// <auto-generated/>
#pragma warning disable 1591
namespace BookApp.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/brittany/Documents/GitHub/BookApp/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/brittany/Documents/GitHub/BookApp/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/brittany/Documents/GitHub/BookApp/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/brittany/Documents/GitHub/BookApp/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/brittany/Documents/GitHub/BookApp/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/brittany/Documents/GitHub/BookApp/Pages/Admin/_Imports.razor"
using BookApp.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin//books/details/{id:long}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"bg-info text-white text-center p-1\">Details</h3>\n\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-sm table-bordered table-striped");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "tr");
            __builder.AddMarkupContent(5, "<th>Book Id:</th>");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, 
#nullable restore
#line 6 "/Users/brittany/Documents/GitHub/BookApp/Pages/Admin/Details.razor"
                              b.BookId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n    ");
            __builder.OpenElement(9, "tr");
            __builder.AddMarkupContent(10, "<th>Title:</th>");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 7 "/Users/brittany/Documents/GitHub/BookApp/Pages/Admin/Details.razor"
                            b.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n    ");
            __builder.OpenElement(14, "tr");
            __builder.AddMarkupContent(15, "<th>Author:</th>");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 8 "/Users/brittany/Documents/GitHub/BookApp/Pages/Admin/Details.razor"
                             b.Author

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n    ");
            __builder.OpenElement(19, "tr");
            __builder.AddMarkupContent(20, "<th>Publisher:</th>");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 9 "/Users/brittany/Documents/GitHub/BookApp/Pages/Admin/Details.razor"
                                b.Publisher

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n    ");
            __builder.OpenElement(24, "tr");
            __builder.AddMarkupContent(25, "<th>ISBN:</th>");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 10 "/Users/brittany/Documents/GitHub/BookApp/Pages/Admin/Details.razor"
                           b.Isbn

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n    ");
            __builder.OpenElement(29, "tr");
            __builder.AddMarkupContent(30, "<th>Classification:</th>");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 11 "/Users/brittany/Documents/GitHub/BookApp/Pages/Admin/Details.razor"
                                     b.Classification

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n    ");
            __builder.OpenElement(34, "tr");
            __builder.AddMarkupContent(35, "<th>Category:</th>");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 12 "/Users/brittany/Documents/GitHub/BookApp/Pages/Admin/Details.razor"
                               b.Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n    ");
            __builder.OpenElement(39, "tr");
            __builder.AddMarkupContent(40, "<th>Page Count:</th>");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 13 "/Users/brittany/Documents/GitHub/BookApp/Pages/Admin/Details.razor"
                                 b.PageCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n    ");
            __builder.OpenElement(44, "tr");
            __builder.AddMarkupContent(45, "<th>Price:</th>");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 14 "/Users/brittany/Documents/GitHub/BookApp/Pages/Admin/Details.razor"
                            b.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "/Users/brittany/Documents/GitHub/BookApp/Pages/Admin/Details.razor"
       
    [Inject]
    public IBookstoreRepository repo { get; set; }

    public long id { get; set; }

    public Book b { get; set; }

    protected override void OnParametersSet()
    {
        b = repo.Books.FirstOrDefault(x => x.BookId == id);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
