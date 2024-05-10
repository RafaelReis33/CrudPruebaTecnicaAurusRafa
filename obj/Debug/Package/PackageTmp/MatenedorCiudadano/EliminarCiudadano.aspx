<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarCiudadano.aspx.cs" Inherits="SistemaEastview.MatenedorCiudadano.EliminarCiudadano" %>

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
    <div class='dashboard'>
        <div class="dashboard-nav">
            <header>
                    <a href="../Default.aspx" class="menu-toggle"><i class="fa fa-bars"></i></a><a href="../Default.aspx"
                        class="brand-logo"><i class="fa fa-anchor"></i><span>Eastview</span></a>
                </header>
            <nav class="dashboard-nav-list">
                    <a href="../Default.aspx class="dashboard-nav-item"><i class="fa fa-home"></i>
                        Inicio </a><%--<a
                            href="#" class="dashboard-nav-item active"><i class="fas fa-tachometer-alt"></i>dashboard
                        </a><a
                            href="#" class="dashboard-nav-item"><i class="fas fa-file-upload"></i>Upload </a>--%>
                    <div class='dashboard-nav-dropdown'>
                        <a href="#!" class="dashboard-nav-item dashboard-nav-dropdown-toggle"><i
                            class="fa fa-photo-video"></i>Mantenedor</a>
                        <div class='dashboard-nav-dropdown-menu'>
                            <a href="ListaCiudadano.aspx" class="dashboard-nav-dropdown-item">Ciudadanos</a>
                            <a href="PageProducto/PageProducto.aspx" class="dashboard-nav-dropdown-item">Tareas de Ciudadanos</a>
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
                                Mantenedor de Ciudadanos</h1>
                        </div>
                        <div class='card-body'>
                            <form id="form1" runat="server">
                                <div class="row" style="margin-top: 2%;">
                                    <div class="col-sm-12">

                                        <div class="panel panel-warning">
                                            <div class="panel-heading">
                                                <h3 style="margin-left: 10%; margin-right: 20%;">Eliminar Ciudadano</h3>
                                            </div>
                                            <div class="panel-body" style="margin-left: 10%; margin-right: 20%;">
                                                <hr />
                                                <div class="table-responsive">
                                                    <div class="form-group">
                                                        <label>
                                                            Desea eliminar este ciudadano(a): <asp:Label runat="server" ID="lblCiudadano"></asp:Label>?</label>
                                                    </div>
                                                    <div class="mt-3">
                                                        <asp:LinkButton runat="server" ID="btnEliminarCiudadano" type="submit" class="btn btn-danger" OnClick="btnEliminarCiudadano_Click">Eliminar Ciudadano</asp:LinkButton>
                                                        <asp:LinkButton runat="server" ID="btnVolver" class="btn btn-primary" OnClick="btnVolver_Click">Volver</asp:LinkButton>
                                                    </div>
                                                </div>
                                            </div>

                                        </div>

                                    </div>

                                </div>

                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
