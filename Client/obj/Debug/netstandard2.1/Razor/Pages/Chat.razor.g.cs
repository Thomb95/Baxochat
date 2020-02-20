#pragma checksum "C:\Users\Thoma\source\repos\baxochat\baxochat\Client\Pages\Chat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "593b287226df63b989157db1552d578749800910"
// <auto-generated/>
#pragma warning disable 1591
namespace baxochat.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Thoma\source\repos\baxochat\baxochat\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Thoma\source\repos\baxochat\baxochat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Thoma\source\repos\baxochat\baxochat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Thoma\source\repos\baxochat\baxochat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Thoma\source\repos\baxochat\baxochat\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Thoma\source\repos\baxochat\baxochat\Client\_Imports.razor"
using baxochat.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Thoma\source\repos\baxochat\baxochat\Client\_Imports.razor"
using baxochat.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Thoma\source\repos\baxochat\baxochat\Client\Pages\Chat.razor"
using baxochat.Shared.ChatClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Thoma\source\repos\baxochat\baxochat\Client\Pages\Chat.razor"
using baxochat.Shared.ChatClient.Events;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chat")]
    public partial class Chat : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "C:\Users\Thoma\source\repos\baxochat\baxochat\Client\Pages\Chat.razor"
 if (!_started)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "type", "text");
            __builder.AddAttribute(3, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\Thoma\source\repos\baxochat\baxochat\Client\Pages\Chat.razor"
                              _userName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _userName = __value, _userName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Thoma\source\repos\baxochat\baxochat\Client\Pages\Chat.razor"
                       Login

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Login");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 11 "C:\Users\Thoma\source\repos\baxochat\baxochat\Client\Pages\Chat.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "    ");
            __builder.OpenElement(11, "div");
            __builder.AddMarkupContent(12, "\r\n        Logged in as user: ");
            __builder.AddContent(13, 
#nullable restore
#line 15 "C:\Users\Thoma\source\repos\baxochat\baxochat\Client\Pages\Chat.razor"
                            _userName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 18 "C:\Users\Thoma\source\repos\baxochat\baxochat\Client\Pages\Chat.razor"
         foreach (Message message in _messages)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "            ");
            __builder.OpenComponent<baxochat.Client.Shared.Message>(19);
            __builder.AddAttribute(20, "UserName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\Thoma\source\repos\baxochat\baxochat\Client\Pages\Chat.razor"
                                message.UserName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "Content", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\Thoma\source\repos\baxochat\baxochat\Client\Pages\Chat.razor"
                                                            message.Content

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 21 "C:\Users\Thoma\source\repos\baxochat\baxochat\Client\Pages\Chat.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.AddContent(25, "    ");
            __builder.OpenElement(26, "div");
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "type", "text");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\Thoma\source\repos\baxochat\baxochat\Client\Pages\Chat.razor"
                                   _currentMessage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _currentMessage = __value, _currentMessage));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Thoma\source\repos\baxochat\baxochat\Client\Pages\Chat.razor"
                           SendMessage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, "Send");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 28 "C:\Users\Thoma\source\repos\baxochat\baxochat\Client\Pages\Chat.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\Thoma\source\repos\baxochat\baxochat\Client\Pages\Chat.razor"
 
    Client _client;

    string _userName;

    bool _started = false;

    IList<Message> _messages = new List<Message>();

    string _currentMessage = "";


    async Task Login()
    {
        if (string.IsNullOrEmpty(_userName))
        {
            return;
        }

        _client = new Client(_userName, navigationManager);

        _client.MessageReceived += MessageReceived;

        await _client.StartAsync();

        _started = true;
    }

    async Task SendMessage()
    {
        if (String.IsNullOrWhiteSpace(_currentMessage))
        {
            return;
        }

        await _client.SendMessage(_currentMessage);

        _currentMessage = "";
    }

    void MessageReceived(object sender, MessageReceivedEventArgs e)
    {
        Message message = new Message(e.UserName, e.Message);

        _messages.Add(message);

        StateHasChanged();
    }

    class Message
    {
        public Message(string userName, string content)
        {
            UserName = userName;
            Content = content;
        }

        public string UserName;

        public string Content;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591