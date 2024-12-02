// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function validarFecha() {
    const hoy = new Date();
    let fechaInput = document.getElementById('fechaNacimiento').value;
    let fecha = new Date(fechaInput);
    if (fecha > hoy) {
        let mensaje = document.getElementById('mensajeError');
        mensaje.innerHTML = "La fecha debe ser anterior a la de hoy.";
        return false;
    }
    return true;
}