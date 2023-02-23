<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CoffeeDetail.aspx.cs" Inherits="Web_API.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href='<%= ResolveUrl("CSS/tab.css") %>' type="text/css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Breadcrumb" runat="server">
    <nav aria-label="breadcrumb">
      <ol class="breadcrumb">
        <li class="breadcrumb-item"><a href="http://localhost:3001/Home">Home</a></li>
        <li class="breadcrumb-item"><a href="http://localhost:3001/Coffee">Coffee</a></li>
        <li class="breadcrumb-item active" aria-current="page">Coffee Detail</li>
      </ol>
    </nav>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Manage Coffee</h3>
   
   <div id="coffee-form">
       <form id="border">
             <div class="form-group" id="name">
                <label for="exampleInputName">Coffee Name</label>
                <input type="text" class="form-control" id="txtid" hidden>
                <input type="text" class="form-control" placeholder="Enter name" id="txtCoffeeName">
             </div>
             <div class="form-group" id="price">
                <label for="exampleInputPrice">Price</label>
                <input type="text" class="form-control" id="txtPrice" placeholder="Enter price">
                </div>
             <div id="button-group">
                <table>
                  <tr>
                       <td>
                            <button type="button" onclick="resetCoffee()" class="btn btn-success" id="reset">Reset</button>
                       </td>
                       <td>
                            <button type="button" onclick="saveCoffee()" class="btn btn-primary" id="update">Update</button>
                       </td>
                  </tr>
                </table>
            </div>
        </form>
  </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHoldersJS" runat="server">
    <script src='<%= ResolveUrl("jQuery/jquery.js") %>' type="text/javascript"></script>
    <script src='<%= ResolveUrl("JavaScript/Detail.js") %>' type="text/javascript"></script>
</asp:Content>
