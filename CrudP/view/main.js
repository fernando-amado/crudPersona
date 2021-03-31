var url ="http://localhost:64512/api/Persona/Consultar";


document.getElementById("boton").addEventListener("click", consultar)
function consultar(){
    
  fetch(url)
  .then((response)=> response.json())
  .then((data)=> {
    let html='';
    for(let i=0; i<=data.length; i++){
        
        html+="<tr>";
        html+="<td>"+ data[i].NombrePersona+"</td>"
        html+="<td>"+ data[i].ApellidosPersona+"</td>"
        html+="<td>"+data[i].FechaNacimientoPersona+"</td>"
        html+="<td>"+data[i].TipoIdentificacionPersona+"</td>"
        html+="<td>"+data[i].NumeroIdentificacion+"</td>"
        html+="<td>"+data[i].EdadPersona+"</td>"
        html+="<td>"
        html+="<button class='' onclick='ConsultarPorId("+data.IdPersona+");'>Editar</button>"
        html+="<button class='' onclick='Eliminar("+data.IdPersona+");'>Eliminar</button>"
        html+="</td>"
        html+="</tr>";
        document.getElementById("tbody").innerHTML=html;
        
    }
  })
  .catch((error)=>error);
}
function ConsultarPorId(){
    console.log("hola")
}

/*function consultar(){
    $.ajax({
        url: url+'Consultar',
        type: 'GET',
        dataType:'json'
    }).done(function(response){
        var html='';
        $.each(response,function(index,data){
            html+="<tr>";
            html+="<td>"+ data.NombrePersona+"</td>"
            html+="<td>"+ data.ApellidosPersona+"</td>"
            html+="<td>"+data.FechaNacimientoPersona+"</td>"
            html+="<td>"+data.TipoIdentificacionPersona+"</td>"
            html+="<td>"+data.NumeroIdentificacion+"</td>"
            html+="<td>"+data.EdadPersona+"</td>"
            html+="<td>"
            html+="<button class='' onclick='ConsultarPorId("+data.IdPersona+");'><span class='fa fa-edit'></span>Editar</button>"
            html+="<button class='' onclick='Eliminar("+data.IdPersona+");'><span class='fa fa-trash'></span>Eliminar</button>"
            html+="</td>"
            html+="</tr>";
        });
        document.getElementById("datos").innerHTML=html;
        

    }).fail(function(response){
        console.log(response)
    });
}

function ConsultarPorId(){
    $.ajax({
        url:url,
        data:{"IdPersona":IdPersona},
        type:'GET',
        dataType:'json'
    }).done(function(){
       document.getElementById('nombres').Value=response.NombrePersona;
       document.getElementById('apellidos').Value=response.ApellidosPersona;
       document.getElementById('fechaNacimiento').Value=response.FechaNacimientoPersona;
       document.getElementById('tipoIdentificacion').Value=response.TipoIdentificacionPersona;
       document.getElementById('NumeroIdentificacion').Value=response.NumeroIdentificacion;
       document.getElementById('Idpersona').Value=response.IdPersona;

    }).fail(function(response){
        console.log(response)
    });
}

function Guardar(){
    $.ajax({
        url:url,
        data:retornarDatos("GUARDAR"),
        type:'POST',
        dataType:'json'
    }).done(function(){
        if(response=="ok"){
            alert("Datos eliminados correctamente")
        }
        else{
            alert(response)
        }

    }).fail(function(response){
        console.log(response)
    })
}

function Modificar(){
    $.ajax({
        url:url,
        data:retornarDatos("Modificar"),
        type:'PUT',
        dataType:'json'
    }).done(function(){
        if(response=="ok"){
            alert("Datos eliminados correctamente")
        }
        else{
            alert(response)
        }

    }).fail(function(response){
        console.log(response)
    })
}

function Eliminar(){
    $.ajax({
        url:url,
        data:{"IdPersona":IdPersona},
        type:'DELETE',
        dataType:'json'
    }).done(function(){
        if(response=="ok"){
            alert("Datos eliminados correctamente")
        }
        else{
            alert(response)
        }

    }).fail(function(response){
        console.log(response)
    })
}
function retornarDatos( accion){
    IdPersona= document.getElementById("idPersona").value
    return{
    "nombres": document.getElementById('nombres').value,
    "apellidos": document.getElementById('apellidos').value,
    "fechaNacimiento": document.getElementById('fechaNacimiento').value,
    "tipoIdentificacion": document.getElementById('tipoIdentificacion').value,
    "NumeroIdentificacion": document.getElementById('NumeroIdentificacion').value,
    "accion":accion,
    "IdPersona": document.getElementById("idPersona").value
    }
}*/