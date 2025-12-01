// js/voluntarios.js
const voluntarios = [
    { nombre:"Ana Torres", telefono:"7777-8888", correo:"ana@example.com" }
];

function cargarVoluntarios(){
    const tabla=document.getElementById("tabla-voluntarios");
    tabla.innerHTML="";
    voluntarios.forEach((v,index)=>{
        tabla.innerHTML+=`
            <tr>
                <td>${v.nombre}</td>
                <td>${v.telefono}</td>
                <td>${v.correo}</td>
                <td>
                    <button class="btn" onclick="editarVoluntario(${index})">Editar</button>
                    <button class="btn" onclick="eliminarVoluntario(${index})">Eliminar</button>
                </td>
            </tr>
        `;
    });
}

function abrirModal(){ document.getElementById("modal-voluntario").style.display="flex"; limpiarModal(); }
function cerrarModal(){ document.getElementById("modal-voluntario").style.display="none"; }
function limpiarModal(){ 
    document.getElementById("voluntario-nombre").value=""; 
    document.getElementById("voluntario-telefono").value=""; 
    document.getElementById("voluntario-correo").value=""; 
}

function guardarVoluntario(){
    const nombre=document.getElementById("voluntario-nombre").value;
    const telefono=document.getElementById("voluntario-telefono").value;
    const correo=document.getElementById("voluntario-correo").value;
    if(!nombre){ alert("Completa los datos"); return; }
    voluntarios.push({nombre,telefono,correo});
    cargarVoluntarios(); cerrarModal(); alert("Voluntario registrado (simulación API).");
}

function eliminarVoluntario(index){ if(confirm("Eliminar este voluntario?")){ voluntarios.splice(index,1); cargarVoluntarios(); } }

function editarVoluntario(index){
    abrirModal();
    const v=voluntarios[index];
    document.getElementById("voluntario-nombre").value=v.nombre;
    document.getElementById("voluntario-telefono").value=v.telefono;
    document.getElementById("voluntario-correo").value=v.correo;
    const boton=document.querySelector("#modal-voluntario .btn");
    boton.onclick=function(){
        v.nombre=document.getElementById("voluntario-nombre").value;
        v.telefono=document.getElementById("voluntario-telefono").value;
        v.correo=document.getElementById("voluntario-correo").value;
        cargarVoluntarios(); cerrarModal(); alert("Voluntario editado (API simulada).");
        boton.onclick=guardarVoluntario;
    }
}
document.addEventListener("DOMContentLoaded", cargarVoluntarios);
