<%@ Page Title="" Language="C#" MasterPageFile="~/WebForms/MainPage.Master" AutoEventWireup="true" CodeBehind="BillingPage.aspx.cs" Inherits="HospitalSoftware.WebForms.BillingPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentHolder" runat="server">
    <h1>Billing Section</h1>
    <div class="container">
        <div class="row">
           
                Enter Patient Id: 
                <asp:TextBox runat="server" CssClass="form-control" ID="txtpatientid" TextMode="Search" Width="300px" />                     
                <asp:Button Text="Search" CssClass="btn btn-danger" ID="btnsearch" runat="server" Width="100px" />
            
        </div>
        <hr />
        <hr />
        <div class="row">
            <div class="col-md-3">
                Bill No:<asp:TextBox Enabled="false" ID="txtbillno" CssClass="form-control" Width="200px" runat="server" />
            </div>
            <div class="col-md-3">
                Bill Date:<asp:TextBox runat="server" ID="txtdate" CssClass="form-control" Width="200px" Enabled="false" />
            </div>
            <hr />
            <div class="row">
                <p>Patient Name:<asp:TextBox runat="server" ID="txtpatientname" CssClass="form-control" Enabled="false" Width="700px" /></p>
                <p>Patient Mobile:<asp:TextBox runat="server" ID="txtpatientmobile" CssClass="form-control" Enabled="false" Width="700px" /></p>
                <p>Doctor Name Name:<asp:TextBox runat="server" ID="txtdoctorname" CssClass="form-control" Enabled="false" Width="700px" /></p>
                <p>Doctor Fees:<asp:TextBox runat="server" ID="txtfees" CssClass="form-control" Enabled="false" Width="700px" /></p>
                <p>
                    <asp:Button Text="Generate Bill" ID="btnbill" CssClass="btn btn-warning" runat="server" />
                </p>
            </div>
        </div>
    </div>
</asp:Content>
