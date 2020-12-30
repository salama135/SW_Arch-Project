<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BPT_Consumer._Default" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron text-white jumbotron-image shadow" style="background-image: url(./BloodPressure.jpg);">
        <div class="row align-items-center">
            <div class="col">

                <h2 >Welcome to </h2>
                <h1>Blood Pressure Tracker</h1>
                <br />
                <p>
                    <asp:Button class="btn btn-primary btn-lg" ID="Button1" runat="server" OnClick="Button1_Click1" Text="Register" />
                     &nbsp;OR 
                    <asp:Button class="btn btn-success btn-lg" ID="Button2" runat="server" OnClick="Button2_Click1" Text="SignIn" />
                </p>
            </div>

        </div>
    </div>

</asp:Content>
