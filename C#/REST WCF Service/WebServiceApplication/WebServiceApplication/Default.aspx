<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebServiceApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <!-- return false: wont perform PostBack operation -->
        <div class="row center">
            <div class="col-lg-3">
                <button id="getMethod" class="btn btn-default form-group" onclick="doGet(); return false;">GET Service Request</button>
            </div>
            <div class="col-lg-9 input-group">
                <input type="text" class="form-control" name="num" id="num" placeholder="Enter number to get square" />
                <input type="button" name="square" class="btn btn-default input-group-append" onclick="doPost();" value="POST Service Request" />
            </div>
        </div>
    </div>
    <script type="text/javascript">
        //GET data from service
        function doGet() {
            console.info("Hellooo..");

            $.ajax({
                url: "Service/RESTService.svc/DoGetRequest",
                type: "GET",
                dataType: "json",
                success: function (result) {
                    console.info(result);
                }
            });
        }

        //POST data to service
        function doPost() {
            var value = $('#num').val();
            $.ajax({
                url: "Service/RESTService.svc/DoPostRequest",
                data: JSON.stringify(value),
                type: "POST",
                dataType: "json",
                contentType: "application/json",
                success: function (result) {
                    console.info(result);
                }
            });

            $('#num').val('');
        }

        //Allow only numbers
        $('#num').keydown(function (e) {
            // Ensure that it is a number and stop the keypress
            if ((e.shiftKey || (e.keyCode < 48 || e.keyCode > 57)) && (e.keyCode < 96 || e.keyCode > 105)) {
                e.preventDefault();
            }
        });
    </script>
</asp:Content>
