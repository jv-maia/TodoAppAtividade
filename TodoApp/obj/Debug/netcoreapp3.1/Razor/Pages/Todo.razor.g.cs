#pragma checksum "C:\Users\sayne\Downloads\TodoApp\TodoApp\Pages\Todo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba95baffbf747635de2b1f2754cfbf703a1b6cb5"
// <auto-generated/>
#pragma warning disable 1591
namespace TodoApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sayne\Downloads\TodoApp\TodoApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sayne\Downloads\TodoApp\TodoApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sayne\Downloads\TodoApp\TodoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sayne\Downloads\TodoApp\TodoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sayne\Downloads\TodoApp\TodoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sayne\Downloads\TodoApp\TodoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sayne\Downloads\TodoApp\TodoApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sayne\Downloads\TodoApp\TodoApp\_Imports.razor"
using TodoApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sayne\Downloads\TodoApp\TodoApp\_Imports.razor"
using TodoApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sayne\Downloads\TodoApp\TodoApp\Pages\Todo.razor"
using TodoApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class Todo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "Lista de Tarefas (");
            __builder.AddContent(2, 
#nullable restore
#line 4 "C:\Users\sayne\Downloads\TodoApp\TodoApp\Pages\Todo.razor"
                       todos.Count(todo => !todo.IsDone)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "ul");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 7 "C:\Users\sayne\Downloads\TodoApp\TodoApp\Pages\Todo.razor"
     foreach (var todo in todos)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "        ");
            __builder.OpenElement(8, "li");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "checkbox");
            __builder.AddAttribute(12, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\sayne\Downloads\TodoApp\TodoApp\Pages\Todo.razor"
                                          todo.IsDone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todo.IsDone = __value, todo.IsDone));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddContent(14, " ");
            __builder.AddContent(15, 
#nullable restore
#line 10 "C:\Users\sayne\Downloads\TodoApp\TodoApp\Pages\Todo.razor"
                                                           todo.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(16, "\r\n        \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 13 "C:\Users\sayne\Downloads\TodoApp\TodoApp\Pages\Todo.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "placeholder", "Add Tarefa");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\sayne\Downloads\TodoApp\TodoApp\Pages\Todo.razor"
                                       newTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newTodo = __value, newTodo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\sayne\Downloads\TodoApp\TodoApp\Pages\Todo.razor"
                  AddTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "Add todo");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\sayne\Downloads\TodoApp\TodoApp\Pages\Todo.razor"
       
    private IList<TodoItem> todos = new List<TodoItem>();
    private string newTodo;

    private void AddTodo()
    {
        if (!string.IsNullOrWhiteSpace(newTodo))
        {
            todos.Add(new TodoItem { Title = newTodo });
            newTodo = string.Empty;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
