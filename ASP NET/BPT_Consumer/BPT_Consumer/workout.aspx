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

    <form id="form1" runat="server">
    
    <header class="navbar navbar-dark sticky-top bg-dark flex-md-nowrap p-0 shadow">
        <a class="navbar-brand col-md-3 col-lg-2 me-0 px-3" href="#">Company name</a>
        
        <button class="navbar-toggler position-absolute d-md-none collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#sidebarMenu" aria-controls="sidebarMenu" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
        </button>
      
        <ul  class="navbar-nav px-3">
        <li class="nav-item text-nowrap">
             <asp:Button ID="SignInButton" runat="server" class="w-100 btn btn-sm btn-primary" type="submit" Text ="Sign Out" OnClick="SignOut"></asp:Button>
        </li>
        </ul>
    </header>

    <div class="container-fluid">
        <div class="row">
            <nav id="sidebarMenu" class="col-md-3 col-lg-2 d-md-block bg-light sidebar collapse">
                <div class="position-sticky pt-3">
                    <ul class="nav flex-column">
                        <li class="nav-item">
                        <a class="nav-link"  href="Home.aspx">
                            <span data-feather="home"></span>
                            Home
                        </a>
                        </li>
                        <li class="nav-item">
                        <a class="nav-link" runat="server" href="UserInfo.aspx">
                            <span data-feather="user"></span>
                            User Info
                        </a>
                        </li>
                
                        <li class="nav-item">
                        <a class="nav-link" runat="server" href="Diet_Recommendation.aspx">
                            <span data-feather="heart"></span>
                            Diet Recommendation
                        </a>
                        </li>
                    
                        <li class="nav-item">
                        <a class="nav-link" runat="server" href="UpdateBP.aspx">
                            <span data-feather="bold"></span>
                            Update Blood Pressure
                        </a>
                        </li>
                
                        <li class="nav-item">
                        <a class="nav-link" runat="server" href="Workout.aspx">
                            <span data-feather="activity"></span>
                            Workout Recommendation
                        </a>
                        </li>
                    </ul>
                </div>
            </nav>

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

            </div>
        </div>
        
        </form>

        <script src="./assets/dist/js/bootstrap.bundle.min.js"></script>
        <script src="https://cdn.jsdelivr.net/npm/feather-icons@4.28.0/dist/feather.min.js" integrity="sha384-uO3SXW5IuS1ZpFPKugNNWqTZRRglnUJK6UAZ/gxOX80nxEkN9NcGZTftn6RzhGWE" crossorigin="anonymous"></script>
        <script src="https://cdn.jsdelivr.net/npm/chart.js@2.9.4/dist/Chart.min.js" integrity="sha384-zNy6FEbO50N+Cg5wap8IKA4M/ZnLJgzc6w2NqACZaK0u0FXfOWRRJOnQtpZun8ha" crossorigin="anonymous"></script>
        <script src="dashboard.js"></script>
    </body>
</html>
