﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateBP.aspx.cs" Inherits="BPT_Consumer.UpdateBP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> BPT - Update Blood Pressure</title>
        <style>
            .main-div {
                position: absolute;
                top: 30%;
                left: 40%;
                border: 1px solid #808080;
                border-radius: 25px;
                padding: 25px;
                text-align: center;
                background-color: gold;
            
            }
            .btn {
                border-radius: 25px;
                height: 30px;
                color: #fff;
                background-color: #007bff;
                border: none;
                outline: none;
            
            }
            .text-box {
                border-radius: 25px;
                border-color:#808080;
                font-size: larger;
                outline:none;
                padding: 15px;
                text-align: center;
            }

        </style>
    
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
      
        <ul class="navbar-nav px-3">
        <li class="nav-item text-nowrap">
            <a class="nav-link" href="#">Sign out</a>
        </li>
        </ul>
    </header>

    <div class="container-fluid">
        <div class="row">
            <nav id="sidebarMenu" class="col-md-3 col-lg-2 d-md-block bg-light sidebar collapse">
                <div class="position-sticky pt-3">
                <ul class="nav flex-column">
                    <li class="nav-item">
                    <a class="nav-link" href="Home.aspx">
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
                    <a class="nav-link active" runat="server" href="#">
                        <span data-feather="bold"></span>
                        Update Blood Pressure
                    </a>
                    </li>
                
                </ul>
            
                </div>
            </nav>
                
            <main class="col-md-9 ms-sm-auto col-lg-10 px-md-4">

                <div class="main-div">
                    <form id="form2" runat="server">
                        <h2>Blood Pressure</h2>
                        <h2>Add your new Measurement</h2>
                        <asp:TextBox ID="TextBox1" placeholder="Enter a number" CssClass="text-box" runat="server" Width="90%" Height="7px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Button ID="Save_btn" class="btn btn-primary" runat="server" OnClick="Save_btn_Click" style="margin-top: 0px" Text="Save" Width="94px" />
                    </form>
                </div>
            </main>
            <div runat="server" id="AlertBox" class="alert alert-danger" role="alert" visible="false">
                    Something when wrong please check the email and password !
            </div>

            </div>
        </div>
        
        <script src="./assets/dist/js/bootstrap.bundle.min.js"></script>
        <script src="https://cdn.jsdelivr.net/npm/feather-icons@4.28.0/dist/feather.min.js" integrity="sha384-uO3SXW5IuS1ZpFPKugNNWqTZRRglnUJK6UAZ/gxOX80nxEkN9NcGZTftn6RzhGWE" crossorigin="anonymous"></script>
        <script src="https://cdn.jsdelivr.net/npm/chart.js@2.9.4/dist/Chart.min.js" integrity="sha384-zNy6FEbO50N+Cg5wap8IKA4M/ZnLJgzc6w2NqACZaK0u0FXfOWRRJOnQtpZun8ha" crossorigin="anonymous"></script>
        <script src="dashboard.js"></script>
    </body>
</html>
