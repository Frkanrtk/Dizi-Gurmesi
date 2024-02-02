<%@ Page Title="" Language="C#" MasterPageFile="~/userMasterPage.Master" AutoEventWireup="true" CodeBehind="userAllSeries.aspx.cs" Inherits="diziGurmesi3.userAllSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .all-series {
            margin-bottom: 20px;
            border: 1px solid #ccc;
            padding: 10px;
            display: flex; 
            align-items: center; 
        }

        .all-series-foto {
            max-width: 200px;
            height: auto;
            margin-right: 10px; 
        }

        .all-series-aciklama {
            font-style: italic;
        }
        .devam-link {
            margin-top: 10px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="userAllSeriesContainer" runat="server"></div>
</asp:Content>
