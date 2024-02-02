<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="KategoriDizileri.aspx.cs" Inherits="diziGurmesi3.KategoriDizileri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .dizi {
            margin-bottom: 20px;
            border: 1px solid #ccc;
            padding: 10px;
            display: flex;
            align-items: center;
        }

        .dizi-foto {
            max-width: 200px;
            height: auto;
            margin-right: 10px;
        }

        .dizi-aciklama {
            font-style: italic;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="diziContainer" runat="server" class="container">
        <% FetchAndBindCategoryData(); %>
    </div>
</asp:Content>