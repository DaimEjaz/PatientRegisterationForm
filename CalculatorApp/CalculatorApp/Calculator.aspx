<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="CalculatorApp.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator App</title>
    <link rel="stylesheet" href="styles.css" />
        
</head>
<body>
    <form id="form1" runat="server">
        <div class="form">
           
            <asp:Label ID="labelX" runat="server" for="numX" CssClass="label">Enter first number: </asp:Label>
            <asp:TextBox id="numX" runat="server" type="text" CssClass="input"/>
            <asp:Label ID="labelY" runat="server" for="numY"  CssClass="label">Enter second number: </asp:Label>
            <asp:TextBox id="numY" runat="server" type="text" CssClass="input"/>

            <asp:Label runat="server"  CssClass="label">Select an operation to perform: </asp:Label>
            <asp:DropDownList id="dropdown" runat="server" CssClass="select">
                <asp:ListItem value="--select--">--select--</asp:ListItem>

                <asp:ListItem value="+">Addition</asp:ListItem>
                <asp:ListItem value="-">Subtraction</asp:ListItem>
                <asp:ListItem value="*">Multiplication</asp:ListItem>
                <asp:ListItem value="/">Division</asp:ListItem>

            </asp:DropDownList>
<%--            <asp:TextBox id="answer" runat="server" type="text"/>--%>

            <asp:Button runat="server" Text="Calculate" CssClass="formBtn" ID="btnSubmit" OnClientClick="javascript: return Validate()" OnClick="Calculate" />

        </div>
    

    </form>

    <script type="text/javascript">

        const answer = document.getElementById("answer");

        function Validate() {
            var num1 = document.getElementById("numX").value;
            var dropDown = document.getElementById("dropdown");

            var num2 = document.getElementById("numY").value;
            var option = dropDown.options[dropDown.selectedIndex];


            if (isNaN(num1) || !num1) {
                alert("First number X is invalid");
                return false;
            } 
                
            if (isNaN(num2) || !num2) {
                alert("Second number Y is invalid");
                return false;
            }
            
            if (option.value === "--select--") {
                alert("Please select a valid operation");
                return false;
            }
            if (option.value === "/" && num2 == 0) {
                alert("Can not divide by zero. Please modify number Y")
                return false;
            }
            return true;

        }
    </script>
</body>
</html>
