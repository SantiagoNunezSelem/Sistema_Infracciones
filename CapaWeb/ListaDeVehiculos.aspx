<%@ Page Title="Lista de vechísulos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaDeVehiculos.aspx.cs" Inherits="CapaWeb._ListaDeVehiculos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
    <style>
    
        .container2 {
            margin: auto;
            background-color: #fff;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            text-align: center;
            width: 40%;
        }
        select, input[type="submit"] {
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
        <div class="container2">
            <h2>Seleccionar Vehículo</h2>
            <asp:DropDownList ID="ddlVehiculos" runat="server"></asp:DropDownList>
            <br />
            <asp:Button ID="btnSelect" runat="server" Text="Ver Infracciones" OnClick="btnSelect_Click" />
        </div>
    </section>
    </main>
</asp:Content>