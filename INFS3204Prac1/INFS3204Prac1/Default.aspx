<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="INFS3204Prac1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br />

    <div class="radio">
        <asp:RadioButtonList ID="EvenOddRadioBtn" runat="server">
            <asp:ListItem>Even</asp:ListItem>  
            <asp:ListItem>Odd</asp:ListItem>  
            <asp:ListItem Selected="True">Both</asp:ListItem>  
        </asp:RadioButtonList>
    </div>

    <div class="checkbox">
        <asp:CheckBox ID="RemoveDuplicates" runat="server" Text="Remove Duplicates" />
    </div>

    <asp:TextBox class="form-control" ID="NumberTextBox" runat="server" Rows="3" TextMode="MultiLine"></asp:TextBox>
    <br />

    <asp:Button class="btn btn-primary btn-lg" ID="ClassifyBtn" runat="server" Text="Classify" OnClick="ClassifyBtn_Click" />
    <br />
    <br />

    <div class="row">
        <div class="col-sm-6">
            <asp:Label ID="Label1" runat="server" Text="Even Numbers"></asp:Label>
            <asp:ListBox class="form-control" ID="EvenListBox" runat="server"></asp:ListBox>
        </div>

        <div class="col-sm-6">
            <asp:Label ID="Label2" runat="server" Text="Odd Numbers"></asp:Label>
            <asp:ListBox class="form-control" ID="OddListBox" runat="server"></asp:ListBox>
        </div>
    </div>

</asp:Content>
