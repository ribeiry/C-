<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lojinha.aspx.cs" Inherits="ExLoja.Lojinha" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
            height: 343px;
        }
        .auto-style2 {
            margin-left: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <pre><strong>Consulta ao Estoque de Produtos</strong></pre>
        <pre><strong>Descricção do Produto</strong></pre>
        <pre class="auto-style2"><asp:TextBox ID="txtDescr" runat="server" Width="412px"></asp:TextBox>  <asp:Button ID="btnProcura" runat="server" OnClick="btnProcura_Click" Text="Button" Width="121px" /><asp:GridView ID="grvResult" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" Height="183px" Width="423px"><FooterStyle BackColor="#99CCCC" ForeColor="#003399" /><HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" /><PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" /><RowStyle BackColor="White" ForeColor="#003399" /><SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" /><SortedAscendingCellStyle BackColor="#EDF6F6" /><SortedAscendingHeaderStyle BackColor="#0D4AC4" /><SortedDescendingCellStyle BackColor="#D6DFDF" /><SortedDescendingHeaderStyle BackColor="#002876" /></asp:GridView></pre>
    
    </div>
    </form>
</body>
</html>
