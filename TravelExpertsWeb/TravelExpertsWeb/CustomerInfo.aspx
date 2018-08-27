<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomerInfo.aspx.cs" Inherits="TravelExpertsWeb.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtFirstName" runat="server" MaxLength="20"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstName" Display="Dynamic" ErrorMessage="First Name is Mandatory" ForeColor="Red" ValidationGroup="MKE"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                     <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
                     <asp:TextBox CssClass="form-control" ID="txtLastName" runat="server" MaxLength="20"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLastName" Display="Dynamic" ErrorMessage="Lastt Name is Mandatory" ForeColor="Red" ValidationGroup="MKE"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                     <asp:Label ID="Label3" runat="server" Text="Country"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtCountry" runat="server" MaxLength="20"></asp:TextBox>
                </div>
                <div class="form-group">
                     <asp:Label ID="Label4" runat="server" Text="Province"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtProv" runat="server" MaxLength="15"></asp:TextBox>
                </div>
                <div>
                     <asp:Label ID="Label5" runat="server" Text="Postal Code"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtPostal" runat="server" MaxLength="7"></asp:TextBox>
                    <ajaxToolkit:MaskedEditExtender ID="ME_PostalCode" runat="server" TargetControlID="txtPostal" MaskType="None" Mask="LNL NLN" MessageValidatorTip="true" ClearMaskOnLostFocus="true"  />
                    <ajaxToolkit:MaskedEditValidator ID="MEV_PostalCode" runat="server" ControlExtender="ME_PostalCode" InitialValue="" EmptyValueBlurredText="000" EmptyValueMessage="Postal Code is required" ErrorMessage="Postal Code is Invalid" Display="None" ControlToValidate="txtPostal" ValidationExpression="^([ABCEGHJKLMNPRSTVXYabceghjklmnprstvxy]\d[ABCEGHJKLMNPRSTVWXYZabceghjklmnprstvwxyz])\s{0,1}(\d[ABCEGHJKLMNPRSTVWXYZabceghjklmnprstvwxyz]\d)$" IsValidEmpty="false" InvalidValueMessage="Postal Code is Invalid" ValidationGroup="MKE" />
                </div>
                <div class="form-gorup">
                     <asp:Label ID="Label6" runat="server" Text="City"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtCity" runat="server" MaxLength="40"></asp:TextBox>
                </div>
                <div class="form-group">
                     <asp:Label ID="Label7" runat="server" Text="Address"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtAddress" runat="server" MaxLength="70"></asp:TextBox>
                </div>
                <div class="form-group">
                      <asp:Label ID="Label8" runat="server" Text="Business Phone"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtBusPhone" runat="server" TextMode="Phone"></asp:TextBox>
                      <ajaxToolkit:MaskedEditExtender ID="MaskedEditExtender2"  runat="server"
                       TargetControlID="txtBusPhone"
                       Mask="999-999-9999"
                       ClearMaskOnLostFocus="false"
                       MessageValidatorTip="true"
                   ></ajaxToolkit:MaskedEditExtender>
                   <ajaxToolkit:MaskedEditValidator ID="MaskedEditValidator2"  runat="server"
                       ControlExtender="MaskedEditExtender2"
                       ControlToValidate="txtBusPhone"
                       IsValidEmpty="False" ValidationExpression ="[0-9]{3}\-[0-9]{3}\-[0-9]{4}"
                       EmptyValueMessage="input is required"
                       InvalidValueMessage="input is invalid"
                       Display="Dynamic"
                       TooltipMessage="XXX-XXX-XXXX"
                       EmptyValueBlurredText="Phone number should not be empty!"
                       InvalidValueBlurredMessage="Please input the right phone number!"
                       ValidationGroup="MKE" ></ajaxToolkit:MaskedEditValidator>
                </div>
                <div class="form-group">
                     <asp:Label ID="Label9" runat="server" Text="Home Phone"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtHomePhone" runat="server" TextMode="Phone"></asp:TextBox>
                    <ajaxToolkit:MaskedEditExtender ID="MaskedEditExtender1"  runat="server"
                       TargetControlID="txtHomePhone"
                       Mask="999-999-9999"
                       ClearMaskOnLostFocus="false"
                       MessageValidatorTip="true"
                   ></ajaxToolkit:MaskedEditExtender>
                   <ajaxToolkit:MaskedEditValidator ID="MaskedEditValidator1"  runat="server"
                       ControlExtender="MaskedEditExtender2"
                       ControlToValidate="txtHomePhone"
                       IsValidEmpty="False" ValidationExpression ="[0-9]{3}\-[0-9]{3}\-[0-9]{4}"
                       EmptyValueMessage="input is required"
                       InvalidValueMessage="input is invalid"
                       Display="Dynamic"
                       TooltipMessage="XXX-XXX-XXXX"
                       EmptyValueBlurredText="Phone number should not be empty!"
                       InvalidValueBlurredMessage="Please input the right phone number!"
                       ValidationGroup="MKE" ></ajaxToolkit:MaskedEditValidator>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label10" runat="server" Text="Email"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtEmailID" runat="server" TextMode="Email" ReadOnly="True"></asp:TextBox>

                </div>
                    <asp:Button CssClass="btn btn-primary" ID="btnRegister" runat="server" Text="Save" OnClick="Register_Click" ValidationGroup="MKE" />
                    <asp:Button CssClass="btn btn-primary" ID="btnClear" runat="server" Text="Reset" CausesValidation="False" OnClick="btnClear_Click" />

        <br />
        <asp:Label ID="lblSuccess" runat="server" Text="Information successfully saved" Visible="False"></asp:Label>
        <br />
</asp:Content>
