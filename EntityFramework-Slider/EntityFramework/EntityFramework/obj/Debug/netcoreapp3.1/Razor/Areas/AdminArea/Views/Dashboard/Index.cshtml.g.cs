#pragma checksum "C:\Users\Sadiq\Desktop\ASP.NET\OneToMany\EntityFramework-Slider\EntityFramework\EntityFramework\Areas\AdminArea\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97d3ee939421aaa1305625af60e4ac56081c481d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminArea_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/AdminArea/Views/Dashboard/Index.cshtml")]
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
#line 1 "C:\Users\Sadiq\Desktop\ASP.NET\OneToMany\EntityFramework-Slider\EntityFramework\EntityFramework\Areas\AdminArea\Views\_ViewImports.cshtml"
using EntityFramework.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97d3ee939421aaa1305625af60e4ac56081c481d", @"/Areas/AdminArea/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74263f33dc55cdb524049bdafcb28678893c6d2b", @"/Areas/AdminArea/Views/_ViewImports.cshtml")]
    public class Areas_AdminArea_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Sadiq\Desktop\ASP.NET\OneToMany\EntityFramework-Slider\EntityFramework\EntityFramework\Areas\AdminArea\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-panel"">
    <h2>Admin dashboard</h2>
</div>



<!-- partial -->
<!--<div class=""main-panel"">
    <div class=""content-wrapper"">
        <div class=""row"">
            <div class=""col-md-12 grid-margin"">
                <div class=""d-flex justify-content-between flex-wrap"">
                    <div class=""d-flex align-items-end flex-wrap"">
                        <div class=""mr-md-3 mr-xl-5"">
                            <h2>Welcome back,</h2>
                            <p class=""mb-md-0"">Your analytics dashboard template.</p>
                        </div>
                        <div class=""d-flex"">
                            <i class=""mdi mdi-home text-muted hover-cursor""></i>
                            <p class=""text-muted mb-0 hover-cursor"">&nbsp;/&nbsp;Dashboard&nbsp;/&nbsp;</p>
                            <p class=""text-primary mb-0 hover-cursor"">Analytics</p>
                        </div>
                    </div>
                    <div class=""d-flex justif");
            WriteLiteral(@"y-content-between align-items-end flex-wrap"">
                        <button type=""button"" class=""btn btn-light bg-white btn-icon mr-3 d-none d-md-block "">
                            <i class=""mdi mdi-download text-muted""></i>
                        </button>
                        <button type=""button"" class=""btn btn-light bg-white btn-icon mr-3 mt-2 mt-xl-0"">
                            <i class=""mdi mdi-clock-outline text-muted""></i>
                        </button>
                        <button type=""button"" class=""btn btn-light bg-white btn-icon mr-3 mt-2 mt-xl-0"">
                            <i class=""mdi mdi-plus text-muted""></i>
                        </button>
                        <button class=""btn btn-primary mt-2 mt-xl-0"">Download report</button>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12 grid-margin stretch-card"">
                <div class=""card"">
                    ");
            WriteLiteral(@"<div class=""card-body dashboard-tabs p-0"">
                        <ul class=""nav nav-tabs px-4"" role=""tablist"">
                            <li class=""nav-item"">
                                <a class=""nav-link active"" id=""overview-tab"" data-toggle=""tab"" href=""#overview"" role=""tab"" aria-controls=""overview"" aria-selected=""true"">Overview</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" id=""sales-tab"" data-toggle=""tab"" href=""#sales"" role=""tab"" aria-controls=""sales"" aria-selected=""false"">Sales</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" id=""purchases-tab"" data-toggle=""tab"" href=""#purchases"" role=""tab"" aria-controls=""purchases"" aria-selected=""false"">Purchases</a>
                            </li>
                        </ul>
                        <div class=""tab-content py-0 px-0"">
                            <d");
            WriteLiteral(@"iv class=""tab-pane fade show active"" id=""overview"" role=""tabpanel"" aria-labelledby=""overview-tab"">
                                <div class=""d-flex flex-wrap justify-content-xl-between"">
                                    <div class=""d-none d-xl-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                        <i class=""mdi mdi-calendar-heart icon-lg mr-3 text-primary""></i>
                                        <div class=""d-flex flex-column justify-content-around"">
                                            <small class=""mb-1 text-muted"">Start date</small>
                                            <div class=""dropdown"">
                                                <a class=""btn btn-secondary dropdown-toggle p-0 bg-transparent border-0 text-dark shadow-none font-weight-medium"" href=""#"" role=""button"" id=""dropdownMenuLinkA"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                            ");
            WriteLiteral(@"        <h5 class=""mb-0 d-inline-block"">26 Jul 2018</h5>
                                                </a>
                                                <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuLinkA"">
                                                    <a class=""dropdown-item"" href=""#"">12 Aug 2018</a>
                                                    <a class=""dropdown-item"" href=""#"">22 Sep 2018</a>
                                                    <a class=""dropdown-item"" href=""#"">21 Oct 2018</a>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""d-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                        <i class=""mdi mdi-currency-usd mr-3 icon-lg text-danger""></i>
                                        <div class");
            WriteLiteral(@"=""d-flex flex-column justify-content-around"">
                                            <small class=""mb-1 text-muted"">Revenue</small>
                                            <h5 class=""mr-2 mb-0"">$577545</h5>
                                        </div>
                                    </div>
                                    <div class=""d-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                        <i class=""mdi mdi-eye mr-3 icon-lg text-success""></i>
                                        <div class=""d-flex flex-column justify-content-around"">
                                            <small class=""mb-1 text-muted"">Total views</small>
                                            <h5 class=""mr-2 mb-0"">9833550</h5>
                                        </div>
                                    </div>
                                    <div class=""d-flex border-md-right flex-grow-1 align-items-center justify-conten");
            WriteLiteral(@"t-center p-3 item"">
                                        <i class=""mdi mdi-download mr-3 icon-lg text-warning""></i>
                                        <div class=""d-flex flex-column justify-content-around"">
                                            <small class=""mb-1 text-muted"">Downloads</small>
                                            <h5 class=""mr-2 mb-0"">2233783</h5>
                                        </div>
                                    </div>
                                    <div class=""d-flex py-3 border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                        <i class=""mdi mdi-flag mr-3 icon-lg text-danger""></i>
                                        <div class=""d-flex flex-column justify-content-around"">
                                            <small class=""mb-1 text-muted"">Flagged</small>
                                            <h5 class=""mr-2 mb-0"">3497843</h5>
                                  ");
            WriteLiteral(@"      </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""tab-pane fade"" id=""sales"" role=""tabpanel"" aria-labelledby=""sales-tab"">
                                <div class=""d-flex flex-wrap justify-content-xl-between"">
                                    <div class=""d-none d-xl-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                        <i class=""mdi mdi-calendar-heart icon-lg mr-3 text-primary""></i>
                                        <div class=""d-flex flex-column justify-content-around"">
                                            <small class=""mb-1 text-muted"">Start date</small>
                                            <div class=""dropdown"">
                                                <a class=""btn btn-secondary dropdown-toggle p-0 bg-transparent border-0 text-dark shadow-none font-weight-medium"" href=""#"" rol");
            WriteLiteral(@"e=""button"" id=""dropdownMenuLinkA"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                                    <h5 class=""mb-0 d-inline-block"">26 Jul 2018</h5>
                                                </a>
                                                <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuLinkA"">
                                                    <a class=""dropdown-item"" href=""#"">12 Aug 2018</a>
                                                    <a class=""dropdown-item"" href=""#"">22 Sep 2018</a>
                                                    <a class=""dropdown-item"" href=""#"">21 Oct 2018</a>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""d-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
       ");
            WriteLiteral(@"                                 <i class=""mdi mdi-download mr-3 icon-lg text-warning""></i>
                                        <div class=""d-flex flex-column justify-content-around"">
                                            <small class=""mb-1 text-muted"">Downloads</small>
                                            <h5 class=""mr-2 mb-0"">2233783</h5>
                                        </div>
                                    </div>
                                    <div class=""d-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                        <i class=""mdi mdi-eye mr-3 icon-lg text-success""></i>
                                        <div class=""d-flex flex-column justify-content-around"">
                                            <small class=""mb-1 text-muted"">Total views</small>
                                            <h5 class=""mr-2 mb-0"">9833550</h5>
                                        </div>
               ");
            WriteLiteral(@"                     </div>
                                    <div class=""d-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                        <i class=""mdi mdi-currency-usd mr-3 icon-lg text-danger""></i>
                                        <div class=""d-flex flex-column justify-content-around"">
                                            <small class=""mb-1 text-muted"">Revenue</small>
                                            <h5 class=""mr-2 mb-0"">$577545</h5>
                                        </div>
                                    </div>
                                    <div class=""d-flex py-3 border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                        <i class=""mdi mdi-flag mr-3 icon-lg text-danger""></i>
                                        <div class=""d-flex flex-column justify-content-around"">
                                            <small class=""mb");
            WriteLiteral(@"-1 text-muted"">Flagged</small>
                                            <h5 class=""mr-2 mb-0"">3497843</h5>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""tab-pane fade"" id=""purchases"" role=""tabpanel"" aria-labelledby=""purchases-tab"">
                                <div class=""d-flex flex-wrap justify-content-xl-between"">
                                    <div class=""d-none d-xl-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                        <i class=""mdi mdi-calendar-heart icon-lg mr-3 text-primary""></i>
                                        <div class=""d-flex flex-column justify-content-around"">
                                            <small class=""mb-1 text-muted"">Start date</small>
                                            <div class=""dropdown"">
                    ");
            WriteLiteral(@"                            <a class=""btn btn-secondary dropdown-toggle p-0 bg-transparent border-0 text-dark shadow-none font-weight-medium"" href=""#"" role=""button"" id=""dropdownMenuLinkA"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                                    <h5 class=""mb-0 d-inline-block"">26 Jul 2018</h5>
                                                </a>
                                                <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuLinkA"">
                                                    <a class=""dropdown-item"" href=""#"">12 Aug 2018</a>
                                                    <a class=""dropdown-item"" href=""#"">22 Sep 2018</a>
                                                    <a class=""dropdown-item"" href=""#"">21 Oct 2018</a>
                                                </div>
                                            </div>
                                        </div>
                                  ");
            WriteLiteral(@"  </div>
                                    <div class=""d-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                        <i class=""mdi mdi-currency-usd mr-3 icon-lg text-danger""></i>
                                        <div class=""d-flex flex-column justify-content-around"">
                                            <small class=""mb-1 text-muted"">Revenue</small>
                                            <h5 class=""mr-2 mb-0"">$577545</h5>
                                        </div>
                                    </div>
                                    <div class=""d-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                        <i class=""mdi mdi-eye mr-3 icon-lg text-success""></i>
                                        <div class=""d-flex flex-column justify-content-around"">
                                            <small class=""mb-1 text-muted"">Total vie");
            WriteLiteral(@"ws</small>
                                            <h5 class=""mr-2 mb-0"">9833550</h5>
                                        </div>
                                    </div>
                                    <div class=""d-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                        <i class=""mdi mdi-download mr-3 icon-lg text-warning""></i>
                                        <div class=""d-flex flex-column justify-content-around"">
                                            <small class=""mb-1 text-muted"">Downloads</small>
                                            <h5 class=""mr-2 mb-0"">2233783</h5>
                                        </div>
                                    </div>
                                    <div class=""d-flex py-3 border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                        <i class=""mdi mdi-flag mr-3 icon-lg text-danger""></i>
   ");
            WriteLiteral(@"                                     <div class=""d-flex flex-column justify-content-around"">
                                            <small class=""mb-1 text-muted"">Flagged</small>
                                            <h5 class=""mr-2 mb-0"">3497843</h5>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-7 grid-margin stretch-card"">
                <div class=""card"">
                    <div class=""card-body"">
                        <p class=""card-title"">Cash deposits</p>
                        <p class=""mb-4"">To start a blog, think of a topic about and first brainstorm party is ways to write details</p>
                        <div id=""cash-deposits-chart-legend"" class=""d-flex justify-content-center p");
            WriteLiteral(@"t-3""></div>
                        <canvas id=""cash-deposits-chart""></canvas>
                    </div>
                </div>
            </div>
            <div class=""col-md-5 grid-margin stretch-card"">
                <div class=""card"">
                    <div class=""card-body"">
                        <p class=""card-title"">Total sales</p>
                        <h1>$ 28835</h1>
                        <h4>Gross sales over the years</h4>
                        <p class=""text-muted"">Today, many people rely on computers to do homework, work, and create or store useful information. Therefore, it is important </p>
                        <div id=""total-sales-chart-legend""></div>
                    </div>
                    <canvas id=""total-sales-chart""></canvas>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12 stretch-card"">
                <div class=""card"">
                    <div class=""card-body"">
          ");
            WriteLiteral(@"              <p class=""card-title"">Recent Purchases</p>
                        <div class=""table-responsive"">
                            <table id=""recent-purchases-listing"" class=""table"">
                                <thead>
                                    <tr>
                                        <th>Name</th>
                                        <th>Status report</th>
                                        <th>Office</th>
                                        <th>Price</th>
                                        <th>Date</th>
                                        <th>Gross amount</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Jeremy Ortega</td>
                                        <td>Levelled up</td>
                                        <td>Catalinaborough</td>
                                    ");
            WriteLiteral(@"    <td>$790</td>
                                        <td>06 Jan 2018</td>
                                        <td>$2274253</td>
                                    </tr>
                                    <tr>
                                        <td>Alvin Fisher</td>
                                        <td>Ui design completed</td>
                                        <td>East Mayra</td>
                                        <td>$23230</td>
                                        <td>18 Jul 2018</td>
                                        <td>$83127</td>
                                    </tr>
                                    <tr>
                                        <td>Emily Cunningham</td>
                                        <td>support</td>
                                        <td>Makennaton</td>
                                        <td>$939</td>
                                        <td>16 Jul 2018</td>
                                        <");
            WriteLiteral(@"td>$29177</td>
                                    </tr>
                                    <tr>
                                        <td>Minnie Farmer</td>
                                        <td>support</td>
                                        <td>Agustinaborough</td>
                                        <td>$30</td>
                                        <td>30 Apr 2018</td>
                                        <td>$44617</td>
                                    </tr>
                                    <tr>
                                        <td>Betty Hunt</td>
                                        <td>Ui design not completed</td>
                                        <td>Lake Sandrafort</td>
                                        <td>$571</td>
                                        <td>25 Jun 2018</td>
                                        <td>$78952</td>
                                    </tr>
                                    <tr>
                 ");
            WriteLiteral(@"                       <td>Myrtie Lambert</td>
                                        <td>Ui design completed</td>
                                        <td>Cassinbury</td>
                                        <td>$36</td>
                                        <td>05 Nov 2018</td>
                                        <td>$36422</td>
                                    </tr>
                                    <tr>
                                        <td>Jacob Kennedy</td>
                                        <td>New project</td>
                                        <td>Cletaborough</td>
                                        <td>$314</td>
                                        <td>12 Jul 2018</td>
                                        <td>$34167</td>
                                    </tr>
                                    <tr>
                                        <td>Ernest Wade</td>
                                        <td>Levelled up</td>
               ");
            WriteLiteral(@"                         <td>West Fidelmouth</td>
                                        <td>$484</td>
                                        <td>08 Sep 2018</td>
                                        <td>$50862</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>-->
    <!-- content-wrapper ends -->
    <!-- partial:partials/_footer.html -->
    <!--<footer class=""footer"">
        <div class=""d-sm-flex justify-content-center justify-content-sm-between"">
            <span class=""text-muted text-center text-sm-left d-block d-sm-inline-block"">Copyright ?? 2018 <a href=""https://www.urbanui.com/"" target=""_blank"">Urbanui</a>. All rights reserved.</span>
            <span class=""float-none float-sm-right d-block mt-1 mt-sm-0 text-center"">Hand-crafted & made with <i class=""mdi mdi-heart text-danger""><");
            WriteLiteral("/i></span>\r\n        </div>\r\n    </footer>-->\r\n    <!-- partial -->\r\n<!--</div>-->\r\n<!-- main-panel ends -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
