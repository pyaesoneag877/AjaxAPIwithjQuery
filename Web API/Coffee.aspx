<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Coffee.aspx.cs" Inherits="Web_API.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href='<%= ResolveUrl("CSS/tab.css") %>' type="text/css"/>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="Breadcrumb" runat="server">
    <nav aria-label="breadcrumb">
      <ol class="breadcrumb">
        <li class="breadcrumb-item"><a href="http://localhost:3001/Home">Home</a></li>
        <li class="breadcrumb-item active" aria-current="page">Coffee</li>
      </ol>
    </nav>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <h3>Coffee</h3>
   <p id="infomation">
      Lorem ipsum dolor sit amet consectetur, adipisicing elit. Consectetur illum asperiores
      officiis nemo nobis corporis nulla quae unde quo? Dolorum, repudiandae nihil! Repellendus
      animi sed voluptatibus eius inventore alias debitis ipsa odit ducimus accusamus deserunt
      reiciendis rerum, ut tenetur aperiam molestias exercitationem qui tempora vitae explicabo
      commodi in nulla. Aut distinctio exercitationem quibusdam possimus rem dicta ad quisquam
      laudantium veritatis blanditiis? Vel consectetur odio, delectus, quae illum ipsum blanditiis
      amet vero fuga, nihil tempore. Minus eos quisquam quo quibusdam tempora ut molestiae commodi qui
      aliquid culpa! Cupiditate quod eum quis perspiciatis itaque nihil vero, similique eaque laborum
      magnam accusantium deleniti.</p>

   
  <div>
        <table class="table table-striped">
               <thead>
                  <tr>
                     <th scope="col">CoffeeTypeId</th>
                     <th scope="col">CoffeeType Name</th>
                     <th scope="col">Price</th>
                     <th scope="col" class="text-center" colspan="2">Actions</th>
                  </tr>
               </thead>
               <tbody id="tbodyCoffee">

               </tbody>
       </table>
  </div>
   
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHoldersJS" runat="server">
    <script src='<%= ResolveUrl("jQuery/jquery.js") %>' type="text/javascript"></script>
    <script src='<%= ResolveUrl("JavaScript/tab.js") %>' type="text/javascript"></script>
   
</asp:Content>
