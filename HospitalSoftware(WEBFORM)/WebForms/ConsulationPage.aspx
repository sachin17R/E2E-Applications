<%@ Page Title="" Language="C#" MasterPageFile="~/WebForms/MainPage.Master" AutoEventWireup="true" CodeBehind="ConsulationPage.aspx.cs" Inherits="HospitalSoftware.WebForms.ConsulationPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContentHolder" runat="server">
    <h1>Welcome For Consulatation Select The Patient</h1>
    <hr />
    <div class="row" style="text-align:center"> <asp:DropDownList ID="dpdoctors" runat="server" CssClass="form-control"  Width="500px" AutoPostBack="True" OnSelectedIndexChanged="dpdoctors_SelectedIndexChanged">
        </asp:DropDownList></div>
    <hr />
    <div class="container">
        <div class="row">
        <div class="col-md-4">
            <asp:TextBox runat="server" ID="txtsearch" TextMode="Search" CssClass="form-control" />   
            <hr />
            <asp:ListBox runat="server" ID="dppatientlist" Width="375px" CssClass="form-control" AutoPostBack="True" Height="300px" OnSelectedIndexChanged="dppatientlist_SelectedIndexChanged"></asp:ListBox>               
          
        </div>
        <div class="col-md-8">
            <h1>Details Of The Patient</h1>
            <p>Patient Id:<asp:TextBox runat="server" Enabled="false" ID="txtpatid" CssClass="form-control" Width="300px"/></p>
            <p>Patient Name:<asp:TextBox runat="server" Enabled="false" ID="txtname" CssClass="form-control" Width="300px"/></p>
            <p>Patient Age:<asp:TextBox runat="server" Enabled="false" ID="txtage" CssClass="form-control" Width="300px"/></p>
            <p>Patient Mobile:<asp:TextBox runat="server" Enabled="false" ID="txtmobile" CssClass="form-control" Width="300px"/></p>
            <p>
                <asp:Button Text="Diagnoise" ID="btndiagnoise" CssClass="btn btn-danger" runat="server" /></p>
        </div>
       </div>
    </div>
</asp:Content>
