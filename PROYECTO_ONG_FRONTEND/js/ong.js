// js/ong.js
const ong = [
    { nombre:"Fundación Esperanza", director:"Juan Pérez", telefono:"2233-4455" }
];

function cargarOng(){
    const tabla=document.getElementById("tabla-ong");
    tabla.innerHTML="";
    ong.forEach((o,index)=>{
        tabla.innerHTML+=`
            <tr>
                <td>${o.nombre}</td>
                <td>${o.director}</td>
                <td>${o.telefono}</td>
                <td>
                    <button class="btn" onclick="editarONG(${index})">Editar</button>
                    <button class="btn" onclick="eliminarONG(${index})">Eliminar</button>
                </td>
            </tr>
        `;
    });
}

function abrirModal(){ document.getElementById("modal-ong").style.display="flex"; limpiarModal(); }
function cerrarModal(){ document.getElementById("modal-ong").style.display="none"; }
function limpiarModal(){ document.getElementById("ong-nombre").value=""; document.getElementById("ong-director").value=""; document.getElementById("ong-telefono").value=""; }

function guardarONG(){
    const nombre=document.getElementById("ong-nombre").value;
    const director=document.getElementById("ong-director").value;
    const telefono=document.getElementById("ong-telefono").value;
    if(!nombre||!director){ alert("Completa los datos"); return; }
    ong.push({nombre,director,telefono});
    cargarOng(); cerrarModal(); alert("ONG registrada (simulación API).");
}

function eliminarONG(index){ if(confirm("Eliminar esta ONG?")){ ong.splice(index,1); cargarOng(); } }

function editarONG(index){
    abrirModal();
    const o=ong[index];
    document.getElementById("ong-nombre").value=o.nombre;
    document.getElementById("ong-director").value=o.director;
    document.getElementById("ong-telefono").value=o.telefono;
    const boton=document.querySelector("#modal-ong .btn");
    boton.onclick=function(){
        o.nombre=document.getElementById("ong-nombre").value;
        o.director=document.getElementById("ong-director").value;
        o.telefono=document.getElementById("ong-telefono").value;
        cargarOng(); cerrarModal(); alert("ONG editada (API simulada).");
        boton.onclick=guardarONG;
    }
}
document.addEventListener("DOMContentLoaded", cargarOng);
