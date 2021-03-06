﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="BPT_Consumer.Home" %>

<!doctype html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <meta name="description" content="" />
        <meta name="author" content="Mark Otto, Jacob Thornton, and Bootstrap contributors" />
        <meta name="generator" content="Hugo 0.79.0" />
        <title>BPT - Home</title>

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
        </style>

    
        <!-- Custom styles for this template -->
        <link href="dashboard.css" rel="stylesheet" />
    </head>
    <body>
    
    <header class="navbar navbar-dark sticky-top bg-dark flex-md-nowrap p-0 shadow">
        <a class="navbar-brand col-md-3 col-lg-2 me-0 px-3" href="#">Company name</a>
        
        <button class="navbar-toggler position-absolute d-md-none collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#sidebarMenu" aria-controls="sidebarMenu" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
        </button>
      
        <ul  class="navbar-nav px-3">
        <li class="nav-item text-nowrap">
            <form id="form1" runat="server">
                <asp:Button ID="SignInButton" runat="server" class="w-100 btn btn-sm btn-primary" type="submit" Text ="Sign Out" OnClick="SignOut"></asp:Button>
            </form>
        </li>
        </ul>
    </header>

    <div class="container-fluid">
        <div class="row">
            <nav id="sidebarMenu" class="col-md-3 col-lg-2 d-md-block bg-light sidebar collapse">
                <div class="position-sticky pt-3">
                    <ul class="nav flex-column">
                        <li class="nav-item">
                        <a class="nav-link active"  href="#">
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
                <div class="d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 mb-3 border-bottom">
                <h1 class="h2">Blood Pressure Analysis</h1>

                </div>

                <canvas class="my-4 w-100" id="myChart" width="900" height="380"></canvas>
                <div id="AlertBox" class="alert alert-primary" role="alert" visible="false" style="display:none;">
                    Please go meassure your blood pressure now!
                </div>
            </main>
        </div>
    </div>        


    <input id="Hidden_rows" type="hidden" runat="server"/>
    <input id="Hidden_cols" type="hidden" runat="server"/>
    
    <script src="./assets/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/feather-icons@4.28.0/dist/feather.min.js" integrity="sha384-uO3SXW5IuS1ZpFPKugNNWqTZRRglnUJK6UAZ/gxOX80nxEkN9NcGZTftn6RzhGWE" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/chart.js@2.9.4/dist/Chart.min.js" integrity="sha384-zNy6FEbO50N+Cg5wap8IKA4M/ZnLJgzc6w2NqACZaK0u0FXfOWRRJOnQtpZun8ha" crossorigin="anonymous"></script>
    <script> 

        (function () {
            'use strict'

            feather.replace()

            // Graphs

            var Rows = JSON.parse(document.getElementById("Hidden_rows").value);
            var Cols = JSON.parse(document.getElementById("Hidden_cols").value);
            
            var ctx = document.getElementById('myChart')
            var myChart = new Chart(ctx, {
                type: 'line',
                data: {
                    labels: Rows,
                    datasets: [{
                        data: Cols,
                        lineTension: 0,
                        backgroundColor: 'transparent',
                        borderColor: '#007bff',
                        borderWidth: 4,
                        pointBackgroundColor: '#007bff'
                    }]
                },
                options: {
                    scales: {
                        yAxes: [{
                            ticks: {
                                beginAtZero: false
                            }
                        }]
                    },
                    legend: {
                        display: false
                    }
                }
            })
        })()

    </script>

    <script>
        setInterval(reminder, 10000);

        function reminder() {

            if (document.getElementById("AlertBox").style.display == "none")
                document.getElementById("AlertBox").style.display = "block";
            else
                document.getElementById("AlertBox").style.display = "none";
        }
    </script>

  </body>
</html>