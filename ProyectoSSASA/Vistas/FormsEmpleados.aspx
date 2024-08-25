<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormsEmpleados.aspx.cs" Inherits="ProyectoSSASA.Vistas.FormsEmpleados" %>

<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Registro de Empleados</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <div class="container">
        <h1>Registro de Empleados</h1>
        <form id="employeeForm">
            <div class="form-group">
                <label for="nombre">Nombre:</label>
                <input type="text" id="nombre" name="nombre" required>
            </div>
            <div class="form-group">
                <label for="dpi">DPI:</label>
                <input type="text" id="dpi" name="dpi" required>
            </div>
            <div class="form-group">
                <label for="fechaNacimiento">Fecha de Nacimiento:</label>
                <input type="date" id="fechaNacimiento" name="fechaNacimiento" required>
            </div>
            <div class="form-group">
                <label for="edad">Edad:</label>
                <input type="text" id="edad" name="edad" readonly>
            </div>
            <div class="form-group">
                <label for="sexo">Sexo:</label>
                <select id="sexo" name="sexo" required>
                    <option value="M">Masculino</option>
                    <option value="F">Femenino</option>
                </select>
            </div>
            <div class="form-group">
                <label for="fechaIngreso">Fecha de Ingreso:</label>
                <input type="date" id="fechaIngreso" name="fechaIngreso" required>
            </div>
            <div class="form-group">
                <label for="direccion">Dirección:</label>
                <input type="text" id="direccion" name="direccion">
            </div>
            <div class="form-group">
                <label for="nit">NIT:</label>
                <input type="text" id="nit" name="nit">
            </div>
            <div class="form-group">
                <label for="departamento">Departamento:</label>
                <select id="departamento" name="departamento" required>
                    <option value="1">Créditos y Cobros</option>
                    <option value="2">Publicidad e Imagen Corporativa</option>
                    <option value="3">Gerencia General</option>
                    <!-- Agrega más opciones según los departamentos existentes -->
                </select>
            </div>
            <button type="submit">Registrar</button>
        </form>
    </div>

    <script src="scripts.js"></script>
</body>
</html>
