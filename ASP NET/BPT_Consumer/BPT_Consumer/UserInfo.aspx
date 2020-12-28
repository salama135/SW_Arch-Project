<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInfo.aspx.cs" Inherits="BPT_Consumer.UserInfo" %>

<!doctype html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <meta name="description" content="" />
        <meta name="author" content="Mark Otto, Jacob Thornton, and Bootstrap contributors" />
        <meta name="generator" content="Hugo 0.79.0" />
        <title>BPT - User Info</title>

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
        <link href="form-validation.css" rel="stylesheet" />
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
                        <a class="nav-link active" runat="server" href="#">
                            <span data-feather="user"></span>
                            User Info
                        </a>
                        </li>
                
                        <li class="nav-item">
                        <a class="nav-link" runat="server" href="~/Diet_Recommendation.aspx">
                            <span data-feather="heart"></span>
                            Diet Recommendation
                        </a>
                        </li>

                        <li class="nav-item">
                        <a class="nav-link" runat="server" href="~/Diet_Recommendation.aspx">
                            <span data-feather="heart"></span>
                            Update Blood Preassure
                        </a>
                        </li>
                    </ul>
                </div>
            </nav>

            <div class="container">
                <main>
                    <div class="py-5 text-center">
                      <img class="d-block mx-auto mb-4" src="./assets/brand/bootstrap-logo.svg" alt="" width="72" height="57" />
                      <h2>User Info</h2>
                    </div>

                    <div class="col-md-7 col-lg-8">
                        <form id="form1" runat="server">
                            <div class="row g-3">
                                <div class="col-sm-6">
                                    <label for="firstName" class="form-label">First name</label>
                                    <input runat="server" type="text" class="form-control" id="inputFirstName" placeholder="" value="" />
                                    <div class="invalid-feedback">
                                    Valid first name is required.
                                    </div>
                                </div>

                                <div class="col-sm-6">
                                    <label for="lastName" class="form-label">Last name</label>
                                    <input runat="server" type="text" class="form-control" id="inputLastName" placeholder="" value="" />
                                    <div class="invalid-feedback">
                                    Valid last name is required.
                                    </div>
                                </div>

                                <div class="col-12">
                                    <label for="username" class="form-label">Username</label>
                                    <div class="input-group">
                                    <span class="input-group-text">@</span>
                                    <input runat="server" type="text" class="form-control" id="inputUsername" placeholder="Username" />
                                    <div class="invalid-feedback">
                                        Your username is required.
                                    </div>
                                    </div>
                                </div>

                                <div class="col-12">
                                    <label for="password" class="form-label">Password</label>
                                    <div class="input-group">
                                    <input runat="server" type="text" class="form-control" id="inputPassword" placeholder="Password" />
                                    <div class="invalid-feedback">
                                        Your password is required.
                                    </div>
                                    </div>
                                </div>

                                <div class="col-12">
                                    <label for="email" class="form-label">Email</label>
                                    <input runat="server" type="email" class="form-control" id="inputEmail" placeholder="you@example.com" />
                                    <div class="invalid-feedback">
                                    Please enter a valid email address for shipping updates.
                                    </div>
                                </div>
                            </div>

                            <hr class="my-4" />

                            <div class="row gy-3">
                                <div class="col-md-3">
                                    <label for="age" class="form-label">Age</label>
                                    <input runat="server" type="text" class="form-control" id="inputAge" placeholder="" />
                                    <div class="invalid-feedback">
                                    age required
                                    </div>
                                </div>
                        
                                <div class="col-md-3">
                                    <label for="weight" class="form-label">Weight</label>
                                    <input runat="server" type="text" class="form-control" id="inputWeight" placeholder="" />
                                    <div class="invalid-feedback">
                                    weight required
                                    </div>
                                </div>
                        
                                <div class="col-md-3">
                                    <label for="height" class="form-label">Height</label>
                                    <input runat="server" type="text" class="form-control" id="inputHeight" placeholder="" />
                                    <div class="invalid-feedback">
                                    height required
                                    </div>
                                </div>
                            </div>

                            <hr class="my-4" />

                            <h5 class="mb-3">Gender</h5>

                            <div class="my-3">
                                <div class="form-check">
                                    <input runat="server" id="inputMale" name="gender" type="radio" class="form-check-input" />
                                    <label class="form-check-label" for="Male">Male</label>
                                </div>
                                
                                <div class="form-check">
                                    <input runat="server" id="inputFemale" name="gender" type="radio" class="form-check-input" />
                                    <label class="form-check-label" for="Female">Female</label>
                                </div>
                            </div>

                            <hr class="my-4" />
                            <asp:Button ID="Button1" runat="server" class="w-100 btn btn-primary btn-lg" Text="Change Info" OnClick="Button1_Click"  />
 
                            <hr class="my-4" />
                            <asp:Button ID="Button2" runat="server" class="w-100 btn btn-danger btn-lg" Text="Delete User" OnClick="Button2_Click"  />
                        </form>
                    </div>
              </main>
            </div>
        </div>
    </div>

    <div runat="server" id="AlertBox" class="alert alert-danger" role="alert" visible="false">
        Something when wrong please check the email and password !
    </div>

    <script src="./assets/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/feather-icons@4.28.0/dist/feather.min.js" integrity="sha384-uO3SXW5IuS1ZpFPKugNNWqTZRRglnUJK6UAZ/gxOX80nxEkN9NcGZTftn6RzhGWE" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/chart.js@2.9.4/dist/Chart.min.js" integrity="sha384-zNy6FEbO50N+Cg5wap8IKA4M/ZnLJgzc6w2NqACZaK0u0FXfOWRRJOnQtpZun8ha" crossorigin="anonymous"></script>
    <script src="dashboard.js"></script>
  </body>
</html>