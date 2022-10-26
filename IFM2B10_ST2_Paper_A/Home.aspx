<%@ Page Title="" Language="C#" MasterPageFile="~/PaperA.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="IFM2B10_ST2_Paper_A.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="banner_part">
        <div class="container">
            <div class="row align-items-center">
                <div class="col-lg-6">
                    <div class="banner_text">
                        <div class="banner_text_iner">
                            <h5>Expensive but the best</h5>
                            <h1>Deliciousness jumping into the mouth</h1>
                            <p>Together creeping heaven upon third dominion be upon won't darkness rule land
                                behold it created good saw after she'd Our set living. Signs midst dominion
                                creepeth morning</p>
                            <div class="banner_btn">
                                <div class="banner_btn_iner">
                                    <asp:LinkButton ID="BtnR" href="Reservation.aspx" class="BtnR"  runat="server" OnClick="BtnR_Click">Reservation <img src="img/icon/left_1.svg" alt=""></asp:LinkButton>
                           
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <section class="exclusive_item_part blog_item_section">
        <div class="container">
            <div class="row">
                <div class="col-xl-5">
                    <div class="section_tittle">
                        <p>Popular Dishes</p>
                        <h2>Our Exclusive Items</h2>
                    </div>
                </div>
            </div>
            <div class="row" runat="server" id="specials">
                <div class="col-sm-6 col-lg-4">
                    <div class="single_blog_item">
                        <div class="single_blog_img">
                            <img src="img/food_item/food_item_1.png" alt="">
                        </div>
                        <div class="single_blog_text">
                            <h3>Indian Burger</h3>
                            <p>Was brean shed moveth day yielding tree yielding day were female and </p>
                            <a href="#" class="btn_3">Read More <img src="img/icon/left_2.svg" alt=""></a>
                        </div>
                    </div>
                </div>
                <div class="col-sm-6 col-lg-4">
                    <div class="single_blog_item">
                        <div class="single_blog_img">
                            <img src="img/food_item/food_item_2.png" alt="">
                        </div>
                        <div class="single_blog_text">
                            <h3>Cremy Noodles</h3>
                            <p>Was brean shed moveth day yielding tree yielding day were female and </p>
                            <a href="AboutMeal.aspx" class="btn_3">Read More <img src="img/icon/left_2.svg" alt=""></a>
                        </div>
                    </div>
                </div>
                
                <div class="col-sm-6 col-lg-4 d-none d-sm-block d-lg-none">
                    <div class="single_blog_item">
                        <div class="single_blog_img">
                            <img src="img/food_item/food_item_1.png" alt="">
                        </div>
                        <div class="single_blog_text">
                            <h3>Cremy Noodles</h3>
                            <p>Was brean shed moveth day yielding tree yielding day were female and </p>
                            <a href="#" class="btn_3">Read More <img src="img/icon/left_2.svg" alt=""></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <br />
    <br />
    <br />

</asp:Content>
