// js/actividades.js
const actividades = [
    { nombre:"Campaña de Limpieza", proyecto:"Agua Limpia", fecha:"2025-02-05" }
];

function cargarActividades(){
    const tabla=document.getElementById("tabla-actividades");
    tabla.innerHTML="";
    actividades.forEach((a,index)=>{
        tabla.innerHTML+=`
            <tr>
                <td>${a.nombre}</td>
                <td>${a.proyecto}</td>
                <td>${a.fecha}</td>
                <td>
                    <button class="btn" onclick="editarActividad(${index})">Editar</button>
                    <button class="btn" onclick="eliminarActividad(${index})">Eliminar</button>
                </td>
            </tr>
        `;
    });
}

function abrirModal(){ document.getElementById("modal-actividad").style.display="flex"; limpiarModal(); }
function cerrarModal(){ document.getElementById("modal-actividad").style.display="none"; }
function limpiarModal(){ document.getElementById("actividad-nombre").value=""; document.getElementById("actividad-proyecto").value=""; document.getElementById("actividad-fecha").value=""; }

function guardarActividad(){
    const nombre=document.getElementById("actividad-nombre").value;
    const proyecto=document.getElementById("actividad-proyecto").value;
    const fecha=document.getElementById("actividad-fecha").value;
    if(!nombre||!proyecto){ alert("Completa los datos"); return; }
    actividades.push({nombre,proyecto,fecha});
    cargarActividades(); cerrarModal(); alert("Actividad registrada (API simulada).");
}

function eliminarActividad(index){ if(confirm("Eliminar esta actividad?")){ actividades.splice(index,1); cargarActividades(); } }

function editarActividad(index){
    abrirModal();
    const a=actividades[index];
    document.getElementById("actividad-nombre").value=a.nombre;
    document.getElementById("actividad-proyecto").value=a.proyecto;
    document.getElementById("actividad-fecha").value=a.fecha;
    const boton=document.querySelector("#modal-actividad .btn");
    boton.onclick=function(){
        a.nombre=document.getElementById("actividad-nombre").value;
        a.proyecto=document.getElementById("actividad-proyecto").value;
        a.fecha=document.getElementById("actividad-fecha").value;
        cargarActividades(); cerrarModal(); alert("Actividad editada (API simulada).");
        boton.onclick=guardarActividad;
    }
}
document.addEventListener("DOMContentLoaded", cargarActividades);

