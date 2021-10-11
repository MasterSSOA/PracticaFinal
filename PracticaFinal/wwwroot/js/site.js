// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var MoneyFormat = new Intl.NumberFormat('en-US', {
    style: 'currency',
    currency: 'USD',
});

//A la hora de seleccionar el dropdown list reflejarse en el texto de lbAmount.
//Automatico.
$(document).ready(function () {
    $('#dropdown1').on('change', function () {
        document.getElementById("lbAmount").innerHTML = "RD" + MoneyFormat.format(this.value);
    })
});

//Manual.
function getComboFromData(selectObject) {
    var value = selectObject.value;
    document.getElementById("lbAmount").innerHTML = "RD" + MoneyFormat.format(value);
}

//Función para evitar transferir al misma cuenta.
$(document).ready(function () {
    $('#dropdown1').on('change', function () {
        if (document.getElementById("dropdown1").value == document.getElementById("dropdown2").value
            || document.getElementById("tbMonto").value == "") {
            document.getElementById("btnsubmit").disabled = true;
        }
        else {
            document.getElementById("btnsubmit").disabled = false;
        }
    })

    $('#dropdown2').on('change', function () {
        if (document.getElementById("dropdown1").value == document.getElementById("dropdown2").value
            || document.getElementById("tbMonto").value == "") {
            document.getElementById("btnsubmit").disabled = true;
        }
        else {
            document.getElementById("btnsubmit").disabled = false;
        }
    })

    $('#tbMonto').on('change', function () {
        if (document.getElementById("dropdown1").value == document.getElementById("dropdown2").value
            || document.getElementById("tbMonto").value == "") {
            document.getElementById("btnsubmit").disabled = true;
        }
        else {
            document.getElementById("btnsubmit").disabled = false;
        }
    })
});

//deshabilitar boton de transferir.
$(document).ready(function () {
    $('#btnsubmit').attr('disabled',true);
})

//creando una variable de para el botón Cancel.
$(document).ready(function () {
    $('#btncancel').on('click', function () {
        document.getElementById("goBack").value = "y";
    })
})
