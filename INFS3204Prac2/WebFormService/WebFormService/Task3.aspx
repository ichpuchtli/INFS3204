<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Task3.aspx.cs" Inherits="WebFormService.About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <asp:ScriptManager ID="ScriptManager1" runat="server">
    <Services>
        <asp:ServiceReference Path="~/WebService2.asmx" />
    </Services>
    </asp:ScriptManager>

    <br />

    <asp:Label ID="Time" runat="server" Text="The first run recorded at: "></asp:Label>

    <hr />

    <div class="row">
        <div class="col-xs-8 form-group">
            <input id="Username" class="form-control" placeholder="Enter Username" />
        </div>
        <div class="col-xs-4 form-group">
            <button id="RegisterBtn" class="btn btn-primary">Register</button>
        </div>
    </div>

    <label id="Result" class="alert alert-success"></label>

    <script type="text/javascript">

        function GenRandomPassword() {
            //see https://stackoverflow.com/questions/1349404/generate-a-string-of-5-random-characters-in-javascript
            return (Math.random().toString(36) + '00000000000000000').slice(2, 16 + 2);
        }

        $('#RegisterBtn').click(function (e) {

            WebFormService.WebService2.Register($get("Username").value, GenRandomPassword(), onSuccess, onFailure)

            e.preventDefault();
            return false;

        });

        var onSuccess = function (result) {
            $get("Result").innerHTML = result;
        }

        var onFailure = function (result) {
            alert("AJAX Request Failed");
        }

    </script>

</asp:Content>

