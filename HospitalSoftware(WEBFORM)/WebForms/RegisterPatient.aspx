<%@ Page Title="" Language="C#" MasterPageFile="~/WebForms/MainPage.Master" AutoEventWireup="true" CodeBehind="RegisterPatient.aspx.cs" Inherits="HospitalSoftware.WebForms.RegisterPatient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContentHolder" runat="server">
    <div class="container">
        <div class="row">
            <p>Patient Name
                <asp:TextBox runat="server" id="txtname" CssClass="form-control" Width="300px" />
            </p>
            <p>Patient Mobile
                <asp:TextBox runat="server" id="txtmobile" CssClass="form-control" Width="300px" />
            </p>
            <p>Patient DOB
                <asp:TextBox runat="server" id="txtdob" TextMode="Date" CssClass="form-control" Width="300px" />
            </p>
            <p>
                Select Doctor:
                <asp:DropDownList runat="server" ID="dpdoctors" CssClass="form-control" Width="300px">                 
                </asp:DropDownList>
            </p>
            <p>
                <asp:Button Text="Register" ID="btnregister" CssClass="btn btn-success" runat="server" Width="100px" OnClick="btnregister_Click" />
            </p>
            <p>
                <asp:Label ID="lbldisplay"  runat="server" ForeColor="#FF0066" />
            </p>
        </div>
    </div>
</asp:Content>
