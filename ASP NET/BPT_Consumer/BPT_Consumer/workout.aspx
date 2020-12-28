<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Workout.aspx.cs" Inherits="BPT_Consumer.Workout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>BPT - Workout Recommendation</title>
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
                width: 238px;
            }
            .auto-style2 {
                font-size: large;
            }
        </style>

        <!-- Custom styles for this template -->
        <link href="pricing.css" rel="stylesheet" />
        <link href="dashboard.css" rel="stylesheet" />
</head>
<body>
    <main class="col-md-9 ms-sm-auto col-lg-10 px-md-4">
   
       <table class="table" runat="server" id="tabel2">
  <thead>
    <tr>
      <th scope="col" colspan="2" class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Workout Plan</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <th scope="row" class="auto-style1">Days/Workouts</th>
      <td><strong>Workout</strong></td>
    </tr>

    <tr class="table-primary">
      <th scope="row" class="auto-style1">Day 1</th>
      <td>&nbsp;</td>
    </tr>
    <tr class="table-secondary">
      <th scope="row" class="auto-style1">Day 2</th>
      <td>&nbsp;</td>
    </tr>
    <tr class="table-success">
      <th scope="row" class="auto-style1">Day 3</th>
      <td>&nbsp;</td>
    </tr>
    <tr class="table-danger">
      <th scope="row" class="auto-style1">Day 4</th>
      <td>&nbsp;</td>
    </tr>
    <tr class="table-warning">
      <th scope="row" class="auto-style1">Day 5</th>
      <td>&nbsp;</td>
    </tr>
  </tbody>
</table>
        </main>
   
     <script src="./assets/dist/js/bootstrap.bundle.min.js"></script>
        <script src="https://cdn.jsdelivr.net/npm/feather-icons@4.28.0/dist/feather.min.js" integrity="sha384-uO3SXW5IuS1ZpFPKugNNWqTZRRglnUJK6UAZ/gxOX80nxEkN9NcGZTftn6RzhGWE" crossorigin="anonymous"></script>
        <script src="https://cdn.jsdelivr.net/npm/chart.js@2.9.4/dist/Chart.min.js" integrity="sha384-zNy6FEbO50N+Cg5wap8IKA4M/ZnLJgzc6w2NqACZaK0u0FXfOWRRJOnQtpZun8ha" crossorigin="anonymous"></script>
        <script src="dashboard.js"></script>
</body>
</html>
