<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="Websites.aspx.cs" Inherits="WebChecker.Websites" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container" >
        <div class="page-header">
            <h1>
                &nbsp; <i class="glyphicon glyphicon-globe" ></i>
                Website Lists
            </h1>
        </div>

        <div class="col-md-3" >
            <div class="list-group">
                <a href="#" class="btn btn-primary list-group-item" data-toggle="modal" data-target="#newWebModal" ><i class="glyphicon glyphicon-plus" ></i> Add Website</a>
                <a href="#" class="btn btn-primary list-group-item" data-toggle="modal" data-target="#changePass" ><i class="glyphicon glyphicon-cog"></i> Change Password</a>
            </div>
        </div>

        <div class="col-md-9" >
        </div>
    </div>

</asp:Content>
