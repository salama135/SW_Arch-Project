<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Diet_Recommendation.aspx.cs" Inherits="BPT_Consumer.Diet_Recommendation" %>

<!doctype html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <meta name="description" content="" />
        <meta name="author" content="Mark Otto, Jacob Thornton, and Bootstrap contributors" />
        <meta name="generator" content="Hugo 0.79.0" />
        <title>BPT - Diet Recommendation</title>

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
            .auto-style1 {
                width: 258px;
            }
            .auto-style5 {
                width: 364px;
            }
            .auto-style6 {
                width: 216px;
            }
            .auto-style7 {
                width: 193px;
            }
            .auto-style10 {
                width: 193px;
                font-weight: normal;
            }
        </style>

        <!-- Custom styles for this template -->
        <link href="pricing.css" rel="stylesheet" />
        <link href="dashboard.css" rel="stylesheet" />
  </head>

  <body>
    
        <script src="./assets/dist/js/bootstrap.bundle.min.js"></script>
        <script src="https://cdn.jsdelivr.net/npm/feather-icons@4.28.0/dist/feather.min.js" integrity="sha384-uO3SXW5IuS1ZpFPKugNNWqTZRRglnUJK6UAZ/gxOX80nxEkN9NcGZTftn6RzhGWE" crossorigin="anonymous"></script>
        <script src="https://cdn.jsdelivr.net/npm/chart.js@2.9.4/dist/Chart.min.js" integrity="sha384-zNy6FEbO50N+Cg5wap8IKA4M/ZnLJgzc6w2NqACZaK0u0FXfOWRRJOnQtpZun8ha" crossorigin="anonymous"></script>
        <script src="dashboard.js"></script>



      <table class="table" runat="server" id="table1">
  <thead>
    <tr>
      <th scope="col" class="auto-style1">&nbsp;</th>
      <th scope="col" class="auto-style7">&nbsp;</th>
      <th scope="col" class="auto-style7">&nbsp;</th>
      <th scope="col" class="auto-style6">Diet plan</th>
      <th scope="col" class="auto-style5">&nbsp;</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <th scope="row" class="auto-style1">Days/Meals</th>
      <th scope="row" class="auto-style7">Meal 1 </th>
      <th scope="row" class="auto-style7">Meal 2</th>
      <td class="auto-style6">Meal 3</td>
      <td class="auto-style5">Meal 4</td>
    </tr>

    <tr class="table-primary">
      <th scope="row" class="auto-style1">Day 1</th>
      <th scope="row" class="auto-style10">&nbsp;</th>
      <th scope="row" class="auto-style10">&nbsp;</th>
      <td class="auto-style6">&nbsp;</td>
      <td class="auto-style5">&nbsp;</td>
    </tr>
    <tr class="table-secondary">
      <th scope="row" class="auto-style1">Day 2</th>
      <th scope="row" class="auto-style10">&nbsp;</th>
      <th scope="row" class="auto-style10">&nbsp;</th>
      <td class="auto-style6">&nbsp;</td>
      <td class="auto-style5">&nbsp;</td>
    </tr>
    <tr class="table-success">
      <th scope="row" class="auto-style1">Day 3</th>
      <th scope="row" class="auto-style10">&nbsp;</th>
      <th scope="row" class="auto-style10">&nbsp;</th>
      <td class="auto-style6">&nbsp;</td>
      <td class="auto-style5">&nbsp;</td>
    </tr>
    <tr class="table-danger">
      <th scope="row" class="auto-style1">Day 4</th>
      <th scope="row" class="auto-style10">&nbsp;</th>
      <th scope="row" class="auto-style10">&nbsp;</th>
      <td class="auto-style6">&nbsp;</td>
      <td class="auto-style5">&nbsp;</td>
    </tr>
  </tbody>
</table>
    </body>
</html>
