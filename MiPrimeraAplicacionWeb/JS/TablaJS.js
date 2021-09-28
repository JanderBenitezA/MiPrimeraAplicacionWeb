$.get("/RepasoHTML/ListarPersonas", function (data) {
    //alert(JSON.stringify(data)); Muestra una alerta con el JSON que devuelve la accion ListarPersonas
    var contenido = "";
    var nFilas = data.length; //Obtiene el numero de registros que devolvio el JSON
    alert(nFilas);
    contenido += "<table id='tabla-personas' class='table'>"; //Se crea la tabla dinamicamente 
    contenido += "<thead class='thead-dark'>"; //Se da estilo al encabezado de la tabla
    contenido += "<tr>";
    contenido += "<th scope='col'>Id Persona </th>"; //Se establece el encabezado
    contenido += "<th scope='col'>Nombre Persona </th>";
    contenido += "<th scope='col'>Apellido Persona </th>";
    contenido += "</tr>";
    contenido += "</thead>"
    
    contenido += "<tbody>" //Se inicia el cuerpo de la tabla.
    //En el ciclo for se ejecuta segun los registros de JSON
    for (var i = 0; i < nFilas; i++) {
        contenido += "<tr>"; //Se inicializa el row 
        contenido += "<th scope='row'>" + data[i].idPersona + "</th>"; //Se asignan las propiedades al row
        contenido += "<td>" + data[i].Nombre + "</td>";
        contenido += "<td>" + data[i].Apellido + "</td>";
        contenido += "<tr>";
    }
    contenido += "</tbody>" // Cierra etiqueta de body de tabla
    contenido += "<table>"; // Se cierra tabla

    document.getElementById("divTabla").innerHTML = contenido; //Se obtiene el id del div, donde con el InnerHTML se inserta la cadena contenido, con los datos dinamicos
});