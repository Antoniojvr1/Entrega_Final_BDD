const personas = [
    { nombre:"Carlos López", identidad:"0801199901234", telefono:"9999-0000", correo:"carlos@example.com" },
    { nombre:"María Gómez", identidad:"0801198709876", telefono:"8888-1212", correo:"maria@example.com" }
];

function cargarPersonas() {
    const tabla = document.getElementById("tabla-personas");
    tabla.innerHTML = "";
    personas.forEach((p,index) => {
        tabla.innerHTML += `
            <tr>
                <td>${p.nombre}</td>
                <td>${p.identidad}</td>
                <td>${p.telefono}</td>
                <td>${p.correo}</td>
                <td>
                    <button class="btn" onclick="editarPersona(${index})">Editar</button>
                    <button class="btn" onclick="eliminarPersona(${index})">Eliminar</button>
                </td>
            </tr>
        `;
    });
}

function abrirModal() {
    document.getElementById("modal-persona").style.display="flex";
    limpiarModal();
}

function cerrarModal() {
    document.getElementById("modal-persona").style.display="none";
}

function limpiarModal(){
    document.getElementById("nombre").value="";
    document.getElementById("identidad").value="";
    document.getElementById("telefono").value="";
    document.getElementById("correo").value="";
}

function guardarPersona(){
    const nombre=document.getElementById("nombre").value;
    const identidad=document.getElementById("identidad").value;
    const telefono=document.getElementById("telefono").value;
    const correo=document.getElementById("correo").value;

    if(!nombre || !identidad){ alert("Completa los datos"); return; }
    personas.push({nombre,identidad,telefono,correo});
    cargarPersonas();
    cerrarModal();
    alert("Persona registrada (simulación API).");
}

function eliminarPersona(index){
    if(confirm("¿Eliminar esta persona?")){
        personas.splice(index,1);
        cargarPersonas();
    }
}

function editarPersona(index){
    abrirModal();
    const p = personas[index];
    document.getElementById("nombre").value=p.nombre;
    document.getElementById("identidad").value=p.identidad;
    document.getElementById("telefono").value=p.telefono;
    document.getElementById("correo").value=p.correo;
    // Sobrescribimos guardarPersona temporalmente
    const boton = document.querySelector("#modal-persona .btn");
    boton.onclick = function(){
        p.nombre=document.getElementById("nombre").value;
        p.identidad=document.getElementById("identidad").value;
        p.telefono=document.getElementById("telefono").value;
        p.correo=document.getElementById("correo").value;
        cargarPersonas();
        cerrarModal();
        alert("Persona editada (simulación API).");
        boton.onclick = guardarPersona; // restauramos
    }
}

document.addEventListener("DOMContentLoaded", cargarPersonas);
