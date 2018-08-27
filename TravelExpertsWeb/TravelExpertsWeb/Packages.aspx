<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Packages.aspx.cs" Inherits="TravelExpertsWeb.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Carousel" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="ObjectDataSource1">  
        <ItemTemplate>
            <table>
                <tr>
                    <%--<td style="width: 10px">
                        <asp:Image ID="imgTravelPkg" ImageUrl='<%# String.Format("Images/ImgPkg{0}.jpg",Eval("PackageId"))%>' runat="server" Style="width: 300px" />
                    </td>--%>
                    <td style="width: 450px">
                        <table>
                        <tr>
                            <td>
                                <b>Id:</b>
                            </td>
                            <td>
                                <asp:Label ID="lblID" runat="server" Text='<%#Eval("PackageId")%>'>
                                </asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <b>Package Name:</b>
                            </td>
                            <td>
                                <asp:Label ID="lblPkgName" runat="server" Text='<%#Eval("PkgName")%>'>
                                </asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <b>Package Start Date:</b>
                            </td>
                            <td>
                                <asp:Label ID="lblPkgStartDate" runat="server" Text='<%# string.Format("{0:D}", Eval("PkgStartDate"))%>'>
                                </asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <b>Package End Date:</b>
                            </td>
                            <td>
                                <asp:Label ID="lblPkgEndDate" runat="server" Text='<%# string.Format("{0:D}", Eval("PkgEndDate"))%>'>
                                </asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <b>Description:</b>
                            </td>
                            <td>
                                <asp:Label ID="lblPkgDescription" runat="server" Text='<%#Eval("PkgDesc")%>'>
                                </asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <b>Price:</b>
                            </td>
                            <td>
                                <asp:Label ID="lblBasePrice" runat="server" Text='<%# string.Format("{0:c}", Eval("PkgBasePrice"))%>'>
                                </asp:Label>
                            </td>
                        </tr>
                     </table>
                    </td>
                </tr>
                </br>
            </table>
        </ItemTemplate>


    </asp:Repeater>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetPackage" TypeName="TravelExpertsWeb.App_Code.PackageDB"></asp:ObjectDataSource>
</asp:Content>
