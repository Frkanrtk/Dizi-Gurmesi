<%@ Page Title="" Language="C#" MasterPageFile="~/userMasterPage.Master" AutoEventWireup="true" CodeBehind="userLegends.aspx.cs" Inherits="diziGurmesi3.userLegends" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .legends {
            margin-bottom: 20px;
            border: 1px solid #ccc;
            padding: 10px;
            display: flex; 
            align-items: center; 
        }

        .legends-foto {
            max-width: 200px;
            height: auto;
            margin-right: 10px; 
        }

        .legends-aciklama {
            font-style: italic;
        }
         .devam-link {
            margin-top: 10px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="userLegendsContainer" runat="server"></div>
</asp:Content>