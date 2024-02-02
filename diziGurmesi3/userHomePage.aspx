<%@ Page Title="" Language="C#" MasterPageFile="~/userMasterPage.Master" AutoEventWireup="true" CodeBehind="userHomePage.aspx.cs" Inherits="diziGurmesi3.userHomePage1" %>
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

    .devam-link {
            margin-top: 10px;
        }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="banner-container">
        <div class="banner-parca banner-buyuk">
            <img src="bbanner.jpg" alt="Büyük Banner" class="img-fluid" />
        </div>
    </div>
    <div id="userDiziContainer" runat="server"></div>
</asp:Content>
