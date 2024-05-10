<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarTareaCiudadano.aspx.cs" Inherits="SistemaEastview.MantenedorTareaCiudadano.ListarTareaCiudadano" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../css/index.css" rel="stylesheet" />
    <script src="../js/jquery-1.11.0.min.js" type="text/javascript"></script>
    <script src="../js/index.js" type="text/javascript"></script>
    <link rel="stylesheet" type="text/css" href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" />
    <link href="../css/bootstrap.min.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class='dashboard'>
        <div class="dashboard-nav">
            <header>
                    <a href="../Default.aspx" class="menu-toggle"><i class="fa fa-bars"></i></a><a href="../Default.aspx"
                        class="brand-logo"><i class="fa fa-anchor"></i><span>Eastview</span></a>
                </header>
            <nav class="dashboard-nav-list">
                    <a href="../Default.aspx" class="dashboard-nav-item"><i class="fa fa-home"></i>
                        Inicio </a><%--<a
                            href="#" class="dashboard-nav-item active"><i class="fas fa-tachometer-alt"></i>dashboard
                        </a><a
                            href="#" class="dashboard-nav-item"><i class="fas fa-file-upload"></i>Upload </a>--%>
                    <div class='dashboard-nav-dropdown'>
                        <a href="#!" class="dashboard-nav-item dashboard-nav-dropdown-toggle"><i
                            class="fa fa-photo-video"></i>Mantenedor</a>
                        <div class='dashboard-nav-dropdown-menu'>
                            <a href="../MatenedorCiudadano/ListaCiudadano.aspx" class="dashboard-nav-dropdown-item">Ciudadanos</a>
                            <a href="ListarTareaCiudadano.aspx" class="dashboard-nav-dropdown-item">Tareas de Ciudadanos</a>
                            <a href="../VistaTarea/VerTareas.aspx" class="dashboard-nav-dropdown-item">Ver Tareas</a>
                        </div>
                    </div>
                    <div class="nav-item-divider"></div>
                    <a
                        href="#" class="dashboard-nav-item"><i class="fa fa-sign-out"></i>Logout </a>
                </nav>
        </div>
        <div class='dashboard-app'>
            <header class='dashboard-toolbar'><a href="#!" class="menu-toggle"><i class="fa fa-bars"></i></a></header>
            <div class='dashboard-content'>
                <div class='container'>
                    <div class='card'>
                        <div class='card-header'>
                            <h1>
                                Lista de Tareas de Ciudadanos de Eastview</h1>
                        </div>
                        <div class='card-body'>
                            <asp:LinkButton CssClass="btn btn-primary" ID="btnNuevaTarea" OnClick="btnNuevaTarea_Click" runat="server"><i class="fa fa-plus" aria-hidden="true"></i> Nueva Tarea</asp:LinkButton>
                            <table class="table" role="table">
                                <asp:Repeater ID="rpTareaCiudadano" runat="server">
                                    <HeaderTemplate>
                                        <thead role="rowgroup">
                                            <tr role="row">
                                                <th role="columnheader">
                                                    Nombre Ciudadano
                                                </th>
                                                <th role="columnheader">
                                                    Tarea a relizar
                                                </th>
                                                <th role="columnheader">
                                                    Dia
                                                </th>
                                                <th role="columnheader">
                                                    Acciones
                                                </th>
                                            </tr>
                                        </thead>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <tbody role="rowgroup">
                                            <tr role="row" id="<%# DataBinder.Eval(Container.DataItem, "Id_Tarea_Ciudadano")%>">
                                                <td role="cell">
                                                    <%# DataBinder.Eval(Container.DataItem, "Nombre_Ciudadano")%>
                                                </td>
                                                <td role="cell">
                                                    <%# DataBinder.Eval(Container.DataItem, "Nombre_Tarea")%>
                                                </td>
                                                <td role="cell">
                                                    <%# DataBinder.Eval(Container.DataItem, "DiaTarea")%>
                                                </td>
                                                <td role="cell">
                                                    <asp:LinkButton ID="btnEditarTareaCiudadano" runat="server" ClientIDMode="Static" CssClass="btn btn-primary btn-sm" OnClick="btnEditarTareaCiudadano_Click"
                                                        CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Id_Tarea_Ciudadano") %>'>Editar</asp:LinkButton>
                                                    <asp:LinkButton runat="server" ID="btnEliminarTarea" ClientIDMode="Static" CssClass="btn btn-danger btn-sm" OnClick="btnEliminarTarea_Click"
                                                        CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Id_Tarea_Ciudadano") %>'>Excluir
                                                    </asp:LinkButton>
                                                </td>
                                        </tbody>
                                    </ItemTemplate>
                                    <FooterTemplate>
                                    </FooterTemplate>
                                </asp:Repeater>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
