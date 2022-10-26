<%@ Page Title="" Language="C#" MasterPageFile="~/PaperA.Master" AutoEventWireup="true" CodeBehind="Reservation.aspx.cs" Inherits="IFM2B10_ST2_Paper_A.Reservation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <section class="regervation_part ">
        <br />
        <br />
        <div class="container">
            <div class="row">
                <div class="col-xl-5">
                    <div class="section_tittle">
                        <p>Reservation</p>
                        <h2>Book A Table</h2>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-6">
                    <div class="regervation_part_iner">
                        <div runat="server">
                            <div class="form-row">
                                <div class="form-group col-md-6">
                                    <input type="text" class="form-control" id="name" placeholder="Name *" runat="server">
                                </div>
                                <div class="form-group col-md-6">
                                    <input type="email" class="form-control" id="email" placeholder="Email address *" runat="server">
                                </div>
                                <div class="form-group col-md-6">
                                    <select class="form-control" id="Select" runat="server">
                                        <option value="1" selected>Persons *</option>
                                        <option value="2">Number of guests 1</option>
                                        <option value="3">Number of guests 2</option>
                                        <option value="4">Number of guests 3</option>
                                        <option value="5">Number of guests 4</option>
                                    </select>
                                </div>
                                <div class="form-group col-md-6">
                                    <input type="text" class="form-control" id="pnone" placeholder="Phone number *" runat="server">
                                </div>
                                <div class="form-group col-md-6">
                                    <div class="input-group date" runat="server">
                                        <input id="datepicker" type="text" class="form-control" placeholder="Date *" runat="server" />
                                    </div>
                                </div>
                                <div class="form-group col-md-6">
                                    <select class="form-control" id="Select2" runat="server">
                                        <option value="" selected>Time *</option>
                                        <option value="810">8 AM TO 10AM</option>
                                        <option value="1012">10 AM TO 12PM</option>
                                        <option value="1214">12PM TO 2PM</option>
                                        <option value="1416">2PM TO 4PM</option>
                                        <option value="1618">4PM TO 6PM</option>
                                        <option value="1820">6PM TO 8PM</option>
                                    </select>
                                </div>
                                <div class="form-group col-md-12">
                                    <textarea class="form-control" id="Textarea" rows="4" placeholder="Your Note *" runat="server"></textarea>
                                </div>
                            </div>
                            <div>
                                <asp:Label  ID="message" runat="server" Text=""></asp:Label>

                            </div>


                            <div class="regerv_btn">
                                <asp:Button ID="btnReserv" runat="server" Text="Book A Table" class="genric-btn primary" OnClick="btnReserv_Click" />
                            </div>
                            <br />
                            <br />
                            <br />

                            <div id="EditRes" runat="server">
                                <div class="row">
                                    <div class="col-xl-8">
                                        <div class="section_tittle">
                                            <h2>Edit A Reservation</h2>
                                        </div>
                                    </div>
                                </div>
                                <input type="text" class="form-control" id="EditEmail" placeholder="Email address *" runat="server">

                                <div class="regerv_btn">
                                    <asp:Button ID="BtnEditRes" runat="server" Text="Edit A Booking" class="genric-btn primary-border" OnClick="BtnEditRes_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <br />
        <br />
        <br />
    </section>
</asp:Content>
