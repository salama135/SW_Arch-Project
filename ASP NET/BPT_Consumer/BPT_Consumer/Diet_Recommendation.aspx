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
        </style>

        <!-- Custom styles for this template -->
        <link href="pricing.css" rel="stylesheet" />
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
                    <a class="nav-link" runat="server" href="~/Home.aspx">
                        <span data-feather="home"></span>
                        Home
                    </a>
                    </li>
                    <li class="nav-item">
                    <a class="nav-link" runat="server" href="~/UserInfo.aspx">
                        <span data-feather="user"></span>
                        User Info
                    </a>
                    </li>
                
                    <li class="nav-item">
                    <a class="nav-link active"href="#">
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
                </ul>
            
                </div>
            </nav>

            <main class="container">
              <div class="pricing-header px-3 py-3 pt-md-5 pb-md-4 mx-auto text-center">
                <h1 class="display-4">Pricing</h1>
                <p class="lead">Quickly build an effective pricing table for your potential customers with this Bootstrap example. It’s built with default Bootstrap components and utilities with little customization.</p>
              </div>

              <div class="row row-cols-1 row-cols-md-3 mb-3 text-center">
                <div class="col">
                    <div class="card mb-4 shadow-sm">
                      <div class="card-header">
                        <h4 class="my-0 fw-normal">Breakfast</h4>
                      </div>
                      <div class="card-body">
                        <h1 class="card-title pricing-card-title">$0 <small class="text-muted">/ mo</small></h1>
                        <ul class="list-unstyled mt-3 mb-4">
                          <li>10 users included</li>
                          <li>2 GB of storage</li>
                          <li>Email support</li>
                          <li>Help center access</li>
                        </ul>
                        <button type="button" class="w-100 btn btn-lg btn-outline-primary">Sign up for free</button>
                      </div>
                    </div>
                </div>
                <div class="col">
                  <div class="card mb-4 shadow-sm">
                    <div class="card-header">
                    <h4 class="my-0 fw-normal">Lunch</h4>
                    </div>
                  <div class="card-body">
                    <h1 class="card-title pricing-card-title">$15 <small class="text-muted">/ mo</small></h1>
                    <ul class="list-unstyled mt-3 mb-4">
                      <li>20 users included</li>
                      <li>10 GB of storage</li>
                      <li>Priority email support</li>
                      <li>Help center access</li>
                    </ul>
                    <button type="button" class="w-100 btn btn-lg btn-primary">Get started</button>
                  </div>
                </div>
                </div>
                <div class="col">
                  <div class="card mb-4 shadow-sm">
                  <div class="card-header">
                    <h4 class="my-0 fw-normal">Enterprise</h4>
                  </div>
                  <div class="card-body">
                    <h1 class="card-title pricing-card-title">$29 <small class="text-muted">/ mo</small></h1>
                    <ul class="list-unstyled mt-3 mb-4">
                      <li>30 users included</li>
                      <li>15 GB of storage</li>
                      <li>Phone and email support</li>
                      <li>Help center access</li>
                    </ul>
                    <button type="button" class="w-100 btn btn-lg btn-primary">Contact us</button>
                  </div>
                </div>
                </div>
              </div>
            </main>
         </div>
    </div>

        <script src="./assets/dist/js/bootstrap.bundle.min.js"></script>
        <script src="https://cdn.jsdelivr.net/npm/feather-icons@4.28.0/dist/feather.min.js" integrity="sha384-uO3SXW5IuS1ZpFPKugNNWqTZRRglnUJK6UAZ/gxOX80nxEkN9NcGZTftn6RzhGWE" crossorigin="anonymous"></script>
        <script src="https://cdn.jsdelivr.net/npm/chart.js@2.9.4/dist/Chart.min.js" integrity="sha384-zNy6FEbO50N+Cg5wap8IKA4M/ZnLJgzc6w2NqACZaK0u0FXfOWRRJOnQtpZun8ha" crossorigin="anonymous"></script>
        <script src="dashboard.js"></script>
    </body>
</html>
