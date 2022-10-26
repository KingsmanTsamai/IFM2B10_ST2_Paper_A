<%@ Page Title="" Language="C#" MasterPageFile="~/PaperA.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="IFM2B10_ST2_Paper_A.Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <section class="food_menu gray_bg">
        <div class="container">
            <div class="row justify-content-between">
                <div class="col-lg-5">
                    <div class="section_tittle">
                        <p>Popular Menu</p>
                        <h2>Delicious Food Menu</h2>
                    </div>
                </div>
                <div class="col-lg-6">
                    <div class="nav nav-tabs food_menu_nav" id="myTab" role="tablist">
                        <a class="active" id="Special-tab" data-toggle="tab" href="#Special" role="tab"
                            aria-controls="Special" aria-selected="false">Special <img src="img/icon/play.svg"
                                alt="play"></a>
                        <a id="Breakfast-tab" data-toggle="tab" href="#Starter" role="tab" aria-controls="Starter"
                            aria-selected="false">Starter <img src="img/icon/play.svg" alt="play"></a>
                        <a id="Launch-tab" data-toggle="tab" href="#Main" role="tab" aria-controls="Main"
                            aria-selected="false">Main <img src="img/icon/play.svg" alt="play"></a>
                        <a id="Dinner-tab" data-toggle="tab" href="#Dessert" role="tab" aria-controls="Dessert"
                            aria-selected="false">Dessert <img src="img/icon/play.svg" alt="play"> </a>
                    </div>
                </div>
                <div class="col-lg-12">
                    <div class="tab-content" id="myTabContent">
                        <div class="tab-pane fade show active single-member" id="Special" role="tabpanel"
                            aria-labelledby="Special-tab" >
                               <div class='row'>
                                <div class='col-sm-6 col-lg-6' id="DivSpecial" runat="server">
                                </div>
                            </div>
                        </div>
                        <div class="tab-pane fade single-member" role="tabpanel"
                            aria-labelledby="Breakfast-tab" id="Starter">
                            <div class='row'>
                                <div class='col-sm-6 col-lg-6' id="DivStarter" runat="server">
                                </div>
                            </div>
                        </div>
                        <div class="tab-pane fade single-member" role="tabpanel"
                            aria-labelledby="Launch-tab" id="Launch">
                            <div class='row'>
                                <div class='col-sm-6 col-lg-6' id="DivLaunch" runat="server">
                                </div>
                            </div>
                        </div>
                        <div class="tab-pane fade single-member" role="tabpanel"
                            aria-labelledby="Dinner-tab" id="Main">
                            <div class='row'>
                                <div class='col-sm-6 col-lg-6' id="DivMeal" runat="server">
                                </div>
                            </div>
                        </div>
                        <div class="tab-pane fade single-member" role="tabpanel"
                            aria-labelledby="Sneaks-tab" id="Dessert">
                            <div class='row'>
                                <div class='col-sm-6 col-lg-6' id="DivDessert" runat="server">
                                </div>
                            </div>
            </div>  </div> </div>
        </div>
        </div>
    </section>
</asp:Content>
