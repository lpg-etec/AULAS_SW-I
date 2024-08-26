<?php
    require('conecta.php');
    $email = $_POST['email'];
    $senha = $_POST['senha'];

    $consulta = "SELECT * FROM usuarios WHERE email = '$email' AND senha = '$senha'";

    $resultado = $conexao->query($consulta);
    $registros = $resultado->num_rows;
    $resultado_usuario = mysqli_fetch_assoc($resultado);

    if($registros != 0) {
        header('Location: index.php');
    } else {
        header('Location: ../index.html');
    }
?>