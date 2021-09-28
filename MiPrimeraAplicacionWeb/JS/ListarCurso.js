$.get("/Curso/listarCurso", function (data) {
    //alert(data);
    crearListado(data);
    
});

function crearListado(data) {
    var contenido = "";
    var nFilas = data.length; //Obtiene el numero de registros que devolvio el JSON
    //alert(nFilas);
    contenido += "<table id='TablaCurso' class='table'>"; //Se crea la tabla dinamicamente 
    contenido += "<thead class='thead-dark'>"; //Se da estilo al encabezado de la tabla
    contenido += "<tr>";
    contenido += "<th scope='col'>ID CURSO </th>"; //Se establece el encabezado
    contenido += "<th scope='col'>NOMBRE </th>";
    contenido += "<th scope='col'>DESCRIPCION </th>";
    contenido += "</tr>";
    contenido += "</thead>"

    contenido += "<tbody>" //Se inicia el cuerpo de la tabla.2
    //En el ciclo for se ejecuta segun los registros de JSON
    for (var i = 0; i < nFilas; i++) {
        contenido += "<tr>"; //Se inicializa el row 
        contenido += "<th scope='row'>" + data[i].IIDCURSO + "</th>"; //Se asignan las propiedades al row
        contenido += "<td>" + data[i].NOMBRE + "</td>";
        contenido += "<td>" + data[i].DESCRIPCION + "</td>";
        contenido += "<tr>";
    }
    contenido += "</tbody>" // Cierra etiqueta de body de tabla
    contenido += "</table>"; // Se cierra tabla

    document.getElementById("Tabla").innerHTML = contenido; //Se obtiene el id del div, donde con el InnerHTML se inserta la cadena contenido, con los datos dinamicos

    $("#TablaCurso").DataTable();

};