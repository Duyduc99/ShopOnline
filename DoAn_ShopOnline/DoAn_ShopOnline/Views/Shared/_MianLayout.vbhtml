﻿@Code
    ViewData("Title") = "_MianLayout"
End Code
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="Free Bootstrap Themes by 365Bootstrap dot com - Free Responsive Html5 Templates">
    <meta name="author" content="http://www.365bootstrap.com">

    <title>Mobile Shop</title>

    <!-- Bootstrap Core CSS -->
    <link rel="stylesheet" href="~/Asset/css/bootstrap.min.css" type="text/css">

    <!-- Custom CSS -->
    <link rel="stylesheet" href="~/Asset/css/style.css">


    <!-- Custom Fonts -->
    <link rel="stylesheet" href="font-awesome/css/font-awesome.min.css" type="text/css">
    <link rel="stylesheet" href="fonts/font-slider.css" type="text/css">

    <!-- jQuery and Modernizr-->
    <script src="~/Asset/js/jquery-2.1.1.js"></script>

    <!-- Core JavaScript Files -->
    <script src="~/Asset/js/bootstrap.min.js"></script>

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="js/html5shiv.js"></script>
        <script src="js/respond.min.js"></script>
    <![endif]-->
    <script src="~/Areas/AssetAdmin/ckeditor/ckeditor.js"></script>
</head>

<body>
    <!--Top-->
    <nav id="top">
        <div class="container">
            <div class="row">
                <div class="col-xs-6">
                    <select class="language">
                        <option value="English" selected>English</option>
                        <option value="France">France</option>
                        <option value="Germany">Germany</option>
                    </select>
                    <select class="currency">
                        <option value="USD" selected>USD</option>
                        <option value="EUR">EUR</option>
                        <option value="DDD">DDD</option>
                    </select>
                </div>
                <div class="col-xs-6">
                    <ul class="top-link">
                        @Html.Partial("_LoginPartial")
                    </ul>
                </div>
            </div>
        </div>
    </nav>
    <!--Header-->
    @        If (User.Identity.IsAuthenticated) Then
                {
@Html.Partial("_Header", DoAn_ShopOnline.Models.BUS.GioHangBUS.DanhSach(User.Identity.GetUserId()));
}


    <!--Navigation-->
@*/*day la phan Hien lam*/*@
    <nav id = "menu" Class="navbar">
        <div Class="container">
            <div Class="navbar-header">
                <span id = "heading" Class="visible-xs">Categories</span>
                <Button type = "button" Class="btn btn-navbar navbar-toggle" data-toggle="collapse" data-target=".navbar-ex1-collapse"><i Class="fa fa-bars"></i></button>
            </div>
            <div Class="collapse navbar-collapse navbar-ex1-collapse">
                <ul Class="nav navbar-nav">
                    <li>@Html.ActionLink("Home", "Index", "Home")</li>
                                        <li> @Html.ActionLink("Products","Index","Shop")</li>
                                        @Html.Partial("_NhaSanXuat",DoAn_ShopOnline.Models.BUS.NhaSanXuatBUS.DanhSach())
                                        @Html.Partial("_LoaiSanPham", DoAn_ShopOnline.Models.BUS.LoaiSanPhamBUS.DanhSach())
                                                            <li> <a href = "category.html" > Software</a></li>
                                                        </ul>
                                                    </div>

                                        @*<div id="txtTimKiem">
                                                @using (Html.BeginForm("KetQuaTimKiem", "TimKiem"))
                                                {
                                                    @Html.TextBox("TimKiem", "", htmlAttributes: new { @class = "TextBoxTimKiem", @placeholder = "Nhập từ khóa vào" })
                                                    <div id="divHinhAnhTimKiem">
                                                        <button type="submit"><img src="~/Asset/images/search.png" height="20" width="20" /></button>
                                                    </div>
                                                }
                                            </div>*@

                                        @*/Het phan Hien lam*/*@

                                                </div>
                                            </nav>
                                            <!--//////////////////////////////////////////////////-->
                                            <!--///////////////////HomePage///////////////////////-->
                                            <!--//////////////////////////////////////////////////-->
                                        @RenderBody()
                                        @*Kĩ thuật 1 : đỗ dữ liệu theo kiểu renderpatital*@
                                        @{ Html.RenderPartial("_Footer");}
                                        @RenderSection("scripts", required false)
</body>
</html>



