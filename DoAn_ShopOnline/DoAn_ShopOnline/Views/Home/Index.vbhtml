﻿@Code
    ViewData("Title") = "Home Page"
End Code

<div id="page-content" class="single-page">
    <div class="container">
        <div class="row">
            <div class="col-lg-12">
                <ul class="breadcrumb">
                    <li>@Html.ActionLink("Home", "Index", "Home")</li>
                    <li>@Html.ActionLink("Products", "Index", "Shop")</li>
                </ul>
            </div>
        </div>
        <div class="row">
            <div id="main-content" class="col-md-8">
                <div class="row">
                    <div class="col-md-12">
                        <div class="products">
                            @foreach (var item in Model)
                            {

                            <div class="col-lg-4 col-md-4 col-xs-12">
                                <div class="product">
                                    <div class="image"><a href="@Url.Action("Details", new { id = @item.MaSanPham})">@Html.Partial("_AvartaDetails", DoAn_ShopOnline.Models.BUS.ShopOnlineBUS.LoadAvartaImg(item.MaSanPham))</a></div>
                                    <div class="buttons">
                                        <a class="btn cart" href="@Url.Action("index","GioHang")"><span class="glyphicon glyphicon-shopping-cart"></span></a>
                                        <a class="btn wishlist" href="#"><span class="glyphicon glyphicon-heart"></span></a>
                                        <a class="btn compare" href="#"><span class="glyphicon glyphicon-transfer"></span></a>
                                    </div>
                                    <div class="caption">
                                        <div class="name"><h3><a href="@Url.Action("Details", new { id = @item.MaSanPham})">@item.TenSanPham</a></h3></div>
                                        <div class="price">@String.Format(System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:c}", item.Gia)</div>
                                        <div class="rating"><span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star-empty"></span></div>
                                    </div>
                                </div>
                            </div>
                            }


                        </div>
                    </div>
                </div>
                <div class="row text-center">
                    <ul class="pagination">
                        @Html.PagedListPager(Model, page => Url.Action("Index", new { page }))
                    </ul>
                </div>
            </div>
            <div id="sidebar" class="col-md-4">
                <div class="widget wid-categories">
                    <div class="heading"><h4>CATEGORIES</h4></div>
                    <div class="content">
                        <ul>
                            <li><a href="#">PC Computers</a></li>
                            <li><a href="#">Laptops & Notebooks</a></li>
                            <li><a href="#">Mobiles & Tablet</a></li>
                            <li><a href="#">Software</a></li>
                        </ul>
                    </div>
                </div>
                <div class="widget wid-type">
                    <div class="heading"><h4>TYPE</h4></div>
                    <div class="content">
                        <select>
                            <option value="EL" selected>Electronics</option>
                            <option value="MT">Mice and Trackballs</option>
                            <option value="WC">Web Cameras</option>
                            <option value="TA">Tablates</option>
                            <option value="AP">Audio Parts</option>
                        </select>
                    </div>
                </div>
                <div class="widget wid-discouts">
                    <div class="heading"><h4>DISCOUNTS</h4></div>
                    <div class="content">
                        <label class="checkbox"><input type="checkbox" name="discount" checked="">Upto - 10% (20)</label>
                        <label class="checkbox"><input type="checkbox" name="discount">40% - 50% (5)</label>
                        <label class="checkbox"><input type="checkbox" name="discount">30% - 20% (7)</label>
                        <label class="checkbox"><input type="checkbox" name="discount">10% - 5% (2)</label>
                        <label class="checkbox"><input type="checkbox" name="discount">Other(50)</label>
                    </div>
                </div>
                <div class="widget wid-brand">
                    <div class="heading"><h4>BRAND</h4></div>
                    <div class="content">
                        <label class="checkbox"><input type="checkbox" name="brand">Nokia</label>
                        <label class="checkbox"><input type="checkbox" name="brand">Samsung</label>
                        <label class="checkbox"><input type="checkbox" name="brand">Iphone</label>
                        <label class="checkbox"><input type="checkbox" name="brand">HTC</label>
                        <label class="checkbox"><input type="checkbox" name="brand">Oppo</label>
                        <label class="checkbox"><input type="checkbox" name="brand">Kings</label>
                        <label class="checkbox"><input type="checkbox" name="brand">Zumba</label>
                    </div>
                </div>
                <div class="widget wid-product">
                    <div class="heading"><h4>LATEST</h4></div>
                    <div class="content">
                        <div class="product">
                            <a href="#"><img src="~/Asset/images/galaxy-note.jpg" /></a>
                            <div class="wrapper">
                                <h5><a href="#">Samsung Galaxy Tab</a></h5>
                                <div class="price">$122</div>
                                <div class="rating"><span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star-empty"></span></div>
                            </div>
                        </div>
                        <div class="product">
                            <a href="#"><img src="~/Asset/images/galaxy-s4.jpg" /></a>
                            <div class="wrapper">
                                <h5><a href="#">Samsung Galaxy Tab</a></h5>
                                <div class="price">$122</div>
                                <div class="rating"><span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star-empty"></span></div>
                            </div>
                        </div>
                        <div class="product">
                            <a href="#"><img src="~/Asset/images/Z1.png" /></a>
                            <div class="wrapper">
                                <h5><a href="#">Samsung Galaxy Tab</a></h5>
                                <div class="price">$122</div>
                                <div class="rating"><span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star-empty"></span></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>	