#pragma checksum "D:\Projects\Personal\Personal\Areas\Admin\Views\Work\Save.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1ca668d308367f1daeba84cb95c9e8cd3b2ff4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Work_Save), @"mvc.1.0.view", @"/Areas/Admin/Views/Work/Save.cshtml")]
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
#line 1 "D:\Projects\Personal\Personal\Areas\Admin\Views\_ViewImports.cshtml"
using Personal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1ca668d308367f1daeba84cb95c9e8cd3b2ff4a", @"/Areas/Admin/Views/Work/Save.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bc6c8345fcb658f347d5a1dcfe085214026119b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Work_Save : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tbmywork>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/css/bootstrap-wysihtml5.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/css/awesome-bootstrap-checkbox.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Please enter Work Name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Work", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Save", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Mywork", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e1ca668d308367f1daeba84cb95c9e8cd3b2ff4a8574", async() => {
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e1ca668d308367f1daeba84cb95c9e8cd3b2ff4a9693", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"






<section class=""page"">

    <nav class=""navbar-aside navbar-static-side "" id=""menu"">
        <div class=""sidebar-collapse"">

            <ul class=""nav"" id=""side-menu"">

                <li>
                    <a href=""index.html""><i class=""fa fa-th-large""></i> <span class=""nav-label"">Dashboard </span><span class=""label label-rouded pull-right p1-bg note-icon"">1</span></a>
                </li>
                <li>
                    <a href=""widgets.html""><i class=""fa fa-cog""></i> <span class=""nav-label"">Widgets </span><span class=""label label-rouded pull-right p3-bg note-icon"">New 40+</span></a>

                </li>
                <li>
                    <a href=""mailbox.html""><i class=""fa fa-envelope""></i> <span class=""nav-label"">Mailbox </span><span class=""fa fa-plus""></span></a>
                    <ul class=""nav nav-second-level collapse"">
                        <li><a href=""mailbox.html"">Inbox</a></li>
                        <li><a href=""mail_detail.html"">Email v");
            WriteLiteral(@"iew</a></li>
                        <li><a href=""mail_compose.html"">Compose email</a></li>
                    </ul>
                </li>
                <li class=""nav-heading""><span>Components</span></li>
                <li>
                    <a href=""#""><i class=""fa fa-bar-chart""></i> <span class=""nav-label"">Graphs</span><span class=""fa fa-plus""></span></a>
                    <ul class=""nav nav-second-level collapse"">
                        <li><a href=""flot_charts.html"">Flot charts</a></li>
                        <li><a href=""morris_js.html"">Morris.js</a></li>
                        <li><a href=""chart_js.html"">Chart.js</a></li>
                        <li><a href=""chartist.html"">Chartist</a></li>
                        <li><a href=""chart_sparkline.html"">Sparkline</a></li>
                        <li><a href=""pie_chart.html"">PIE Chart</a></li>

                    </ul>
                </li>

                <li class=""active"">
                    <a href=""#""><i class=""fa fa-ed");
            WriteLiteral(@"it""></i> <span class=""nav-label"">Forms</span><span class=""fa fa-plus""></span></a>
                    <ul class=""nav nav-second-level collapse"">
                        <li><a href=""form_basic.html"">Basic form</a></li>
                        <li><a href=""form_advanced.html"">Advanced form</a></li>
                        <li><a href=""form_wizard.html"">Wizard form</a></li>
                        <li><a href=""form_masked.html"">Masked form</a></li>
                        <li><a href=""form_file_upload.html"">File upload</a></li>
                        <li><a href=""file_drop.html"">File Dropzone</a></li>
                        <li><a href=""form_text_editor.html"">Text editor</a></li>
                        <li><a href=""form_inline_edit.html"">Inline edit</a></li>
                        <li><a href=""form_validate.html"">Form Validation</a></li>
                        <li><a href=""form_tinymce.html"">Tinymce Editor</a></li>
                        <li><a href=""form_wysihtml5.html"">WYSIHTML5 Editor</a></");
            WriteLiteral(@"li>

                    </ul>
                </li>
                <li>
                    <a href=""#""><i class=""fa fa-files-o""></i> <span class=""nav-label"">Other Pages</span><span class=""fa fa-plus""></span></a>
                    <ul class=""nav nav-second-level collapse"">
                        <li><a href=""lockscreen.html"">Lockscreen</a></li>
                        <li><a href=""login.html"">Login</a></li>
                        <li><a href=""register.html"">Register</a></li>
                        <li><a href=""404.html"">404 Page</a></li>
                        <li><a href=""empty_page.html"">Empty page</a></li>
                        <li><a href=""gallery.html"">gallery</a></li>
                        <li><a href=""price_tables.html"">Price tables</a></li>
                        <li><a href=""page_contact.html"">Contact Page</a></li>
                    </ul>
                </li>
                <li>
                    <a href=""#""><i class=""fa fa-shopping-cart""></i> <span class=""nav-lab");
            WriteLiteral(@"el"">E-commerce</span><span class=""fa fa-plus""></span></a>
                    <ul class=""nav nav-second-level collapse"">
                        <li><a href=""orders.html"">orders</a></li>
                        <li><a href=""order-view.html"">order View</a></li>
                        <li><a href=""products.html"">Products</a></li>


                    </ul>
                </li>

                <li>
                    <a href=""#""><i class=""fa fa-hourglass-o""></i> <span class=""nav-label"">Icons</span><span class=""fa fa-plus""></span></a>
                    <ul class=""nav nav-second-level collapse"">
                        <li><a href=""icons.html"">Icons</a></li>
                        <li><a href=""weather-icon.html"">Weather Icons</a></li>
                        <li><a href=""themifyicons.html"">Themify Icons</a></li>
                        <li><a href=""linea_arrows.html"">Linea Arrows Icons</a></li>
                        <li><a href=""linea_basic.html"">Linea Basic Icons</a></li>
             ");
            WriteLiteral(@"           <li><a href=""linea_elaboration.html"">Linea Basic Elaboration Icons</a></li>
                        <li><a href=""linea_ecommerce.html"">Linea Ecommerce Icons</a></li>
                    </ul>
                </li>
                <li>
                    <a href=""#""><i class=""fa fa-flask""></i> <span class=""nav-label"">UI Elements</span><span class=""fa fa-plus""></span></a>
                    <ul class=""nav nav-second-level collapse"">
                        <li><a href=""typography.html"">Typography</a></li>
                        <li><a href=""buttons.html"">Buttons</a></li>
                        <li><a href=""video.html"">Video</a></li>
                        <li><a href=""tabs_panels.html"">Panels</a></li>
                        <li><a href=""tabs.html"">Tabs</a></li>
                        <li><a href=""chat.html"">Chat</a></li>
                        <li><a href=""alert_notifications.html"">Alert & notifications</a></li>
                        <li><a href=""tree_view.html"">Tree View</a><");
            WriteLiteral(@"/li>
                        <li><a href=""timeline.html"">Time Line</a></li>
                        <li><a href=""progress_bar.html"">Progress Bar</a></li>
                        <li><a href=""sliders.html"">OWL Carousel</a></li>
                        <li><a href=""range_slider.html"">Range Slider</a></li>
                        <li><a href=""tooltip.html"">Tooltip</a></li>
                        <li><a href=""alert_popup.html"">Alert Popup</a></li>
                        <li><a href=""accordion.html"">Accordion</a></li>
                        <li><a href=""models.html"">Modals Popup</a></li>
                        <li><a href=""toastr_alert.html"">Toastr Alert</a></li>
                    </ul>
                </li>

                <li>
                    <a href=""grid_options.html""><i class=""fa fa-laptop""></i> <span class=""nav-label"">Grid options</span><span class=""label label-rouded pull-right p2-bg note-icon"">New</span></a>
                </li>
                <li>
                    <a href=");
            WriteLiteral(@"""#""><i class=""fa fa-table""></i> <span class=""nav-label"">Tables</span><span class=""fa fa-plus""></span></a>
                    <ul class=""nav nav-second-level collapse"">
                        <li><a href=""table_basic.html"">Static Tables</a></li>
                        <li><a href=""table_data_tables.html"">Data Tables</a></li>
                        <li><a href=""table_responsive.html"">Responsive Tables</a></li>
                        <li><a href=""table_editable.html"">Editable Tables</a></li>
                        <li><a href=""table_jsgrid.html"">JSGrid Tables</a></li>

                    </ul>
                </li>
                <li class=""nav-heading""><span>More</span></li>
                <li>
                    <a href=""#""><i class=""fa fa-users""></i> <span class=""nav-label"">Users</span><span class=""fa fa-plus""></span></a>
                    <ul class=""nav nav-second-level collapse"">
                        <li><a href=""user_profile.html"">profile</a></li>
                        <li><");
            WriteLiteral(@"a href=""user_list.html"">User list</a></li>

                    </ul>
                </li>
                <li>
                    <a href=""#""><i class=""fa fa-map-marker""></i> <span class=""nav-label"">maps</span><span class=""fa fa-plus""></span></a>
                    <ul class=""nav nav-second-level collapse"">
                        <li><a href=""google_maps.html"">Google maps</a></li>
                        <li><a href=""vector_maps.html"">Vector Maps</a></li>
                    </ul>
                </li>
                <li>
                    <a href=""#""><i class=""fa fa-pencil""></i> <span class=""nav-label"">Blog</span><span class=""fa fa-plus""></span></a>
                    <ul class=""nav nav-second-level collapse"">
                        <li><a href=""blog_list.html"">Blog list</a></li>
                        <li><a href=""blog_post.html"">Blog post</a></li>
                    </ul>
                </li>
                <li><a href=""calendar.html""><i class=""fa fa-calendar""></i>  <span cl");
            WriteLiteral(@"ass=""nav-label"">Calendar </span><span class=""label label-rouded pull-right p2-bg note-icon"">New</span></a></li>

                <li>
                    <a href=""#""><i class=""fa fa-sitemap""></i> <span class=""nav-label"">Menu Levels </span><span class=""fa fa-plus""></span></a>
                    <ul class=""nav nav-second-level collapse"">
                        <li>
                            <a href=""#"">Third Level <span class=""fa fa-plus""></span></a>
                            <ul class=""nav nav-third-level"">
                                <li>
                                    <a href=""#"">Third Level Item</a>
                                </li>
                            </ul>
                        </li>
                        <li><a href=""#"">Second Level Item</a></li>
                    </ul>
                </li>
                <li class=""nav-heading""><span>Extra</span></li>
            </ul>
            <div class=""row"">
                <div class=""left-bar"">


        ");
            WriteLiteral(@"            <div class=""map_progress"">
                        <h4>Unique Visitors</h4>
                        <span><small>Last Week Rise by 62%</small></span>
                        <div class=""progress""><div class=""progress-bar"" role=""progressbar"" aria-valuenow=""62"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 62%""></div></div>

                        <h4>Registrations</h4>
                        <span><small>Up by 57% last 7 days</small></span>
                        <div class=""progress""><div class=""progress-bar"" role=""progressbar"" aria-valuenow=""57"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 57%""></div></div>

                        <h4>Direct Sales</h4>
                        <span><small>Last Month Rise by 22%</small></span>
                        <div class=""progress""><div class=""progress-bar"" role=""progressbar"" aria-valuenow=""22"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 22%""></div></div>
                    </div>
                </div>
            </");
            WriteLiteral(@"div>


        </div>
    </nav>


    <div id=""wrapper"">
        <div class=""content-wrapper container"">
            <div class=""row"">
                <div class=""col-sm-12"">
                    <div class=""page-title"">
                        <h1>Form Elements<small></small></h1>
                        <ol class=""breadcrumb"">
                            <li><a href=""#""><i class=""fa fa-home""></i></a></li>
                            <li class=""active"">forms</li>
                        </ol>
                    </div>
                </div>
            </div><!-- end .page title-->

            <div class=""row"">

                <div class=""col-md-10"">
                    <div class=""panel panel-card margin-b-30"">
                        <!-- Start .panel -->
                        <div class=""panel-heading"">
                            <h4 class=""panel-title""> Horizontal form</h4>
                            <div class=""panel-actions"">
                                <a href=""");
            WriteLiteral(@"#"" class=""panel-action panel-action-toggle"" data-panel-toggle></a>
                                <a href=""#"" class=""panel-action panel-action-dismiss"" data-panel-dismiss></a>
                            </div>
                        </div>
                        <div class=""panel-body"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1ca668d308367f1daeba84cb95c9e8cd3b2ff4a24204", async() => {
                WriteLiteral("\r\n                                <div class=\"form-group\">\r\n");
                WriteLiteral("\r\n");
                WriteLiteral(@"                                </div>
                                <div class=""form-group"">
                                    <label class=""col-lg-2 control-label"">Work Name</label>

                                    <div class=""col-lg-10"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e1ca668d308367f1daeba84cb95c9e8cd3b2ff4a24900", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 243 "D:\Projects\Personal\Personal\Areas\Admin\Views\Work\Save.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.WorkName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
                                
                                <div class=""form-group"">
                                    <label class=""col-lg-2 control-label"">Image</label>

                                    <div class=""col-lg-10"">
                                        <input type=""file"" name=""Files"" accept=""image/*"" class=""form-control"">
                                    </div>
                                </div>

                                <div class=""form-group"">
                                    <div class=""col-lg-offset-2 col-lg-10"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1ca668d308367f1daeba84cb95c9e8cd3b2ff4a27483", async() => {
                    WriteLiteral("\r\n                                            Save\r\n                                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1ca668d308367f1daeba84cb95c9e8cd3b2ff4a29159", async() => {
                    WriteLiteral("\r\n                                            Cancel\r\n                                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tbmywork> Html { get; private set; }
    }
}
#pragma warning restore 1591
