<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CapaWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
       <title>Ingresar DNI</title>
    <style>
      /*  body {
            font-family: Arial, sans-serif;
            background-color: #f0f0f0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }*/
        .container {
            background-color: #fff;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            text-align: center;
        }
        input[type="text"], input[type="submit"] {
            padding: 10px;
            margin: 10px 0;
            width: 80%;
            border: 1px solid #ccc;
            border-radius: 5px;
        }
        input[type="submit"] {
            background-color: #007bff;
            color: white;
            border: none;
            cursor: pointer;
        }
        input[type="submit"]:hover {
            background-color: #0056b3;
        }
    </style>
    <section runat="server">
        <h1>Consulta de infracciones de vehículos</h1>
        <div class="container">
            <h2>Ingresar el DNI del Propietario</h2>
            <asp:TextBox ID="txtDNI" runat="server" placeholder="Ingrese DNI"></asp:TextBox>
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Buscar vehículos asociados" OnClick="btnSubmit_Click" />
        </div>
        <asp:Label runat="server" ID="informationLabel" />
    </section>
    </main>

</asp:Content>
