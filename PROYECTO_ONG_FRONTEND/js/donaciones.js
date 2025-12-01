// js/donaciones.js
const donaciones = [
    { donante:"Luis Ramírez", monto:500, detalle:"Campaña Agua Limpia" }
];

function cargarDonaciones(){
    const tabla=document.getElementById("tabla-donaciones");
    tabla.innerHTML="";
    donaciones.forEach((d,index)=>{
        tabla.innerHTML+=`
            <tr>
                <td>${d.donante}</td>
                <td>${d.monto}</td>
                <td>${d.detalle}</td>
                <td>
                    <button class="btn" onclick="editarDonacion(${index})">Editar</button>
                    <button class="btn" onclick="eliminarDonacion(${index})">Eliminar</button>
                </td>
            </tr>
        `;
    });
}

function abrirModal(){ document.getElementById("modal-donacion").style.display="flex"; limpiarModal(); }
function cerrarModal(){ document.getElementById("modal-donacion").style.display="none"; }
function limpiarModal(){ document.getElementById("donante-nombre").value=""; document.getElementById("donacion-monto").value=""; document.getElementById("donacion-detalle").value=""; }

function guardarDonacion(){
    const donante=document.getElementById("donante-nombre").value;
    const monto=document.getElementById("donacion-monto").value;
    const detalle=document.getElementById("donacion-detalle").value;
    if(!donante||!monto){ alert("Completa los datos"); return; }
    donaciones.push({donante,monto,detalle});
    cargarDonaciones(); cerrarModal(); alert("Donación registrada (API simulada).");
}

function eliminarDonacion(index){ if(confirm("Eliminar esta donación?")){ donaciones.splice(index,1); cargarDonaciones(); } }

function editarDonacion(index){
    abrirModal();
    const d=donaciones[index];
    document.getElementById("donante-nombre").value=d.donante;
    document.getElementById("donacion-monto").value=d.monto;
    document.getElementById("donacion-detalle").value=d.detalle;
    const boton=document.querySelector("#modal-donacion .btn");
    boton.onclick=function(){
        d.donante=document.getElementById("donante-nombre").value;
        d.monto=document.getElementById("donacion-monto").value;
        d.detalle=document.getElementById("donacion-detalle").value;
        cargarDonaciones(); cerrarModal(); alert("Donación editada (API simulada).");
        boton.onclick=guardarDonacion;
    }
}
document.addEventListener("DOMContentLoaded", cargarDonaciones);
