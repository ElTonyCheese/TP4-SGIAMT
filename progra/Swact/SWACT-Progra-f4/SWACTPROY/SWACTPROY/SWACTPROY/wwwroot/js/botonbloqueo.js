

function bloquearboton(boton, porcentaje) {
      
    if (procentaje === 100) {
        alert("entre");
        return false;
    }
    return true;
}
$('#boton').attr("disabled", true);
