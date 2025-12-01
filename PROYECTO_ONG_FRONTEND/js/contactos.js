// js/contactos.js
const contactos = [
    { nombre:"Pedro Martínez", cargo:"Coordinador", telefono:"4444-3322" }
];

function cargarContactos(){
    const tabla=document.getElementById("tabla-contactos");
    tabla.innerHTML="";
    contactos.forEach((c,index)=>{
        tabla.innerHTML+=`
            <tr>
                <td>${c.nombre}</td>
                <td>${c.cargo}</td>
                <td>${c.telefono}</td>
                <td>
                    <button class="btn" onclick="editarContacto(${index})">Editar</button>
                    <button class="btn" onclick="eliminarContacto(${index})">Eliminar</button>
                </td>
            </tr>
        `;
    });
}

function abrirModal(){ document.getElementById("modal-contacto").style.display="flex"; limpiarModal(); }
function cerrarModal(){ document.getElementById("modal-contacto").style.display="none"; }
function limpiarModal(){ document.getElementById("contacto-nombre").value=""; document.getElementById("contacto-cargo").value=""; document.getElementById("contacto-telefono").value=""; }

function guardarContacto(){
    const nombre=document.getElementById("contacto-nombre").value;
    const cargo=document.getElementById("contacto-cargo").value;
    const telefono=document.getElementById("contacto-telefono").value;
    if(!nombre||!cargo){ alert("Completa los datos"); return; }
    contactos.push({nombre,cargo,telefono});
    cargarContactos(); cerrarModal(); alert("Contacto registrado (API simulada).");
}

function eliminarContacto(index){ if(confirm("Eliminar este contacto?")){ contactos.splice(index,1); cargarContactos(); } }

function editarContacto(index){
    abrirModal();
    const c=contactos[index];
    document.getElementById("contacto-nombre").value=c.nombre;
    document.getElementById("contacto-cargo").value=c.cargo;
    document.getElementById("contacto-telefono").value=c.telefono;
    const boton=document.querySelector("#modal-contacto .btn");
    boton.onclick=function(){
        c.nombre=document.getElementById("contacto-nombre").value;
        c.cargo=document.getElementById("contacto-cargo").value;
        c.telefono=document.getElementById("contacto-telefono").value;
        cargarContactos(); cerrarModal(); alert("Contacto editado (API simulada).");
        boton.onclick=guardarContacto;
    }
}
document.addEventListener("DOMContentLoaded", cargarContactos);
