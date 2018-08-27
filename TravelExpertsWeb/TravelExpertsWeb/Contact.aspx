<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="TravelExpertsWeb.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<!-- Author:Sneha Patel(000783907) Date:29-July-2018 Purpose: designing Contact Page with pulling data from database and inquiry form with validation for Admin -->
    <fieldset style="text-align:center">
    <legend><h2 style="text-align:center"><%: Title %></h2></legend>

    <div class="jumbotron">
    <h3 style="text-align:center; color:blue"><u>Contact Us at Calgary Location</u></h3>
    <address><b style="font-size: large">
        1155 8th Avenue SW<br />
        Calgary, AB T2P 1N3 Canada<br />
        <abbr title="Phone">P:</abbr>
        403.271.9873<br/>
        <abbr title="Fax">F:</abbr>       
        403.271.9872</b></address>
    <address>
        <asp:GridView style="text-align:left" class="table table-responsive-sm" ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="AgentId" HeaderText="Agent ID" SortExpression="AgentId" ReadOnly="True" />
                <asp:BoundField DataField="AgtFirstName" HeaderText="FirstName" SortExpression="AgtFirstName" ReadOnly="True" />
                <asp:BoundField DataField="AgtMiddleInitial" HeaderText="MiddleInitial" SortExpression="AgtMiddleInitial" ReadOnly="True" />
                <asp:BoundField DataField="AgtLastName" HeaderText="LastName" SortExpression="AgtLastName" ReadOnly="True" />
                <asp:BoundField DataField="AgtBusPhone" HeaderText="PhoneNumber" SortExpression="AgtBusPhone" ReadOnly="True" />
                <asp:BoundField DataField="AgtEmail" HeaderText="Email" SortExpression="AgtEmail" ReadOnly="True" />
                <asp:BoundField DataField="AgtPosition" HeaderText="Agent Position" SortExpression="AgtPosition" ReadOnly="True" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetAgencyOneAgents" TypeName="TravelExpertsWeb.App_Code.AgentsDB"></asp:ObjectDataSource>
    </address>
    </div>
    <div class="jumbotron">
    <h3 style="text-align:center; color:blue"><u>Contact Us at Okotoks Location </u></h3>
        <address><b style="font-size: large">
        110 Main Street<br />
        Okotoks, AB T7R 3J5 Canada<br />
        <abbr title="Phone">P:</abbr>
        403.563.2381<br/>
        <abbr title="Fax">F:</abbr>             
        403.563.2381</b></address>
    <address>      
        <asp:GridView style="text-align:left" class="table table-responsive-sm" ID="GridView2" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjectDataSource2" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="AgentId" HeaderText="Agent ID" ReadOnly="True" SortExpression="AgentId" />
                <asp:BoundField DataField="AgtFirstName" HeaderText="FirstName" ReadOnly="True" SortExpression="AgtFirstName" />
                <asp:BoundField DataField="AgtMiddleInitial" HeaderText="MiddleInitial" ReadOnly="True" SortExpression="AgtMiddleInitial" />
                <asp:BoundField DataField="AgtLastName" HeaderText="LastName" ReadOnly="True" SortExpression="AgtLastName" />
                <asp:BoundField DataField="AgtBusPhone" HeaderText="PhoneNumber" ReadOnly="True" SortExpression="AgtBusPhone" />
                <asp:BoundField DataField="AgtEmail" HeaderText="Email" ReadOnly="True" SortExpression="AgtEmail" />
                <asp:BoundField DataField="AgtPosition" HeaderText="Agent Position" ReadOnly="True" SortExpression="AgtPosition" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetAgencyTwoAgents" TypeName="TravelExpertsWeb.App_Code.AgentsDB"></asp:ObjectDataSource>       
    </address>
    </div>

   <div class="jumbotron">  
    <address>
        <fieldset>
            <legend>Contact Us</legend>
            <p><b style="font-size: small"> If&nbsp; you have any questions about our packages or need additional information please feel free to contact us and send us your questions or concerns.</b></p>
               <table style="text-align:left" class="table table-responsive">
                <tr>
                    <td style="width: 131px">
                        <b>Your Name:</b>
                    </td>
                    <td style="width: 256px">
                        <asp:TextBox class="form-control"  ID="txtName" width="200px" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                            runat="server" 
                            ErrorMessage="Name is required" ControlToValidate="txtName" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                 <tr>
                    <td style="width: 131px">
                        <b>Your Email:</b>
                    </td>
                    <td style="width: 256px">
                        <asp:TextBox class="form-control"  ID="txtEmail" width="200px" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
                            runat="server" 
                            ErrorMessage="Email is required" ControlToValidate="txtEmail" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Please enter a valid Email" Display="Dynamic" ForeColor="Red" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                 <tr>
                    <td style="width: 131px">
                        <b>Your Subject:</b>
                    </td>
                    <td style="width: 256px">
                        <asp:TextBox class="form-control"  ID="txtSubject" width="200px" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" 
                            runat="server" 
                            ErrorMessage="Subject is required" ControlToValidate="txtSubject" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                  <tr>
                    <td style="vertical-align:top; width: 131px;">
                        <b>Your Comments:</b>
                    </td>
                    <td style="vertical-align:top; width: 256px;">
                        <asp:TextBox class="form-control"  ID="txtComments" width="200px" runat="server" Rows="5" TextMode="MultiLine"></asp:TextBox>
                    </td>
                    <td style="vertical-align:top">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" 
                            runat="server" 
                            ErrorMessage="Comments are required" ControlToValidate="txtComments" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label style="margin-top:10px" ID="Label1"  runat="server" Font-Bold="true" ForeColor="Blue"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button class="btn btn-success" style="margin-top:8px" ID="btnSubmit"  runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                    </td>
                </tr>
            </table>
        </fieldset>
    </address>
    </div>
    <address>
        <strong>TravelExpert's Help-Line:</strong>   <a href="mailto:travelexpert072018@gmail.com">travelexpert072018@gmail.com</a><br />        
    </address>
    </fieldset>
</asp:Content>
