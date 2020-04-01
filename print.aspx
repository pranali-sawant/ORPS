<%@ Page Language="C#" AutoEventWireup="true" CodeFile="print.aspx.cs" Inherits="print" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
 <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="generator" content="Mobirise v3.10.1, mobirise.com">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="shortcut icon" href="assets/images/logo-112x128-69.png" type="image/x-icon">
    <meta name="description" content="">
    <title></title>
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Lora:400,700,400italic,700italic&amp;subset=latin">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Montserrat:400,700">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Raleway:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i">
    <link rel="stylesheet" href="assets/bootstrap-material-design-font/css/material.css">
    <link rel="stylesheet" href="assets/tether/tether.min.css">
    <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css">
    <link rel="stylesheet" href="assets/animate.css/animate.min.css">
    <link rel="stylesheet" href="assets/dropdown/css/style.css">
    <link rel="stylesheet" href="assets/theme/css/style.css">
      <style type="text/css">
          .style1
        {
            width: 935px;
            border-style: solid;
            border-width: 4px;
              height: 192px;
              margin-top: 152px;
          }
          .style33
          {
              width: 185px;
              height: 30px;
          }
          .style34
          {
              width: 186px;
              height: 30px;
          }
          .style35
          {
              width: 185px;
              height: 31px;
          }
          .style36
          {
              width: 186px;
              height: 31px;
          }
          .style38
          {
              width: 185px;
              height: 31px;
              text-align: right;
          }
          .style39
          {
              width: 185px;
              height: 30px;
              text-align: right;
          }
          .style40
          {
              width: 186px;
              height: 31px;
              text-align: right;
          }
          .style41
          {
              width: 186px;
              height: 30px;
              text-align: right;
          }
          .navbar-brand
          {
              height: 94px;
          }
    </style>
    <link rel="stylesheet" href="assets/mobirise/css/mbr-additional.css" type="text/css">
    <script>
        function printpage() {

            var getpanel = document.getElementById("<%=Panel1.ClientID %>");
            var MainWindow = window.open('', '', 'height=500,width=800');
            MainWindow.document.write('<html><head><title>Online Railway Pass System</title>');
            MainWindow.document.write('</head><body>');
            MainWindow.document.write(getpanel.innerHTML);
            MainWindow.document.write('</body></html>');
            MainWindow.document.close();
            setTimeout(function () {
                MainWindow.print();
            }, 500);
            return false;

        }  
    
    </script>
</head>
<body>
    <form id="form1" runat="server">
     <section id="ext_menu-g">

    <nav class="navbar navbar-dropdown navbar-fixed-top">
        <div class="container">

            <div class="mbr-table">
                <div class="mbr-table-cell">

                    <div class="navbar-brand">
                        <a href="index.aspx" class="navbar-logo">
                        <img src="assets/images/logo-112x128-69.png"</a 
                            style="height: 73px; width: 72px">
                        <a class="navbar-caption" href="index.aspx">Online Railway Pass System</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </div>
                </div>
                <div class="mbr-table-cell">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="LOGOUT" />
                </div>
            </div>

        </div>
    </nav>


   </section>
    <section class="mbr-section mbr-section-hero mbr-section-full header2 mbr-parallax-background mbr-after-navbar"
        id="header2-3" style="background-image: url(assets/images/WATER.jpg);">
   
    <asp:Panel ID="Panel1" runat="server" Height="421px">   
         <table class="style1">
            <tr>
                <td class="style39">
                    <asp:Image ID="Image1" runat="server" Height="100px" 
                        ImageUrl="~/assets/images/OrrPS.png" />
                </td>
                <td class="style33">
                    &nbsp;</td>
                <td class="style33" style="text-align: center">
                    YOUR DETAILS<br />
                    <br />
                </td>
                <td class="style41">
                    &nbsp;</td>
                <td class="style34">
                <asp:PlaceHolder ID="plBarCode" runat="server" />
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style39">
                    NAME :</td>
                <td class="style33">
                    <asp:Label ID="Label14" runat="server"></asp:Label>
                </td>
                <td class="style33">
                    &nbsp;</td>
                <td class="style41">
                    &nbsp;</td>
                <td class="style34">
                    <asp:Label ID="Label18" runat="server" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style39">
                    FROM :</td>
                <td class="style33">
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                </td>
                <td class="style33">
                
                    &nbsp;</td>
                <td class="style41">
                    TO :</td>
                <td class="style34">
                    <asp:Label ID="Label5" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style39">
                    VIA :</td>
                <td class="style33">
                    <asp:Label ID="Label7" runat="server"></asp:Label>
                </td>
                <td class="style33">
                    &nbsp;</td>
                <td class="style41">
                    CLASS :</td>
                <td class="style34">
                    <asp:Label ID="Label16" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style38">
                    FARE :</td>
                <td class="style35">
                    <asp:Label ID="Label9" runat="server"></asp:Label>
                </td>
                <td class="style35">
                    &nbsp;</td>
                <td class="style40">
                    &nbsp;</td>
                <td class="style36">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style38">
                    VALID FROM :&nbsp; </td>
                <td class="style35">
                    <asp:Label ID="Label11" runat="server"></asp:Label>
                </td>
                <td class="style35">
                    &nbsp;</td>
                <td class="style40">
                    VALID TO :</td>
                <td id="1\" class="style36">
                    <asp:Label ID="Label13" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style38">
                    &nbsp;</td>
                <td class="style35">
                    &nbsp;</td>
                <td class="style35">
                    &nbsp;</td>
                <td class="style40">
                    &nbsp;</td>
                <td class="style36">
                    &nbsp;</td>
            </tr>
        </table> 
      </asp:Panel>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
   <asp:Button ID="Button1" runat="server" Text="PRINT" 
        OnClientClick="return printpage();" onclick="Button1_Click1" />
     </p>
  </section>
    </form>
</body>
</html>