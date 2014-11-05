<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Task2.aspx.cs" Inherits="WebFormService.Contact" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <br />

    <div class="row">

        <div class="col-sm-2 form-group">

            <asp:TextBox ID="Weight" runat="server" class="form-control" placeholder="Weight (g)"></asp:TextBox>
        </div>

        <div class="col-sm-3 form-group">
            <asp:DropDownList ID="FoodDropDown" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>

        <div class="col-sm-1 form-group">
            <asp:Button OnClick="AddBtn_Click" ID="AddBtn" runat="server" Text="Add &raquo;" CssClass="btn btn-primary" />
        </div>

        <div class="col-sm-3 form-group">
            <asp:ListBox CssClass="form-control" ID="Weights" runat="server"></asp:ListBox>
        </div>

        <div class="col-sm-3 form-group">
            <asp:ListBox CssClass="form-control" ID="FoodNames" runat="server"></asp:ListBox>

        </div>


    </div>

    <asp:RequiredFieldValidator class="alert alert-danger" ControlToValidate="Weight" Display="Static" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Weight field is required"></asp:RequiredFieldValidator>

    <hr />

    <div class="row">

        <p class="col-sm-4">
            <asp:Button OnClick="ResetBtn_Click" ID="ResetBtn" runat="server" Text="Reset" CssClass="btn btn-default" />
            <asp:Button OnClick="CalculateBtn_Click" ID="CalculateBtn" runat="server" Text="Calculate" CssClass="btn btn-success" />
        </p>
        <p class="col-sm-4">
            <asp:Label ID="TotalFat" runat="server" Text="Total Fat (g): "></asp:Label>
        </p>
        <p class="col-sm-4">
            <asp:Label ID="TotalCalories" runat="server" Text="Total Calories: "></asp:Label>
        </p>
    </div>

</asp:Content>
