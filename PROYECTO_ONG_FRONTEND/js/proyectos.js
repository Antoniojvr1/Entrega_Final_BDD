// js/proyectos.js
const proyectos = [
    { nombre:"Agua Limpia", ong:"Fundación Esperanza", fecha:"2025-02-01" }
];

function cargarProyectos(){
    const tabla=document.getElementById("tabla-proyectos");
    tabla.innerHTML="";
    proyectos.forEach((p,index)=>{
        tabla.innerHTML+=`
            <tr>
                <td>${p.nombre}</td>
                <td>${p.ong}</td>
                <td>${p.fecha}</td>
                <td>
                    <button class="btn" onclick="editarProyecto(${index})">Editar</button>
                    <button class="btn" onclick="eliminarProyecto(${index})">Eliminar</button>
                </td>
            </tr>
        `;
    });
}

function abrirModal(){ document.getElementById("modal-proyecto").style.display="flex"; limpiarModal(); }
function cerrarModal(){ document.getElementById("modal-proyecto").style.display="none"; }
function limpiarModal(){ document.getElementById("proyecto-nombre").value=""; document.getElementById("proyecto-ong").value=""; document.getElementById("proyecto-fecha").value=""; }

function guardarProyecto(){
    const nombre=document.getElementById("proyecto-nombre").value;
    const ong=document.getElementById("proyecto-ong").value;
    const fecha=document.getElementById("proyecto-fecha").value;
    if(!nombre||!ong){ alert("Completa los datos"); return; }
    proyectos.push({nombre,ong,fecha});
    cargarProyectos(); cerrarModal(); alert("Proyecto registrado (simulación API).");
}

function eliminarProyecto(index){ if(confirm("Eliminar este proyecto?")){ proyectos.splice(index,1); cargarProyectos(); } }

function editarProyecto(index){
    abrirModal();
    const p=proyectos[index];
    document.getElementById("proyecto-nombre").value=p.nombre;
    document.getElementById("proyecto-ong").value=p.ong;
    document.getElementById("proyecto-fecha").value=p.fecha;
    const boton=document.querySelector("#modal-proyecto .btn");
    boton.onclick=function(){
        p.nombre=document.getElementById("proyecto-nombre").value;
        p.ong=document.getElementById("proyecto-ong").value;
        p.fecha=document.getElementById("proyecto-fecha").value;
        cargarProyectos(); cerrarModal(); alert("Proyecto editado (API simulada).");
        boton.onclick=guardarProyecto;
    }
}
document.addEventListener("DOMContentLoaded", cargarProyectos);
