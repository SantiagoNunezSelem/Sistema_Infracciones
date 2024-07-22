<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="infracciones.aspx.cs" Inherits="CapaWeb.infracciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Infracciones del vehículo </title>
          <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f0f0f0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }
        .container {
            background-color: #fff;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            text-align: center;
            width: 500px;
        }
        .section {
            margin: 20px 0;
        }
        .section h3 {
            margin: 0;
            padding: 10px;
            background-color: #007bff;
            color: white;
            border-radius: 5px 5px 0 0;
        }
        .section ul {
            list-style-type: none;
            padding: 0;
            margin: 0;
            border: 1px solid #ccc;
            border-radius: 0 0 5px 5px;
        }
        .section ul li {
            padding: 10px;
            border-bottom: 1px solid #ccc;
        }
        .section ul li:last-child {
            border-bottom: none;
        }
        .pdf-button {
            margin-top: 20px;
            padding: 5px;
            background-color: #007bff;
            color: white;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }
        .pdf-button:hover {
            background-color: #0056b3;
        }
        .dropdown {
            margin-bottom: 20px;
        }
    </style>
</head>
<body>
           <form id="form1" runat="server">
        <div class="container">
            <h2>Infracciones del Vehículo <asp:Label runat="server" id="labelTitle"/></h2>
            <div class="section">
                <h3>Infracciones Pagas</h3>
                <asp:Repeater ID="rptInfraccionesPagas" runat="server">
                    <ItemTemplate>
                        <li><%# Container.DataItem %></li>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <div class="section">
                <h3>Infracciones Impagas</h3>
                <asp:Repeater ID="rptInfraccionesImpagas" runat="server">
                    <ItemTemplate>
                        <li>
                            <%# Container.DataItem %> 
                            <asp:Button ID="btnGeneratePDF" runat="server" Text="Generar PDF" CssClass="pdf-button" CommandArgument='<%# Container.DataItem %>' OnClick="btnGeneratePDF_Click" />
                        </li>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </form>
</body>
</html>
