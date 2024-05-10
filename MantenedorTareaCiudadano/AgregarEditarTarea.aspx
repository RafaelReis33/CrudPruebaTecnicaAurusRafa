<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarEditarTarea.aspx.cs"
    Inherits="SistemaEastview.MantenedorTareaCiudadano.AgregarEditarTarea" %>

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
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
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
                                Mantenedor de Tareas de Ciudadanos</h1>
                        </div>
                        <div class='card-body'>
                            <div class="row" style="margin-top: 2%;">
                                <div class="col-sm-12">
                                    <div class="panel panel-warning">
                                        <div class="panel-heading">
                                            <h3 style="margin-left: 20%; margin-right: 20%;">
                                                Agregar Tarea</h3>
                                        </div>
                                        <div class="panel-body" style="margin-left: 20%; margin-right: 20%;">
                                            <hr />
                                            <div class="table-responsive">
                                                <div class="form-group">
                                                    <label>
                                                        Ciudadano</label>
                                                    <asp:DropDownList class="form-control" ID="dpCuidadano" runat="server" Width="80%" />
                                                    <asp:Label ID="ErrorCiudadano" runat="server" class="text-danger" Visible="false"/>
                                                </div>
                                                <div class="form-group">
                                                    <label class="mt-4">
                                                        Nombre de la Tarea</label>
                                                    <asp:TextBox runat="server" class="form-control" ID="txtNombreTarea" required="required"
                                                        MaxLength="50" Width="80%" />
                                                         <asp:Label ID="ErrorNombreTarea" runat="server" class="text-danger" Visible="false"/>
                                                </div>
                                                <div class="form-group">
                                                    <label class="mt-4">
                                                        Dia de la Tarea</label>
                                                    <asp:DropDownList class="form-control" ID="dpDiaTarea" runat="server" Width="80%" />
                                                     <asp:Label ID="ErrorDiaTarea" runat="server" class="text-danger" Visible="false"/>
                                                </div>
                                                <div class="mt-3">
                                                    <asp:LinkButton runat="server" ID="btnGuardarTareaCiudadano" type="submit" class="btn btn-primary"
                                                        OnClick="btnGuardarTareaCiudadano_Click">Guardar Tarea</asp:LinkButton>
                                                    <asp:LinkButton runat="server" ID="btnVolver" class="btn btn-danger" OnClick="btnVolver_Click">Volver</asp:LinkButton>
                                                </div>
                                                <asp:Label ID="ErrorDataIngresada" runat="server" class="text-danger" Visible="false"/>
                                                <asp:HiddenField ID="hdCodigoTareaCiudadano" runat="server" />
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    
    <script src="../js/bootstrap.bundle.min.js" type="text/javascript"></script>
    </form>
</body>
</html>
