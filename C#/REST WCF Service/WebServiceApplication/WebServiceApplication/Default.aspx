<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebServiceApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">   
        <div class="form-inline">
            <!-- return false: wont perform PostBack operation -->
            <label>GET Request Service:   </label>
            <button class="btn btn-info" onclick="doGet(); return false;">Do Request</button>
        </div>
        <p></p>
        <div class="form-inline">
            <label>POST Request Service:</label>
            <input type="text" name="squre" id="num" class="form-control" placeholder="Enter number to square"/>
            <button class="btn btn-warning" onclick="doPost();">Square Number</button>
        </div>
        <p></p>
        <div class="form-inline">
            <label>Using Custom Classes:</label>
            <input type="text" name="val1" id="val1" class="form-control" placeholder="Enter Value 1" />
            <input type="text" name="val2" id="val2" class="form-control" placeholder="Enter Value 2"/>
            <button class="btn btn-success" onclick="doAddValues();">Add Values</button>
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

            if (value == "")
                alert("Please key in the number");

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

        function doAddValues() {

            if ($("#val1").val() == "" && $("#val2").val() == "")
                alert("Please enter value 1 and value 2");
            if ($("#val1").val() == "")
                alert("Please enter value 1");
            else if ($("#val2").val() == "")
                alert("Please enter value 2");

            var addValues = {
                //note: mention property names as specified in the AddValue class
                "value1": $("#val1").val(),
                "value2": $("#val2").val()
            };

            $.ajax({
                url: "Service/RESTService.svc/DoAddValues",
                data: JSON.stringify(addValues),
                type: "POST",
                datatype: "json",
                contentType: "application/json",
                success: function (result) {
                    console.info(result);
                },
                error: function (err) {
                    console.info(err);
                }
            });
        }
    </script>
</asp:Content>
