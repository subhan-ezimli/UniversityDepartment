#pragma checksum "C:\Users\Professional\Desktop\NTier\MvcUi\Views\Home\ScienceConferance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3abde431aedce992f7e7071056d21de2335aae68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ScienceConferance), @"mvc.1.0.view", @"/Views/Home/ScienceConferance.cshtml")]
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
#line 1 "C:\Users\Professional\Desktop\NTier\MvcUi\Views\_ViewImports.cshtml"
using MvcUi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Professional\Desktop\NTier\MvcUi\Views\_ViewImports.cshtml"
using MvcUi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Professional\Desktop\NTier\MvcUi\Views\_ViewImports.cshtml"
using Entities.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Professional\Desktop\NTier\MvcUi\Views\_ViewImports.cshtml"
using Entities.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Professional\Desktop\NTier\MvcUi\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3abde431aedce992f7e7071056d21de2335aae68", @"/Views/Home/ScienceConferance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9a441daf68a7d047e6e02aeb88a7becff2187cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ScienceConferance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ArticleModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "SubjectName", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("M??qal??nin ad??n?? daxil edin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "file", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "file", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("accept", new global::Microsoft.AspNetCore.Html.HtmlString("application/pdf"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Save", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Article", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("success()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-error", new global::Microsoft.AspNetCore.Html.HtmlString("error(result)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css"" integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"">
    <div class=""content"">
        <div class=""row"">

            <div style=""height: 160vh;"">
                <h1 class=""label"" id=""resultMessage""></h1>

                <!-- <div>
                    <img src=""../images/img1.jpg"" style=""width: 100%; height:3vh"" alt="""">
                </div> -->
                <div style="" height: 300px;width: 100%;background: url(/assets/images/img1.jpg)center center/cover no-repeat;"">
                </div>
                <br><br>
                <h4 style=""text-align: center;"">G??ncl??r v?? Elmi innovasiyalar</h4>
                <br><br>
                <hr>
                <!-- <div>
                    <button
                        style=""margin-left: 15px; border: 0; background-color: white; border-radius: 25px; border: 1px solid rgb(96, ");
            WriteLiteral(@"119, 250); background-color: rgb(188, 210, 250);"">Konfrans
                        haqq??nda</button>
                    <button
                        style=""margin-left: 15px; border: 0; background-color: white;border-radius: 25px; border: 1px solid rgb(96, 119, 250); background-color: rgb(188, 210, 250);"">T????kilat
                        Komit??si</button>
                    <button
                        style=""margin-left: 15px; border: 0; background-color: white;border-radius: 25px; border: 1px solid rgb(96, 119, 250); background-color: rgb(188, 210, 250);"">B??lm??l??r</button>
                    <button
                        style=""margin-left: 15px; border: 0;background-color: white;border-radius: 25px; border: 1px solid rgb(96, 119, 250); background-color: rgb(188, 210, 250);"">T??rtibat
                        qaydalar??</button>
                    <button
                        style=""margin-left: 15px; border: 0;background-color: white;border-radius: 25px; border: 1px solid rgb(96, 119");
            WriteLiteral(@", 250); background-color: rgb(188, 210, 250);"">Vacib
                        tarixl??r</button>
                    <button
                        style=""margin-left: 15px; border: 0;background-color: white;border-radius: 25px; border: 1px solid rgb(96, 119, 250); background-color: rgb(188, 210, 250);"">M??qal??l??r</button>
                </div> -->

                <p style=""text-align: center;"">
                    <button class=""btn btn-primary collapsed"" type=""button"" data-bs-toggle=""collapse""
                            data-bs-target=""#collapseExample"" aria-expanded=""false"" aria-controls=""collapseExample"">
                        Konfrans haqq??nda
                    </button>
                    <button class=""btn btn-primary collapsed"" type=""button"" data-bs-toggle=""collapse""
                            data-bs-target=""#collapseExample1"" aria-expanded=""false""
                            aria-controls=""collapseExample1"">
                        T????kilat Komit??si
                    </button");
            WriteLiteral(@">
                    <button class=""btn btn-primary collapsed"" type=""button"" data-bs-toggle=""collapse""
                            data-bs-target=""#collapseExample2"" aria-expanded=""false""
                            aria-controls=""collapseExample2"">
                        B??lm??l??r
                    </button>
                    <button class=""btn btn-primary collapsed"" type=""button"" data-bs-toggle=""collapse""
                            data-bs-target=""#collapseExample3"" aria-expanded=""false""
                            aria-controls=""collapseExample3"">
                        T??rtibat qaydalar??
                    </button>
                    <button class=""btn btn-primary collapsed"" type=""button"" data-bs-toggle=""collapse""
                            data-bs-target=""#collapseExample4"" aria-expanded=""false""
                            aria-controls=""collapseExample4"">
                        Vacib tarixl??r
                    </button>
                    <button class=""btn btn-primary col");
            WriteLiteral(@"lapsed"" type=""button"" data-bs-toggle=""collapse""
                            data-bs-target=""#collapseExample5"" aria-expanded=""false""
                            aria-controls=""collapseExample5"">
                        M??qal??l??r
                    </button>
");
#nullable restore
#line 67 "C:\Users\Professional\Desktop\NTier\MvcUi\Views\Home\ScienceConferance.cshtml"
                     if (User.Identity.IsAuthenticated)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\Professional\Desktop\NTier\MvcUi\Views\Home\ScienceConferance.cshtml"
                         if (@User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Role).Value == "candidate")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#exampleModalArticle\">\r\n                                M??qal?? ??lav?? et\r\n                            </button>\r\n");
#nullable restore
#line 74 "C:\Users\Professional\Desktop\NTier\MvcUi\Views\Home\ScienceConferance.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\Professional\Desktop\NTier\MvcUi\Views\Home\ScienceConferance.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </p>\r\n\r\n\r\n                <div class=\"collapse\" id=\"collapseExample\"");
            BeginWriteAttribute("style", " style=\"", 4957, "\"", 4965, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""card card-body"">
                        4-5 may 2022-ci il tarixl??rind?? Az??rbaycan xalq??n??n ??mummilli lideri Heyd??r ??liyevin
                        anadan olmas??n??n 99-cu ild??n??m??n?? h??sr olunmu?? t??l??b?? v?? g??nc t??dqiqat????lar??n
                        ???G??ncl??r v?? elmi innovasiyalar??? m??vzusunda Respublika elmi-texniki konfrans??
                        ke??iril??c??kdir.
                        Konfrans??n ke??irilm??sinin ??sas m??qs??di g??ncl??ri elmi yarad??c??l????a f??al sur??td?? c??lb
                        etm??k v?? onlar??n apard??qlar?? elmi t??dqiqat i??l??rinin n??tic??l??rinin m??zakir??sini
                        t????kil etm??kdir.
                    </div>
                </div>
                <div class=""collapse"" id=""collapseExample1""");
            BeginWriteAttribute("style", " style=\"", 5742, "\"", 5750, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""card card-body"">
                        Prof. Vilay??t V??liyev - AzTU-nun rektoru (s??dr) <br>

                        Prof. Nur??li Yusifb??yli - T??dris i??l??ri ??zr?? prorektor (s??dr m??avini) <br>

                        Prof. ??etin Elmas - Elm v?? innovasiya ??zr?? prorektor <br>

                        Prof. S??bhan Namazov - Beyn??lxalq ??laq??l??r ??zr?? prorektor <br>

                        i.f.d. Kamran R??sulov - Sosial m??s??l??l??r v?? ictimaiyy??tl?? ??laq??l??r ??zr?? prorektor <br>

                        i.f.d. R????ad ??liyev - R??q??msalla??ma v?? layih??l??r ??zr?? prorektor <br>

                        i.f.d. R????ad Kaz??mov - Maliyy??-t??s??rr??fat i??l??ri ??zr?? prorektor <br>

                        ??b??lf??z Tal??bov - ??mumi i??l??r ??zr?? prorektor <br>

                        Fariz M??mm??dov - Rektorun elmi-t??dqiqat m??s??l??l??ri ??zr?? m????aviri <br>

                        Prof. ??lham Pirm??mm??dov ??? AzTU Rektorunun m????aviri <br>

                        f.f.d. Na???? Qas??mov - T??dqi");
            WriteLiteral(@"qat v?? inki??af ????b??sinin m??dir m??avini (elmi katib) <br>

                        Dos. ??r??stun M??mm??dov - AzTU-nun T??dris hiss??sinin m??diri <br>

                        Prof. Yusuf S??nmez - Y??ks??k T??hsil ??nstitutunun direktoru <br>

                        V??qar H??seynli - AzTU-nun TEC-nin s??dri (m??sul katib) <br>

                        Dos. Allahverdi ????rifov - N??qliyyat v?? logistika fak??lt??sinin dekan?? <br>

                        Dos. H??seynqulu Quliyev - Energetika v?? avtomatika fak??lt??sinin dekan?? <br>

                        Dos. Nizami Poladov - Metallurgiya v?? material????nasl??q fak??lt??sinin dekan?? <br>

                        Dos. Malik Qarayev - Ma????nqay??rma v?? robototexnika fak??lt??sinin dekan?? <br>

                        Dos. Taleh ??irinov - ??nformasiya v?? telekommunikasiya texnologiyalar?? fak??lt??sinin
                        dekan?? <br>

                        Dos. F??rqan?? Musayeva - ??qtisadiyyat v?? idar??etm?? fak??lt??sinin dekan?? <br>

                        Dos. El??in ");
            WriteLiteral(@"Rzayev - X??susi texnika v?? texnologiya fak??lt??sinin dekan?? <br>

                        S??fa Ba????rov - Media il?? i?? v?? kommunikasiya ????b??sinin m??dir m??avini <br>

                        ??li X??lilov - ??nformasiya v?? kommunikasiya texnologiyalar?? ????b??sinin m??diri <br>

                        Mirm??h??mm??d ??l??kb??rli - T??l??b?? H??mkarlar ??ttifaq?? Komit??sinin s??dri <br>

                        Eyvaz M??h??mm??dli - T??l??b?? G??ncl??r T????kilat??n??n s??dr ??v??zi <br>

                        Sevinc ??sg??nd??rova - M??tbuat katibi <br>





                    </div>
                </div>
                <div class=""collapse"" id=""collapseExample2""");
            BeginWriteAttribute("style", " style=\"", 8452, "\"", 8460, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"card card-body\">\r\n                        <img src=\"/assets/images/cedvel1.png\" style=\"width: 55%; height:55%;\"");
            BeginWriteAttribute("alt", " alt=\"", 8607, "\"", 8613, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"collapse\" id=\"collapseExample3\"");
            BeginWriteAttribute("style", " style=\"", 8728, "\"", 8736, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""card card-body"">
                        1. M????llifl??r tezisl??rini aztuconference.aztu.edu.az sayt??nda qeydiyyatdan ke??m??kl??
                        g??nd??r??n zaman m??tl??q aid oldu??u konfrans b??lm??sini qeyd etm??lidir.
                        <br>
                        2. Konfransa tezis g??nd??rildikd?? m????llif haqq??nda a??a????dak?? m??lumatlar qeyd edilm??lidir:

                        m????llifin tam ad?? (soyad??, ad??, atas??n??n ad??), elmi d??r??c??si, elmi ad??, i?? yeri,
                        v??zif??si, telefon n??mr??si, tezisin ad??, konfrans??n b??lm?? n??mr??si v?? ad?? elektron formada
                        t??qdim olunur.
                        <br>
                        3. Tezis az??rbaycan, rus v?? ya ingilis dilind?? t??qdim olunmal??d??r. Tezisin ??vv??lind?? 3
                        dild?? (tezisin t??qdim edildiyi v?? dig??r 2 konfrans dilind??) tezisin ad??, x??las?? (50 ???
                        100 s??z) v?? a??ar s??zl??r (3 - 5 sayda) verilm??lidir.
                        <br>
   ");
            WriteLiteral(@"                     4. M??qal?? MS Word proqram??nda A4 format??nda (sol v?? sa?? ??? 2 sm, yuxar?? v?? a??a???? ??? 2,5
                        sm), Times New Roman ??rifti il?? 12 pt ??l????d??, 1,0 s??tirl??raras?? intervalla v?? m??tndaxili
                        yaz??da abzas 1 sm buraxmaqla enin?? haz??rlanmal??d??r.
                        <br>
                        5. M??qal?? a??a????dak?? ard??c??ll??qla haz??rlanmal??d??r: m??qal??nin ad?? ??? ortada, b??y??k
                        h??rfl??rl??, qal??n ??riftl??, sonda 6 pt interval, m????llif(l??r)in tam ad?? ??? ortada;
                        m????llif(l??r)in i?? yeri, ????h??r v?? ??lk?? ??? ortada, sonda 6 pt interval (??g??r m????llifl??r
                        m??xt??lif t????kilatlar?? t??msil edirl??rs??, m????llifin v?? t????kilat??n ad?? yuxar?? indeksl??
                        n??mr??l??nir), e-mail ??nvan??.
                        <br>
                        6. ??d??biyyat siyah??s??: h??r bir istinad olunan m??nb??nin ad?? t??rc??m?? olunmadan, m??qal??d??
                        istifad?? olunma ard??c??ll??????na uy??un olaraq n??mr");
            WriteLiteral(@"??l??nir.
                        <br>
                        7. M??qal??d?? c??dv??l v?? ????kill??r n??mr??l??nir: c??dv??l ??? c??dv??lin yuxar??s??nda, sa??dan (m??s.,
                        C??dv??l 1), ????kil ??? ????klin alt??nda, ortadan (m??s., ????kil 1) v?? m??tn hiss??d??n (yuxar??dan
                        v?? a??a????dan) 1 bo?? s??tir buraxmaqla g??st??rilir.
                        <br>
                        8.Riyazi ifad??l??r MS Word proqram??n??n d??stur redaktoru (Equation) il?? t??rtib olunur.
                        Yaln??z m??tnd?? istinad olunan d??sturlar n??mr??l??nir. D??stur s??trin ortas??nda, n??mr??si is??
                        sa??da m??t??riz??d?? yaz??l??r.
                        <br>
                        9. M??qal?? bir s??tunlu m??tn format??nda t??qdim edilm??li v?? 2-5 s??hif?? aral??????nda
                        olmal??d??r.
                        <br>
                    </div>
                </div>
                <div class=""collapse"" id=""collapseExample4""");
            BeginWriteAttribute("style", " style=\"", 11737, "\"", 11745, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""card card-body"">
                        ""G??ncl??r v?? elmi innovasiyalar??? m??vzusunda Respublika elmi-texniki konfrans??na
                        m??ruz??l??rin q??bulu ??????n son tarix: 15.04.2022
                    </div>
                </div>
                <div class=""collapse"" id=""collapseExample5""");
            BeginWriteAttribute("style", " style=\"", 12085, "\"", 12093, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""card card-body"">
                        <div class=""row"">
                            <div class=""col-8"">

                                <table class=""table table-striped"">
                                    <thead class=""thead-dark"">
                                        <tr>
                                            <th scope=""col"">#</th>
                                            <th scope=""col"">M????llif</th>
                                            <th scope=""col"">M??nb??</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 217 "C:\Users\Professional\Desktop\NTier\MvcUi\Views\Home\ScienceConferance.cshtml"
                                           int i = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 218 "C:\Users\Professional\Desktop\NTier\MvcUi\Views\Home\ScienceConferance.cshtml"
                                         foreach (var item in Model.ArticleDtos)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <th scope=\"row\">");
#nullable restore
#line 221 "C:\Users\Professional\Desktop\NTier\MvcUi\Views\Home\ScienceConferance.cshtml"
                                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                <td>");
#nullable restore
#line 222 "C:\Users\Professional\Desktop\NTier\MvcUi\Views\Home\ScienceConferance.cshtml"
                                               Write(item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>\r\n                                                    <a class=\"link-dark\" target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 13289, "\"", 13359, 1);
#nullable restore
#line 224 "C:\Users\Professional\Desktop\NTier\MvcUi\Views\Home\ScienceConferance.cshtml"
WriteAttributeValue("", 13296, Url.Action("GetSubject", "ELibrary", new { path = item.Path }), 13296, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        ");
#nullable restore
#line 225 "C:\Users\Professional\Desktop\NTier\MvcUi\Views\Home\ScienceConferance.cshtml"
                                                   Write(item.SubjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </a>\r\n                                                </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 229 "C:\Users\Professional\Desktop\NTier\MvcUi\Views\Home\ScienceConferance.cshtml"
                                            i++;
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>



            </div>

        </div>
    </div>



    <script>

        function Success() {
            var element = document.getElementById(""resultMessage"");
            element.innerHTML = ""Fayl m??v??ff??qiyy??tl?? yadda saxlan??ld??"";
        }
        function Error(result) {
            var element = document.getElementById(""resultMessage"");
            console.log(result);
            element.innerHTML = ""Problem yarand?? : "" + result;
        }



    </script>









    <!-- Button trigger modal -->
    <!-- Modal -->
    <div class=""modal fade"" id=""exampleModalArticle"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLongTitle"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3abde431aedce992f7e7071056d21de2335aae6825970", async() => {
                WriteLiteral(@"
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLongTitle"">M??qal?? ??lav?? et</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>

                    <div class=""modal-body"">

                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3abde431aedce992f7e7071056d21de2335aae6826746", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 290 "C:\Users\Professional\Desktop\NTier\MvcUi\Views\Home\ScienceConferance.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SubjectName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3abde431aedce992f7e7071056d21de2335aae6828770", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 291 "C:\Users\Professional\Desktop\NTier\MvcUi\Views\Home\ScienceConferance.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.File);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Ba??la</button>
                        <button type=""submit"" class=""btn btn-primary"">Yadda saxla</button>
                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
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


    <script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js"" integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.12.9/dist/umd/popper.min.js"" integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/js/bootstrap.min.js"" integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"" crossorigin=""anonymous""></script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ArticleModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
