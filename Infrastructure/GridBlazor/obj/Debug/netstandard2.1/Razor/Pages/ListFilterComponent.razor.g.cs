#pragma checksum "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46c894ef4d3313b39c8625ca293184c3e9a2db97"
// <auto-generated/>
#pragma warning disable 1591
namespace GridBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
using GridBlazor.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
using GridShared;

#line default
#line hidden
#nullable disable
    public partial class ListFilterComponent<T> : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
 if (Visible)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "dropdown dropdown-menu grid-dropdown opened");
            __builder.AddAttribute(2, "style", "display:block;position:relative;" + (
#nullable restore
#line 8 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                                                                                                  "margin-left:" + _offset.ToString() + "px;"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "onkeyup", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                                                                                                                                                                            FilterKeyup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventStopPropagationAttribute(4, "onclick", true);
            __builder.AddEventStopPropagationAttribute(5, "onkeyup", true);
            __builder.AddAttribute(6, "tabindex", "-1");
            __builder.AddElementReferenceCapture(7, (__value) => {
#nullable restore
#line 8 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                                                                                                                                                      listFilter = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "grid-dropdown-arrow");
            __builder.AddAttribute(11, "style", 
#nullable restore
#line 9 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                                              "margin-left:" + (-_offset).ToString() + "px;"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "grid-dropdown-inner grid-dropdown-list-filter-class");
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "grid-popup-widget");
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "grid-filter-body");
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 13 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                 if (_filterOptions.ShowSelectAllButtons)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "                    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "grid-buttons ml-0 my-2");
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "grid-filter-buttons");
            __builder.AddMarkupContent(28, "\r\n                            ");
            __builder.OpenElement(29, "label");
            __builder.AddAttribute(30, "class", "mr-3");
            __builder.OpenElement(31, "b");
#nullable restore
#line 17 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
__builder.AddContent(32, Strings.Select);

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, ":");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                            ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "type", "button");
            __builder.AddAttribute(37, "class", "btn btn-secondary mr-2");
            __builder.AddAttribute(38, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                                                                                           SelectVisibleButtonClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventStopPropagationAttribute(39, "onclick", true);
            __builder.AddMarkupContent(40, "\r\n                                ");
#nullable restore
#line 19 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
__builder.AddContent(41, Strings.All);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(42, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                            ");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "type", "button");
            __builder.AddAttribute(46, "class", "btn btn-secondary");
            __builder.AddAttribute(47, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                                                                                      UnselectVisibleButtonClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventStopPropagationAttribute(48, "onclick", true);
            __builder.AddMarkupContent(49, "\r\n                                ");
#nullable restore
#line 22 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
__builder.AddContent(50, Strings.None);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(51, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 26 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                 if (_filterOptions.ShowSearchInput)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "                    ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "form-group my-2");
            __builder.AddMarkupContent(58, "\r\n                        ");
            __builder.OpenElement(59, "input");
            __builder.AddAttribute(60, "type", "text");
            __builder.AddAttribute(61, "class", "grid-filter-input form-control");
            __builder.AddAttribute(62, "placeholder", 
#nullable restore
#line 32 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                                             Strings.SearchFilterListInputText

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(63, "oninput", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                                         FilterTextChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
#nullable restore
#line 35 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(66, "                ");
            __builder.OpenElement(67, "label");
            __builder.OpenElement(68, "b");
#nullable restore
#line 36 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
__builder.AddContent(69, Strings.FilterValueLabel);

#line default
#line hidden
#nullable disable
            __builder.AddContent(70, ":");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                ");
            __builder.OpenElement(72, "ul");
            __builder.AddAttribute(73, "class", "menu-list");
            __builder.AddMarkupContent(74, "\r\n");
#nullable restore
#line 38 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                     foreach (var data in _visibleList)
                    {
                        bool isChecked = _filters.Any(x => x.Type.Equals("1") && x.Value.Equals(data.Value));

#line default
#line hidden
#nullable disable
            __builder.AddContent(75, "                        ");
            __builder.OpenElement(76, "li");
            __builder.AddMarkupContent(77, "\r\n                            ");
            __builder.OpenElement(78, "label");
            __builder.AddAttribute(79, "class", "list-filter-label");
            __builder.AddMarkupContent(80, "\r\n");
#nullable restore
#line 43 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                                 if (isChecked)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(81, "                                    ");
            __builder.OpenElement(82, "input");
            __builder.AddAttribute(83, "type", "checkbox");
            __builder.AddAttribute(84, "class", "grid-filter-list");
            __builder.AddAttribute(85, "checked", true);
            __builder.AddAttribute(86, "value", 
#nullable restore
#line 45 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                                                                                                    isChecked

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(87, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                                                                                                                         e => MyClickHandler(e, isChecked, data.Value)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n");
#nullable restore
#line 46 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(89, "                                    ");
            __builder.OpenElement(90, "input");
            __builder.AddAttribute(91, "type", "checkbox");
            __builder.AddAttribute(92, "class", "grid-filter-list");
            __builder.AddAttribute(93, "value", 
#nullable restore
#line 49 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                                                                                            isChecked

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(94, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                                                                                                                 e => MyClickHandler(e, isChecked, data.Value)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n");
#nullable restore
#line 50 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(96, "                                ");
#nullable restore
#line 51 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
__builder.AddContent(97, data.Title);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(98, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n");
#nullable restore
#line 54 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                     if (_includeIsNull)
                    {
                        bool isChecked = _filters.Any(x => x.Type.Equals("11"));

#line default
#line hidden
#nullable disable
            __builder.AddContent(101, "                        ");
            __builder.OpenElement(102, "li");
            __builder.AddMarkupContent(103, "\r\n                            ");
            __builder.OpenElement(104, "label");
            __builder.AddAttribute(105, "class", "list-filter-label");
            __builder.AddMarkupContent(106, "\r\n");
#nullable restore
#line 60 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                                 if (isChecked)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(107, "                                    ");
            __builder.OpenElement(108, "input");
            __builder.AddAttribute(109, "type", "checkbox");
            __builder.AddAttribute(110, "class", "grid-filter-list");
            __builder.AddAttribute(111, "checked", true);
            __builder.AddAttribute(112, "value", 
#nullable restore
#line 62 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                                                                                                    isChecked

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(113, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                                                                                                                         e => IsNullHandler(e, isChecked)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n");
#nullable restore
#line 63 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(115, "                                    ");
            __builder.OpenElement(116, "input");
            __builder.AddAttribute(117, "type", "checkbox");
            __builder.AddAttribute(118, "class", "grid-filter-list");
            __builder.AddAttribute(119, "value", 
#nullable restore
#line 66 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                                                                                            isChecked

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(120, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                                                                                                                 e => IsNullHandler(e, isChecked)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n");
#nullable restore
#line 67 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(122, "                                ");
#nullable restore
#line 68 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
__builder.AddContent(123, Strings.IsNull);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(124, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n");
#nullable restore
#line 71 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                     if (_includeIsNotNull)
                    {
                        bool isChecked = _filters.Any(x => x.Type.Equals("12"));

#line default
#line hidden
#nullable disable
            __builder.AddContent(127, "                        ");
            __builder.OpenElement(128, "li");
            __builder.AddMarkupContent(129, "\r\n                            ");
            __builder.OpenElement(130, "label");
            __builder.AddAttribute(131, "class", "list-filter-label");
            __builder.AddMarkupContent(132, "\r\n");
#nullable restore
#line 77 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                                 if (isChecked)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(133, "                                    ");
            __builder.OpenElement(134, "input");
            __builder.AddAttribute(135, "type", "checkbox");
            __builder.AddAttribute(136, "class", "grid-filter-list");
            __builder.AddAttribute(137, "checked", true);
            __builder.AddAttribute(138, "value", 
#nullable restore
#line 79 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                                                                                                    isChecked

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(139, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 79 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                                                                                                                         e => IsNotNullHandler(e, isChecked)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n");
#nullable restore
#line 80 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(141, "                                    ");
            __builder.OpenElement(142, "input");
            __builder.AddAttribute(143, "type", "checkbox");
            __builder.AddAttribute(144, "class", "grid-filter-list");
            __builder.AddAttribute(145, "value", 
#nullable restore
#line 83 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                                                                                            isChecked

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(146, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                                                                                                                 e => IsNotNullHandler(e, isChecked)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n");
#nullable restore
#line 84 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(148, "                                ");
#nullable restore
#line 85 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
__builder.AddContent(149, Strings.IsNotNull);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(150, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n");
#nullable restore
#line 88 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(153, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n                ");
            __builder.OpenElement(155, "div");
            __builder.AddAttribute(156, "class", "grid-buttons");
            __builder.AddMarkupContent(157, "\r\n                    ");
            __builder.OpenElement(158, "div");
            __builder.AddAttribute(159, "class", "grid-filter-buttons");
            __builder.AddMarkupContent(160, "\r\n                        ");
            __builder.OpenElement(161, "button");
            __builder.AddAttribute(162, "type", "button");
            __builder.AddAttribute(163, "class", "btn btn-primary");
            __builder.AddAttribute(164, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 92 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                                                                                ApplyButtonClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(165, "\r\n                            ");
#nullable restore
#line 93 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
__builder.AddContent(166, Strings.ApplyFilterButtonText);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(167, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(168, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(169, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(170, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(172, "\r\n        ");
            __builder.OpenElement(173, "div");
            __builder.AddAttribute(174, "class", "grid-popup-additional");
            __builder.AddMarkupContent(175, "\r\n");
#nullable restore
#line 100 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
             if (_clearVisible)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(176, "                ");
            __builder.OpenElement(177, "ul");
            __builder.AddAttribute(178, "class", "menu-list");
            __builder.AddMarkupContent(179, "\r\n                    ");
            __builder.OpenElement(180, "li");
            __builder.AddMarkupContent(181, "\r\n                        ");
            __builder.OpenElement(182, "a");
            __builder.AddAttribute(183, "class", "grid-filter-clear");
            __builder.AddAttribute(184, "href", "javascript:void(0);");
            __builder.AddAttribute(185, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 104 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
                                                                                          ClearButtonClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(186, "\r\n                            ");
#nullable restore
#line 105 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
__builder.AddContent(187, Strings.ClearFilterLabel);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(188, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(189, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(190, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(191, "\r\n");
#nullable restore
#line 109 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(192, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(193, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(194, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(195, "\r\n");
#nullable restore
#line 113 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\ListFilterComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
