<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DankSmiteOnline2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="ItemUpdatePanel" style="position:relative; left: 595px; top: 50px;">        
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <asp:Button ID="BuildButton" runat="server" Text="Build!" style="background-color: coral; color:blueviolet;height: 70px; width: 200px; font-size: 35px;" onclick="BuildButton_Click"></asp:Button>
                <div style="position:relative;">
                    <asp:TextBox ID="InputField" runat="server" ></asp:TextBox>
                </div>
                <%--<input type="text" id="InputField" style="position:relative; left:30px; bottom: 25px;"/>--%>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>

   <%-- Checkbox section --%>
    <div class="ItemUpdatePanel" style="position:relative; left: 595px; top: 120px;">        
        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
            <ContentTemplate>
                <div style="position:absolute; left: 50px;">
                    <label>Magical</label>
                    <label style="position:absolute; top:20px; left:15px;"> <asp:CheckBox ID="GuardianCheckbox" runat="server" Checked="true" style="position:absolute; left: -15px;"/>Guardian</label>
                    <label style="position:absolute; top:40px; left:15px;"><asp:CheckBox ID="MageCheckbox" runat="server" Checked="true" style="position:absolute; left: -15px;"/>Mage</label>
                </div>

                <div style="position:absolute; left: 200px;">
                    <label>Physical</label>
                    <label style="position:absolute; top:20px; left:15px;"><asp:CheckBox ID="HunterCheckbox" runat="server" Checked="true" style="position:absolute; left: -15px;"/>Hunter</label>
                    <label style="position:absolute; top:40px; left:15px;"><asp:CheckBox ID="AssassinCheckbox" runat="server" Checked="true" style="position:absolute; left: -15px;"/>Assassin</label>
                    <label style="position:absolute; top:60px; left:15px;"><asp:CheckBox ID="WarriorCheckbox" runat="server" Checked="true" style="position:absolute; left: -15px;"/>Warrior</label>
                </div>

                <div style="position:absolute; left: 350px;">
                    <label>Item Type</label>
                    <label style="position:absolute; top:20px; left:15px;"><asp:CheckBox ID="DamageCheckbox" runat="server" Checked="true" style="position:absolute; left: -15px;"/>Damage</label>
                    <label style="position:absolute; top:40px; left:15px;"><asp:CheckBox ID="HybridCheckbox" runat="server" Checked="true" style="position:absolute; left: -15px;"/>Hybrid</label>
                    <label style="position:absolute; top:60px; left:15px;"><asp:CheckBox ID="DefenseCheckbox" runat="server" Checked="true" style="position:absolute; left: -15px;"/>Defense</label>
                </div>

            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    

    
    <div class="ItemUpdatePanel" style="position:relative; height: 600px; left: 595px; top: 310px;">        
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <%-- ================================= Items ================================== --%>
                <div style="position: absolute; left: 0px; top: 0px; height: 250px; width: 600px">

                    <div style="position: absolute; left:150px; top:0px; ">
                        <asp:Label ID="CurrentItemNameLabel" runat="server" Text="Spear of Desolation" Font-Size ="34px"></asp:Label>
                    </div>

                    <div style="position: absolute; left:232px; top:70px; ">
                        <asp:Label ID="ItemLabel1" runat="server" Text="Item 1"/>

                        <div style="position:absolute; height: 92px; width: 92px; top:30px">
                            <div style="position: absolute; left: 0; top:0;">
                                <asp:Image ID="ItemPicture1" runat="server" ImageUrl="~/Resources/ichaival.png"/>
                            </div>
                            <div  style="position: absolute; left: 0; top:0;" onmouseover="pictureBox1_Hover">
                                <asp:ImageButton ID="ItemFrame1" runat="server" ImageUrl="~/Resources/ItemFrameNeutral.png" OnClick="ItemPicture1_Click"/>
                            </div>
                        </div>
                    </div>

                    <div style="position: absolute; left: 339px; top:70px; ">
                        <asp:Label ID="ItemLabel2" runat="server" Text="Item 2"/>

                        <div style="position:absolute; height: 92px; width: 92px; top:30px">
                            <div style="position: absolute; left: 0; top:0;">
                                <asp:Image ID="ItemPicture2" runat="server" ImageUrl="~/Resources/ichaival.png" />
                            </div>
                            <div  style="position: absolute; left: 0; top:0;">
                                <asp:ImageButton ID="ItemFrame2" runat="server" ImageUrl="~/Resources/ItemFrameDamage.png" OnClick="ItemPicture2_Click"/>
                            </div>
                        </div>
                    </div>

                    <div style="position: absolute; left: 446px; top:70px;">
                        <asp:Label ID="ItemLabel3" runat="server" Text="Item 3"/>

                        <div style="position:absolute; height: 92px; width: 92px; top:30px">
                            <div style="position: absolute; left: 0; top:0;">
                                <asp:Image ID="ItemPicture3" runat="server" ImageUrl="~/Resources/ichaival.png" />
                            </div>
                            <div  style="position: absolute; left: 0; top:0;">
                                <asp:ImageButton ID="ItemFrame3" runat="server" ImageUrl="~/Resources/ItemFrameDamage.png" OnClick="ItemPicture3_Click"/>
                            </div>
                        </div>
                    </div>

                    <div style="position: absolute; left: 232px; top:202px;">
                        <asp:Label ID="ItemLabel4" runat="server" Text="Item 4"/>

                        <div style="position:absolute; height: 92px; width: 92px; top:30px">
                            <div style="position: absolute; left: 0; top:0;">
                                <asp:Image ID="ItemPicture4" runat="server" ImageUrl="~/Resources/ichaival.png" />
                            </div>
                            <div  style="position: absolute; left: 0; top:0;">
                                <asp:ImageButton ID="ItemFrame4" runat="server" ImageUrl="~/Resources/ItemFrameDamage.png" OnClick="ItemPicture4_Click"/>
                            </div>
                        </div>
                    </div>

                    <div style="position: absolute; left: 339px; top:202px;">
                        <asp:Label ID="ItemLabel5" runat="server" Text="Item 5"/>

                        <div style="position:absolute; height: 92px; width: 92px; top:30px">
                            <div style="position: absolute; left: 0; top:0;">
                                <asp:Image ID="ItemPicture5" runat="server" ImageUrl="~/Resources/ichaival.png" />
                            </div>
                            <div  style="position: absolute; left: 0; top:0;">
                                <asp:ImageButton ID="ItemFrame5" runat="server" ImageUrl="~/Resources/ItemFrameDamage.png" OnClick="ItemPicture5_Click"/>
                            </div>
                        </div>
                    </div>

                    <div style="position: absolute; left: 446px; top:202px;">
                        <asp:Label ID="ItemLabel6" runat="server" Text="Item 6"/>

                        <div style="position:absolute; height: 92px; width: 92px; top:30px">
                            <div style="position: absolute; left: 0; top:0;">
                                <asp:Image ID="ItemPicture6" runat="server" ImageUrl="~/Resources/ichaival.png"/>
                            </div>
                            <div  style="position: absolute; left: 0; top:0;">
                                <asp:ImageButton ID="ItemFrame6" runat="server" ImageUrl="~/Resources/ItemFrameDamage.png" OnClick="ItemPicture6_Click"/>
                            </div>
                        </div>
                    </div>

                    <div style="position: absolute; left: 0; top:202px;">
                        <asp:Label ID="RelicLabel1" runat="server" Text="Relic 1"/>

                        <div style="position:absolute; height: 92px; width: 92px; top:30px">
                            <div style="position: absolute; left: 0; top: 0;">
                                <asp:Image ID="RelicPicture1" runat="server" ImageUrl="~/Resources/ichaival.png" />
                            </div>
                            <div  style="position: absolute; left: 0; top:0;">
                                <asp:ImageButton ID="RelicFrame1" runat="server" ImageUrl="~/Resources/ItemFrameDamage.png" OnClick="RelicPicture1_Click"/>
                            </div>
                        </div>
                    </div>

                    <div style="position: absolute; left: 107px; top:202px;">
                        <asp:Label ID="RelicLabel2" runat="server" Text="Relic 2"/>

                        <div style="position:absolute; height: 92px; width: 92px; top:30px">
                            <div style="position: absolute; left: 0; top:0;">
                                <asp:Image ID="RelicPicture2" runat="server" ImageUrl="~/Resources/ichaival.png" />
                            </div>
                            <div  style="position: absolute; left: 0; top:0;">
                                <asp:ImageButton ID="RelicFrame2" runat="server" ImageUrl="~/Resources/ItemFrameDamage.png" OnClick="RelicPicture2_Click"/>
                            </div>
                        </div>
                    </div>

                    <div style="position: absolute; left: 51px; top:70px;">
                        <asp:Label ID="StarterItemLabel" runat="server" Text="Starter item"/>

                        <div style="position:absolute; height: 92px; width: 92px; top:30px">
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
    
    <div class="GodUpdatePanel" style="position:absolute; left:420px; top:150px;">        
        <asp:UpdatePanel ID="GodUpdatePanel" runat="server">
            <ContentTemplate>
                <%-- ================================= God ==================================== --%>
                <div style="position:relative; left:150px; top:70px;">
                    <asp:Label ID="GodLabel" runat="server" Text="Agni" Font-Size ="34px" ></asp:Label>
                </div>
                <div style="position: absolute; left:0; top:0;">

                        <div style="position:absolute; height: 92px; width: 92px; top:30px">
                            <div style="position: absolute; left: 0; top:0;">
                                <asp:Image ID="GodPicture" runat="server" ImageUrl="~/Resources/agni.png" />
                            </div>
                            <div  style="position: absolute; left: 0; top:0;">
                                <asp:ImageButton ID="GodFrame" runat="server" ImageUrl="~/Resources/DankFrameBlue.png" OnClick="GodPicture_Click"/>
                            </div>
                        </div>
                    </div>
                <%-- ========================================================================== --%>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    
    <div class="GeneralTextBoxPanel" style="position: absolute; left:420px; top:350px; width: 400px; background-color:grey">
        <asp:UpdatePanel ID="GeneralTextBoxPanel" runat="server">
            <ContentTemplate>
                
                <asp:Label ID="GeneralTextBox" runat="server" Text="Default" Font-Size="25px" ForeColor="#ff9900"/>
                
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>

    <div class="ButtonPanel">        
        <asp:UpdatePanel ID="ButtonPanel" runat="server">
            <ContentTemplate>

                <asp:Button ID="CreditsButton" runat="server" Text="Credits" OnClick="CreditsButon_Click"/>
                <asp:Button ID="WelcomeButton" runat="server" Text="Welcome!" OnClick="WelcomeButton_Click"/>
                
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>


    <div class="RerollUpdatePanel">        
        <asp:UpdatePanel ID="RerollUpdatePanel" runat="server">
            <ContentTemplate>

                <asp:Label ID="RerollLabel" runat="server" Text="Rerolls" Font-Size="50px" ForeColor="Red" Font-Bold="true"/>
                <asp:Label ID="RerollNumber" runat="server" Text="0" Font-Size="50px"/>
                
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>


    </div>


        <%--<div class="GeneralTextBoxPanel">        
        <asp:UpdatePanel ID="GeneralTextBoxPanel1" runat="server">
            <ContentTemplate>
                <%-- ================================= Generals purpose text box ================================== 
                <div style="position: absolute; left: 421px; top: 370px; height: 600px; width: 600px">
                    <asp:TextBox ID="GeneralTextBox1" runat="server" text="Default" Font-Size="24px" ForeColor="#cc00ff" Font-Bold="true" BackColor="#336600" Height="400px" Width="400px"/>
                    
                     
                </div>
                <%--<asp:Label ID="Label1" runat="server" Text="Rerolls" Font-Size="10px" ForeColor="Red" Font-Bold="true"/>
                
                <%-- ========================================================================== 
            </ContentTemplate>
        </asp:UpdatePanel>--%>

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
