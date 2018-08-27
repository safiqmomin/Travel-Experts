<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomerBookings.aspx.cs" Inherits="TravelExpertsWeb.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="jumbotron">
    <b style="font-size: large"><asp:Label ID="Label1" runat="server" Text="Welcome: "></asp:Label></b>
        <span style="font-size: large">
    <asp:Label ID="lblUserEmail" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
    <br />
        </span>
    <b style="font-size: large"><asp:Label ID="Label2" runat="server" Text="Your Customer ID #: "></asp:Label></b>
        <span style="font-size: large">
    <asp:Label ID="lblSession" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
    <br />
        </span>
    <b style="font-size: large"><asp:Label ID="Label4" runat="server" Text="The total of all your packages: "></asp:Label></b>
    <asp:Label ID="lblPackageTotal" runat="server" Font-Bold="True" ForeColor="#0000CC" style="font-size: large"></asp:Label>
    <br />
    </div>
    
    <div class="jumbotron">
    <asp:GridView class="table table-responsive" ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="BookingId" HeaderText="BookingID" SortExpression="BookingId" />
            <asp:BoundField DataField="CustomerId" HeaderText="CustomerID" SortExpression="CustomerId" />
            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
            <asp:BoundField DataField="Destination" HeaderText="Destination" SortExpression="Destination" />
            <asp:BoundField DataField="BasePrice" HeaderText="BasePrice" SortExpression="BasePrice" DataFormatString="{0:c}" />
            <asp:BoundField DataField="TravelerCount" HeaderText="TravelerCount" SortExpression="TravelerCount" />
            <asp:BoundField DataField="BookingDate" HeaderText="BookingDate" SortExpression="BookingDate" DataFormatString="{0:d}" />
            <asp:BoundField DataField="TripStart" HeaderText="TripStart" SortExpression="TripStart" DataFormatString="{0:d}" />
            <asp:BoundField DataField="TripEnd" HeaderText="TripEnd" SortExpression="TripEnd" DataFormatString="{0:d}" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <EmptyDataTemplate>
            <asp:Label ID="Label6" runat="server" Text="You currently have no booked packages."></asp:Label>
        </EmptyDataTemplate>
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
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetBooking" TypeName="TravelExpertsWeb.App_Code.BookingDB">
        <SelectParameters>
            <asp:SessionParameter Name="CustomerID" SessionField="UserID" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <br />
    </div>
    <br />
    <br />
</asp:Content>
