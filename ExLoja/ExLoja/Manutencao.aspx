<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Manutencao.aspx.cs" Inherits="ExLoja.Manutencao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 481px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <pre class="auto-style1"><strong>Manutenção de Produtos</strong></pre>
    
    </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:exclojaConnectionString %>" DeleteCommand="DELETE FROM [Produtos] WHERE [Codigo] = @Codigo" InsertCommand="INSERT INTO [Produtos] ([Codigo], [DescProd], [QtdProd]) VALUES (@Codigo, @DescProd, @QtdProd)" SelectCommand="SELECT * FROM [Produtos]" UpdateCommand="UPDATE [Produtos] SET [DescProd] = @DescProd, [QtdProd] = @QtdProd WHERE [Codigo] = @Codigo">
            <DeleteParameters>
                <asp:Parameter Name="Codigo" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Codigo" Type="Int32" />
                <asp:Parameter Name="DescProd" Type="String" />
                <asp:Parameter Name="QtdProd" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="DescProd" Type="String" />
                <asp:Parameter Name="QtdProd" Type="Int32" />
                <asp:Parameter Name="Codigo" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <table class="auto-style2">
            <tr>
                <td class="auto-style3">
                    <asp:GridView ID="grvResult" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Codigo" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="482px">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:CommandField CancelText="Cancelar" DeleteText="Deletar" EditText="Editar" InsertText="Inserir" SelectText="Selecionar" ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" UpdateText="Atualizar" />
                            <asp:BoundField DataField="Codigo" HeaderText="Codigo" ReadOnly="True" SortExpression="Codigo" />
                            <asp:BoundField DataField="DescProd" HeaderText="Descrição" SortExpression="DescProd" />
                            <asp:BoundField DataField="QtdProd" HeaderText="Quantidade" SortExpression="QtdProd" />
                            <asp:CommandField />
                            <asp:BoundField DataField="Codigo" ReadOnly="True" SortExpression="Codigo" />
                        </Columns>
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                    </asp:GridView>
                </td>
                <td>
                    <asp:FormView ID="FormView1" runat="server" AllowPaging="True" DataKeyNames="Codigo" DataSourceID="SqlDataSource2" Height="107px" Width="363px">
                        <EditItemTemplate>
                            Codigo:
                            <asp:DynamicControl ID="CodigoDynamicControl" runat="server" DataField="Codigo" Mode="ReadOnly" />
                            <br />
                            DescProd:
                            <asp:DynamicControl ID="DescProdDynamicControl" runat="server" DataField="DescProd" Mode="Edit" />
                            <br />
                            QtdProd:
                            <asp:DynamicControl ID="QtdProdDynamicControl" runat="server" DataField="QtdProd" Mode="Edit" />
                            <br />
                            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" ValidationGroup="Insert" />
                            &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                        </EditItemTemplate>
                        <InsertItemTemplate>
                            Codigo:
                            <asp:DynamicControl ID="CodigoDynamicControl" runat="server" DataField="Codigo" Mode="Insert" ValidationGroup="Insert" />
                            <br />
                            DescProd:
                            <asp:DynamicControl ID="DescProdDynamicControl" runat="server" DataField="DescProd" Mode="Insert" ValidationGroup="Insert" />
                            <br />
                            QtdProd:
                            <asp:DynamicControl ID="QtdProdDynamicControl" runat="server" DataField="QtdProd" Mode="Insert" ValidationGroup="Insert" />
                            <br />
                            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" ValidationGroup="Insert" />
                            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                        </InsertItemTemplate>
                        <ItemTemplate>
                            Codigo:
                            <asp:DynamicControl ID="CodigoDynamicControl" runat="server" DataField="Codigo" Mode="ReadOnly" />
                            <br />
                            DescProd:
                            <asp:DynamicControl ID="DescProdDynamicControl" runat="server" DataField="DescProd" Mode="ReadOnly" />
                            <br />
                            QtdProd:
                            <asp:DynamicControl ID="QtdProdDynamicControl" runat="server" DataField="QtdProd" Mode="ReadOnly" />
                            <br />
                            <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
                            &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
                            &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
                        </ItemTemplate>
                    </asp:FormView>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:exclojaConnectionString %>" DeleteCommand="DELETE FROM [Produtos] WHERE [Codigo] = @Codigo" InsertCommand="INSERT INTO [Produtos] ([Codigo], [DescProd], [QtdProd]) VALUES (@Codigo, @DescProd, @QtdProd)" SelectCommand="SELECT * FROM [Produtos] WHERE ([Codigo] = @Codigo)" UpdateCommand="UPDATE [Produtos] SET [DescProd] = @DescProd, [QtdProd] = @QtdProd WHERE [Codigo] = @Codigo">
                        <DeleteParameters>
                            <asp:Parameter Name="Codigo" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="Codigo" Type="Int32" />
                            <asp:Parameter Name="DescProd" Type="String" />
                            <asp:Parameter Name="QtdProd" Type="Int32" />
                        </InsertParameters>
                        <SelectParameters>
                            <asp:ControlParameter ControlID="grvResult" Name="Codigo" PropertyName="SelectedValue" Type="Int32" />
                        </SelectParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="DescProd" Type="String" />
                            <asp:Parameter Name="QtdProd" Type="Int32" />
                            <asp:Parameter Name="Codigo" Type="Int32" />
                        </UpdateParameters>
                    </asp:SqlDataSource>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
