    var btnSumar = document.getElementById("btnSumar");

    btnSumar.onclick = function () {
        // Asi tambien se puede hacer
        var Numero1 = document.getElementById("txtNumero1").value * 1;
        var Numero2 = document.getElementById("txtNumero2").value * 1;
        var Suma = Numero1 + Numero2;
        alert(Suma);

        //alert((document.getElementById("txtNumero1").value * 1) + (document.getElementById("txtNumero2").value * 1));

        //Para mostrar el resultado en elemento
        //var Numero1 = document.getElementById("txtNumero1").value * 1;
        //var Numero2 = document.getElementById("txtNumero2").value * 1;
        //var Suma = Numero1 + Numero2;
        //Funciono una vez
        document.getElementById("lblMensajeAlerta").innerHTML = "La suma es: " + ((document.getElementById("txtNumero1").value * 1) + (document.getElementById("txtNumero2").value * 1));
        

        //document.getElementById("lblMensajeAlerta").innerHTML = "La suma es: "+ Suma;
        document.getElementById("lblMensajeAlerta").className += "alert alert-success mt-2";
    }

    var btnLimpiar = document.getElementById("btnLimpiar");
    btnLimpiar.onclick = function () {
        document.getElementById("txtNumero1").value = "";
        document.getElementById("txtNumero2").value = "";
        document.getElementById("lblMensajeAlerta").innerHTML = "";
        document.getElementById("lblMensajeAlerta").classList.remove("");
    }
