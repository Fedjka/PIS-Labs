﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:Label class="lead" ID="Label1" runat="server" Text="Label"></asp:Label><br />
        <asp:TextBox class="lead" ID="TextBox1" runat="server">Text</asp:TextBox>
        <asp:Button class="lead" ID="Button1" runat ="server"  OnClick="Button1_Click" Text="Button" /><br />
        <asp:DropDownList class="lead" ID="DropDownList1" runat="server" AutoPostBack = "true" OnSelectedIndexChanged = "OnSelectedIndexChanged">
            <asp:ListItem>da</asp:ListItem>
            <asp:ListItem>net</asp:ListItem>
        </asp:DropDownList><br />
        <asp:CheckBox class="lead" ID="CheckBox1" runat="server" />
        <asp:CheckBox class="lead" ID="CheckBox2" runat="server" />



    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>
</asp:Content>
