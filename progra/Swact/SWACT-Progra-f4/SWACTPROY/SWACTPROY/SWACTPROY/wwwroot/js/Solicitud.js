
class Solicitud {
    constructor(nombreServicio, estado, razonsocial, action) {
        this.nombreServicio = nombreServicio;
        this.razonsocial =razosocial;
        this.estado = estado;
        this.action = action
    }



    filtrarDatos(numPagina) {
        var valor = this.nombreServicio;
        var action = this.action;
        if (valor == "") {
            valor = "null";
        }
        $.ajax({
            type: "POST",
            url: action,
            data: { valor, numPagina },
            success: (response) => {
                console.log(response);
                $.each(response, (index, val) => {

                    $("#resultSearch").html(val[0]);
                    $("#paginado").html(val[1]);
                });

            }
        });
    }
   
    restablecer() {
        document.getElementById("Nombre").value = "";
        document.getElementById("Descripcion").value = "";
        document.getElementById("mensaje").innerHTML = "";
        document.getElementById("Estado").selectedIndex = 0;
        $('#modalAC').modal('hide');
        $('#ModaEstado').modal('hide');
        filtrarDatos(1)
    }

}