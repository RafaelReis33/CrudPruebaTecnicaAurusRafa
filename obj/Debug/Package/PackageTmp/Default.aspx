<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="SistemaEastview.Index" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="css/index.css" rel="stylesheet" />
    <script src="js/jquery-1.11.0.min.js" type="text/javascript"></script>
    <script src="js/index.js" type="text/javascript"></script>
    <link rel="stylesheet" type="text/css" href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class='dashboard'>
        <div class="dashboard-nav">
            <header>
                    <a href="Index.aspx" class="menu-toggle"><i class="fa fa-bars"></i></a><a href="Index.aspx"
                        class="brand-logo"><i class="fa fa-anchor"></i><span>Eastview</span></a>
                </header>
            <nav class="dashboard-nav-list">
                    <a href="Index.aspx" class="dashboard-nav-item"><i class="fa fa-home"></i>
                        Inicio </a>
                    <div class='dashboard-nav-dropdown'>
                        <a href="#!" class="dashboard-nav-item dashboard-nav-dropdown-toggle"><i
                            class="fa fa-photo-video"></i>Mantenedor</a>
                        <div class='dashboard-nav-dropdown-menu'>
                            <a href="MatenedorCiudadano/ListaCiudadano.aspx" class="dashboard-nav-dropdown-item">Ciudadanos</a>
                            <a href="MantenedorTareaCiudadano/ListarTareaCiudadano.aspx" class="dashboard-nav-dropdown-item">Tareas de Ciudadanos</a>
                            <a href="VistaTarea/VerTareas.aspx" class="dashboard-nav-dropdown-item">Ver Tareas</a>
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
                                Bienvenido a la ciudad de Eastview</h1>
                        </div>
                        <div class='card-body'>
                            <p>
                                Tipo de cuenta : Administrador</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
