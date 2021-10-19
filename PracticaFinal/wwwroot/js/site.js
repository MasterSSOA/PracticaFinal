// Para dar formato de dinero.
let MoneyFormat = new Intl.NumberFormat('en-US', {

    style: 'currency',
    currency: 'USD',

});

//Ejecución Mostrar el monto disponible de la cuenta seleccionada.
$(document).ready(function () {

    $('#dropdown1').on('change', function () {

        const amount = document.getElementById('lbAmount');
        amount.textContent = 'RD' + MoneyFormat.format(this.value);

    })

});

//Función para evitar transferir al misma cuenta. (Validaciones)
function fieldValidations() {

    const data1 = document.getElementById('dropdown1');
    const data2 = document.getElementById('dropdown2');
    const amount = parseFloat(document.getElementById('tbMonto').value);
    const account1 = parseInt(data1.options[data1.selectedIndex].text);
    const account2 = parseInt(data2.options[data2.selectedIndex].text);
    const amAccount1 = parseFloat(document.getElementById('dropdown1').value);
    const btnAccess = document.getElementById("btnsubmit");

    if (account1 !== account2 && amount < amAccount1 && amount !== 0) {

        btnAccess.disabled = false;

    }
    else {

        btnAccess.disabled = true;

    }

}

//Ejecución para traer el botón en modo deshabilitado como predeterminado.
$(document).ready(function () {

    $('#btnsubmit').attr('disabled', true);

})

//Creando una variable de para el botón Cancel. (lógica interna).
$(document).ready(function () {

    $('#btncancel').on('click', function () {

        const goBack = document.getElementById("goBack");
        goBack.value = "y";

    })

})

//Asignar variable para obtener el AccountNumber de forma automática.
function getAccountNumber(number) {

    const accNumber = document.getElementById("inAccountNumber");
    accNumber.value = number;

}

//Ejecución para filtrar por fecha.
//Campo de fecha 1.
$(document).ready(function () {

    $('#date1').on('change', function () {

        const data1 = document.getElementById('date1');
        const data2 = document.getElementById('date2');
        const dateError = document.getElementById('dateError');
        const dateForm = document.getElementById("dateForm");

        if (data2.value < data1.value) {

            data1.value = data2.value;
            dateError.textContent = 'Fecha invalida';

        }
        else {

            dateForm.submit();

        }
       
    })

})

//Campo de fecha 2.
$(document).ready(function () {

    $('#date2').on('change', function () {

        const data1 = document.getElementById('date1');
        const data2 = document.getElementById('date2');
        const dateError = document.getElementById('dateError');
        const dateForm = document.getElementById("dateForm");

        if (data2.value < data1.value) {

            data2.value = data1.value;
            dateError.textContent = 'Fecha invalida';

        }
        else {

            dateForm.submit();

        }

    })

})
