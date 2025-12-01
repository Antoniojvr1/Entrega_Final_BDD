body {
    margin: 0;
    font-family: Arial, sans-serif;
    background: #f4f4f4;
}

.navbar {
    height: 60px;
    background: #0077cc;
    color: white;
    display: flex;
    justify-content: space-between;
    align-items: center;
    padding: 0 20px;
}

.navbar .logo {
    font-size: 20px;
    font-weight: bold;
}

.navbar a {
    color: white;
    margin-left: 15px;
    text-decoration: none;
    font-weight: bold;
}

.sidebar {
    width: 220px;
    background: #1a1a1a;
    height: 100vh;
    color: white;
    padding-top: 20px;
    position: fixed;
    top: 60px;
    left: 0;
}

.sidebar ul {
    list-style: none;
    padding: 0;
}

.sidebar li {
    padding: 12px 20px;
}

.sidebar a {
    text-decoration: none;
    color: white;
    display: block;
}

.sidebar a:hover {
    background: #333;
}

.content {
    margin-left: 240px;
    padding: 20px;
    margin-top: 70px;
}

.footer {
    text-align: center;
    padding: 20px;
    color: #555;
    margin-top: 30px;
}
