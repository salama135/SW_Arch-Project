﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="BPT_Consumer.SignIn"  %>

<!doctype html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta charset="utf-8"/>
        <meta name="viewport" content="width=device-width, initial-scale=1"/>
        <meta name="description" content=""/>
        <meta name="author" content="Mark Otto, Jacob Thornton, and Bootstrap contributors"/>
        <meta name="generator" content="Hugo 0.79.0"/>
      
        <title>BPT - Signin</title>
       
        <!-- Bootstrap core CSS -->
        <link href="./assets/dist/css/bootstrap.min.css" rel="stylesheet"/>

        <style>
          .bd-placeholder-img {
            font-size: 1.125rem;
            text-anchor: middle;
            -webkit-user-select: none;
            -moz-user-select: none;
            user-select: none;
          }

          .google {
              margin-top:20px;
              background-color:red;

          }

          @media (min-width: 768px) {
            .bd-placeholder-img-lg {
              font-size: 3.5rem;
            }
          }
        </style>
    
        <!-- Custom styles for this template -->
        <link href="signin.css" rel="stylesheet"/>
  </head>

  <body class="text-center">
    
    <main class="form-signin">
      <form id="form1" runat="server">
        <img class="mb-4" src="./assets/brand/bootstrap-logo.svg" alt="" width="72" height="57"/>
        <h1 class="h3 mb-3 fw-normal">Please sign in</h1>
        <label for="inputEmail" class="visually-hidden">Email address</label>
        <input runat="server" type="email" id="inputEmail" class="form-control" placeholder="Email address"  autofocus/>
        <label for="inputPassword" class="visually-hidden">Password</label>
        <input runat="server" type="password" id="inputPassword" class="form-control" placeholder="Password" />

      
          <asp:Button ID="SignInButton" runat="server" class="w-100 btn btn-lg btn-primary" type="submit" Text ="Sign in" OnClick="SignInButton_Click"></asp:Button>
          <asp:Button ID="googleSignIn" runat="server" class="w-100 btn btn-lg google" type="submit" Text ="Sign in With Google" OnClick="SignInGoogle_Click"></asp:Button>

        <p class="mt-5 mb-3 text-muted">&copy; 2020</p>
      </form>
        <div runat="server" id="AlertBox" class="alert alert-danger" role="alert" visible="false">
            Something when wrong please check the email and password !
        </div>
    </main>   
  </body>
</html>
