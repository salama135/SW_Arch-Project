<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Diet_Recommendation.aspx.cs" Inherits="BPT_Consumer.Diet_Recommendation" %>

<!doctype html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <meta name="description" content="" />
        <meta name="author" content="Mark Otto, Jacob Thornton, and Bootstrap contributors" />
        <meta name="generator" content="Hugo 0.79.0" />
        <title>BPT - Diet - Recommendation</title>

        <!-- Bootstrap core CSS -->
        <link href="./assets/dist/css/bootstrap.min.css" rel="stylesheet" />

        <style>
          .bd-placeholder-img {
            font-size: 1.125rem;
            text-anchor: middle;
            -webkit-user-select: none;
            -moz-user-select: none;
            user-select: none;
          }

          @media (min-width: 768px) {
            .bd-placeholder-img-lg {
              font-size: 3.5rem;
            }
          }
            .auto-style3 {
                left: 0px;
                top: 0;
            }
            .auto-style7 {
                width: 274px;
            }
            .auto-style11 {
                width: 254px;
            }
            .auto-style13 {
                width: 186px;
            }
            .auto-style15 {
                width: 191px;
            }
            .auto-style17 {
                width: 189px;
            }
            .auto-style24 {
                width: 186px;
                height: 39px;
            }
            .auto-style25 {
                width: 189px;
                height: 39px;
            }
            .auto-style26 {
                width: 274px;
                height: 39px;
            }
            .auto-style27 {
                width: 254px;
                height: 39px;
            }
            .auto-style28 {
                width: 191px;
                height: 39px;
            }
            .auto-style29 {
                width: 186px;
                height: 46px;
            }
            .auto-style30 {
                width: 189px;
                height: 46px;
            }
            .auto-style31 {
                width: 274px;
                height: 46px;
            }
            .auto-style32 {
                width: 254px;
                height: 46px;
            }
            .auto-style33 {
                width: 191px;
                height: 46px;
            }
            .auto-style34 {
                width: 186px;
                height: 47px;
            }
            .auto-style35 {
                width: 189px;
                height: 47px;
            }
            .auto-style36 {
                width: 274px;
                height: 47px;
            }
            .auto-style37 {
                width: 254px;
                height: 47px;
            }
            .auto-style38 {
                width: 191px;
                height: 47px;
            }
        </style>

        <!-- Custom styles for this template -->
        <link href="pricing.css" rel="stylesheet" />
        <link href="dashboard.css" rel="stylesheet" />
  </head>

  <body>
    
    <header class="auto-style3">
    </header>
    
        <script src="./assets/dist/js/bootstrap.bundle.min.js"></script>
        <script src="https://cdn.jsdelivr.net/npm/feather-icons@4.28.0/dist/feather.min.js" integrity="sha384-uO3SXW5IuS1ZpFPKugNNWqTZRRglnUJK6UAZ/gxOX80nxEkN9NcGZTftn6RzhGWE" crossorigin="anonymous"></script>
        <script src="https://cdn.jsdelivr.net/npm/chart.js@2.9.4/dist/Chart.min.js" integrity="sha384-zNy6FEbO50N+Cg5wap8IKA4M/ZnLJgzc6w2NqACZaK0u0FXfOWRRJOnQtpZun8ha" crossorigin="anonymous"></script>
        <script src="dashboard.js"></script>

       <!-- new table -->
       <table  class="table" runat="server" id="table1">
  <thead>
    <tr>
      <th scope="col" class="auto-style13"></th>
      <th scope="col" class="auto-style17">&nbsp;</th>
      <th scope="col" class="auto-style7">&nbsp;</th>
      <th scope="col" class="auto-style11">Diet plan</th>
      <th scope="col" class="auto-style15"></th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <th scope="row" class="auto-style13">Days</th>
      <td class="auto-style17">Meal 1</td>
      <td class="auto-style7">Meal 2</td>
      <td class="auto-style11">Meal 3</td>
      <td class="auto-style15">Meal 4</td>
    </tr>

    <tr class="table-primary">
      <th scope="row" class="auto-style24">Day 1</th>
      <td class="auto-style25"></td>
      <td class="auto-style26"></td>
      <td class="auto-style27"></td>
      <td class="auto-style28"></td>
    </tr>
    <tr class="table-secondary">
      <th scope="row" class="auto-style24">Day 2</th>
      <td class="auto-style25"></td>
      <td class="auto-style26"></td>
      <td class="auto-style27"></td>
      <td class="auto-style28"></td>
    </tr>
    <tr class="table-success">
      <th scope="row" class="auto-style29">Day 3</th>
      <td class="auto-style30"></td>
      <td class="auto-style31"></td>
      <td class="auto-style32"></td>
      <td class="auto-style33"></td>
    </tr>
    <tr class="table-danger">
      <th scope="row" class="auto-style34">Day 4</th>
      <td class="auto-style35"></td>
      <td class="auto-style36"></td>
      <td class="auto-style37"></td>
      <td class="auto-style38"></td>
    </tr>
  </tbody>
</table>
      
    </body>
</html>
