<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebServiceApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <!-- return false: wont perform PostBack operation -->
        <button onclick="doWork(); return false;">Do Work</button>
    </div>
    <script type="text/javascript">
        function doWork() {
            console.info("Hellooo..");

            $.ajax({
                url: "Service/RESTService.svc/DoWork",
                type: "GET",
                dataType: "json",
                success: function (result) {
                    console.info(result);
                }
            })
        }
    </script>
</asp:Content>
