<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DankSmiteOnline2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="TestUpdatePanel">
        <asp:UpdatePanel ID="TestPanel" runat="server">
            <ContentTemplate>
                <legend>Tests</legend>
                <asp:Label ID="TestLabel" runat="server" Text="Test"/>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    
    <div class="ItemUpdatePanel" style="position:relative; height: 500px; left: 100px; top: 150px;">        
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <legen>Items</legen>
                <%-- ================================= Items ================================== --%>
                <div style="position: absolute; left: 300px; top: 400px; height: 250px; width: 600px"

                    <asp:Label ID="CurrentItemNameLabel" runat="server" Text="NAME OF ITEM" Font-Size ="40px"></asp:Label>
                    <hr>

                    <div style="position: absolute; left:232px; top:20px; ">
                        <asp:Label ID="ItemLabel1" runat="server" Text="Item 1"/>

                        <div style="height: 92px; width: 92px;">
                            <div style="position: absolute; left: 0; top:0;">
                                <asp:Image ID="ItemPicture1" runat="server" ImageUrl="~/Resources/ichaival.png" />
                            </div>
                            <div  style="position: absolute; left: 0; top:0;">
                                <asp:ImageButton ID="ItemFrame1" runat="server" ImageUrl="~/Resources/ItemFrameNeutral.png" OnClick="ItemPicture1_Click"/>
                            </div>
                        </div>
                    </div>

                    <div style="position: absolute; left: 339px; top:20px; ">
                        <asp:Label ID="ItemLabel2" runat="server" Text="Item 2"/>

                        <div style="width: 92px; height: 92px;">
                            <div style="position: absolute; left: 0; top:0;">
                                <asp:Image ID="ItemPicture2" runat="server" ImageUrl="~/Resources/ichaival.png" />
                            </div>
                            <div  style="position: absolute; left: 0; top:0;">
                                <asp:ImageButton ID="ItemFrame2" runat="server" ImageUrl="~/Resources/ItemFrameDamage.png" OnClick="ItemPicture2_Click"/>
                            </div>
                        </div>
                    </div>

                    <div style="position: absolute; left: 446px; top:20px;">
                        <asp:Label ID="ItemLabel3" runat="server" Text="Item 3"/>

                        <div style="width: 92px; height: 92px;">
                            <div style="position: absolute; left: 0; top:0;">
                                <asp:Image ID="ItemPicture3" runat="server" ImageUrl="~/Resources/ichaival.png" />
                            </div>
                            <div  style="position: absolute; left: 0; top:0;">
                                <asp:ImageButton ID="ItemFrame3" runat="server" ImageUrl="~/Resources/ItemFrameDamage.png" OnClick="ItemPicture3_Click"/>
                            </div>
                        </div>
                    </div>

                    <div style="position: absolute; left: 232px; top:132px;">
                        <asp:Label ID="ItemLabel4" runat="server" Text="Item 4"/>

                        <div style="height: 92px; width: 92px;">
                            <div style="position: absolute; left: 0; top:0;">
                                <asp:Image ID="ItemPicture4" runat="server" ImageUrl="~/Resources/ichaival.png" />
                            </div>
                            <div  style="position: absolute; left: 0; top:0;">
                                <asp:ImageButton ID="ItemFrame4" runat="server" ImageUrl="~/Resources/ItemFrameDamage.png" OnClick="ItemPicture4_Click"/>
                            </div>
                        </div>
                    </div>

                    <div style="position: absolute; left: 339px; top:132px;">
                        <asp:Label ID="ItemLabel5" runat="server" Text="Item 5"/>

                        <div style="height: 92px; width: 92px;">
                            <div style="position: absolute; left: 0; top:0;">
                                <asp:Image ID="ItemPicture5" runat="server" ImageUrl="~/Resources/ichaival.png" />
                            </div>
                            <div  style="position: absolute; left: 0; top:0;">
                                <asp:ImageButton ID="ItemFrame5" runat="server" ImageUrl="~/Resources/ItemFrameDamage.png" OnClick="ItemPicture5_Click"/>
                            </div>
                        </div>
                    </div>

                    <div style="position: absolute; left: 446px; top:132px;">
                        <asp:Label ID="ItemLabel6" runat="server" Text="Item 6"/>

                        <div style="height: 92px; width: 92px;">
                            <div style="position: absolute; left: 0; top:0;">
                                <asp:Image ID="ItemPicture6" runat="server" ImageUrl="~/Resources/ichaival.png" />
                            </div>
                            <div  style="position: absolute; left: 0; top:0;">
                                <asp:ImageButton ID="ItemFrame6" runat="server" ImageUrl="~/Resources/ItemFrameDamage.png" OnClick="ItemPicture6_Click"/>
                            </div>
                        </div>
                    </div>

                    <div style="position: absolute; left: 0; top:132px;">
                        <asp:Label ID="RelicaLabel1" runat="server" Text="Relic 1"/>

                        <div style="height: 92px; width: 92px;">
                            <div style="position: absolute; left: 0; top: 0;">
                                <asp:Image ID="RelicPicture1" runat="server" ImageUrl="~/Resources/ichaival.png" />
                            </div>
                            <div  style="position: absolute; left: 0; top:0;">
                                <asp:ImageButton ID="RelicFrame1" runat="server" ImageUrl="~/Resources/ItemFrameDamage.png" OnClick="RelicPicture1_Click"/>
                            </div>
                        </div>
                    </div>

                    <div style="position: absolute; left: 107px; top:132px;">
                        <asp:Label ID="RelicaLabel2" runat="server" Text="Relic 2"/>

                        <div style="height: 92px; width: 92px;">
                            <div style="position: absolute; left: 0; top:0;">
                                <asp:Image ID="RelicPicture2" runat="server" ImageUrl="~/Resources/ichaival.png" />
                            </div>
                            <div  style="position: absolute; left: 0; top:0;">
                                <asp:ImageButton ID="RelicFrame2" runat="server" ImageUrl="~/Resources/ItemFrameDamage.png" OnClick="RelicPicture2_Click"/>
                            </div>
                        </div>
                    </div>

                    <div style="position: absolute; left: 51px; top:20px;">
                        <asp:Label ID="StarterItemLabel" runat="server" Text="Starter item"/>

                        <div style="height: 92px; width: 92px;">
                            <div style="position: absolute; left: 0; top:0;">
                                <asp:Image ID="StarterItemPicture" runat="server" ImageUrl="~/Resources/ichaival.png" />
                            </div>
                            <div  style="position: absolute; left: 0; top:0;">
                                <asp:ImageButton ID="StarterItemFrame" runat="server" ImageUrl="~/Resources/ItemFrameDamage.png" OnClick="StarterItemPicture_Click"/>
                            </div>
                        </div>
                    </div>

                </div>



                <%-- ========================================================================== --%>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    
    <div class="GodUpdatePanel">        
        <asp:UpdatePanel ID="GodUpdatePanel" runat="server">
            <ContentTemplate>
                <legend>God</legend>
                <%-- ================================= God ==================================== --%>
               
<%--                <asp:Label ID="GodLabel" runat="server" Text="God"/>
                <asp:ImageButton ID="GodPicture" runat="server" AlternateText="GodPicture" ImageUrl="~/Resources/agni.png" OnClick="GodPicture_Click" />--%>


                <%-- ========================================================================== --%>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>


    <div class="RerollUpdatePanel">        
        <asp:UpdatePanel ID="RerollUpdatePanel" runat="server">
            <ContentTemplate>
                <legend>Rerolls</legend>
                <%-- ================================= Items and God ================================== --%>
                
                <asp:Label ID="RerollLabel" runat="server" Text="Rerolls" Font-Size="10px" ForeColor="Red" Font-Bold="true"/>
                <asp:Label ID="RerollNumber" runat="server" Text="0" Font-Size="20"/>
                
                <%-- ========================================================================== --%>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>















    <div class="Template">        
        <asp:UpdatePanel ID="Template" runat="server">
            <ContentTemplate>
                <legend>Template</legend>
                <%-- ================================= Items and God ================================== --%>
               

                <%-- ========================================================================== --%>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>











    <%--<div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>--%>

</asp:Content>
