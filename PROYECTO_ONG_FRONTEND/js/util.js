function loadComponent(id, file) {
    fetch(file)
        .then(res => res.text())
        .then(html => {
            document.getElementById(id).innerHTML = html;
        })
        .catch(err => console.log("Error cargando componente:", err));
}

function logout() {
    window.location.href = "login.html";
}
