<%@ Page Title="TaskManagement" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TaskManagement.aspx.cs" Inherits="TaskManagementApp" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Task Management</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- Display the list of tasks using a GridView -->
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="ID" />
                    <asp:BoundField DataField="Title" HeaderText="Title" />
                    <asp:BoundField DataField="DueDate" HeaderText="Due Date" DataFormatString="{0:yyyy-MM-dd}" />
                    <asp:TemplateField HeaderText="Is Completed">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<% Eval("IsCompleted") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Actions">
                        <ItemTemplate>
                            <asp:HyperLink ID="lnkEdit" runat="server" Text="Edit" NavigateUrl='<% "TaskManagementApp.aspx?action=edit&id=" + Eval("Id") %>' />
                            &nbsp;
                            <asp:LinkButton ID="lnkDelete" runat="server" Text="Delete" OnClick="DeleteTask" CommandArgument='<% Eval("Id") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

            <!-- Input fields for Title, Due Date, Is Completed for adding/editing tasks -->
            <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
            <asp:CheckBox ID="chkIsCompleted" runat="server" />
            <asp:Calendar ID="calDueDate" runat="server" />

            <!-- Add/Edit and Cancel buttons -->
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="SaveTask" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="CancelTask" />
        </div>
    </form>
</body>
</html>
