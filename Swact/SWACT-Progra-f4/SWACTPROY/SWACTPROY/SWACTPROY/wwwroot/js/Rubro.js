var localStorage = window.localStorage;
class T_Rubro {
    constructor(nombreRubro, detalleRubro, action) {
        this.nombreRubro = nombreRubro;
        this.detalleRubro = detalleRubro;
         this.action = action
    }

    agregarRubro(idRubro, funcion) {
        if (this.nombre == "") {
            document.getElementById("detalleRubro").focus();
        } else {
            if (this.descripcion == "") {
                document.getElementById("nombreRubro").focus();
            }
            else {

                var nombreRubro = this.nombreRubro;
                var detalleRubro = this.detalleRubro;
                    var action = this.action;
                    var mensaje = '';
                    $.ajax({
                        type: "POST",
                        url: action,
                        data: {
                            idRubro, nombreRubro, detalleRubro, funcion
                        },
                        success: (response) => {
                            $.each(response, (index, val) => {
                                mensaje = val.code;

                            });
                            if (mensaje === "Save") {
                                this.restablecer();
                            } else {
                                document.getElementById("mensaje").innerHTML = "No se puede guardar el rubro";
                            }
                            //console.log(response);
                        }
                    });
                }
            }
        }
    
//    filtrarDatos(numPagina, order) {
//        var valor = this.nombre;
//        var action = this.action;
//        if (valor == "") {
//            valor = "null";
//        }
//        $.ajax({
//            type: "POST",
//            url: action,
//            data: { valor, numPagina, order },
//            success: (response) => {
//                console.log(response);
//                $.each(response, (index, val) => {

//                    $("#resultSearch").html(val[0]);
//                    $("#paginado").html(val[1]);
//                });

//            }
//        });
//    }
//    qetCategoria(id, funcion) {
//        var action = this.action;
//        $.ajax({
//            type: "POST",
//            url: action,
//            data: { id },
//            success: (response) => {
//                console.log(response);
//                if (funcion == 0) {
//                    if (response[0].estado) {
//                        document.getElementById("titleCategoria").innerHTML = "Esta seguro de desactivar la categoría " + response[0].nombre;
//                    } else {
//                        document.getElementById("titleCategoria").innerHTML = "Esta seguro de habilitar la categoría " + response[0].nombre;
//                    }
//                } else {
//                    document.getElementById("Nombre").value = response[0].nombre;
//                    document.getElementById("Descripcion").value = response[0].descripcion;
//                    if (response[0].estado) {
//                        document.getElementById("Estado").selectedIndex = 1;
//                    } else {
//                        document.getElementById("Estado").selectedIndex = 2;
//                    }
//                }

//                localStorage.setItem("categoria", JSON.stringify(response));
//            }
//        });
//    }
//    editarCategoria(id, funcion) {
//        var action = this.action;
//        var response = JSON.parse(localStorage.getItem("categoria"));
//        var nombre = response[0].nombre;
//        var descripcion = response[0].descripcion;
//        var estado = response[0].estado;
//        localStorage.removeItem("categoria");
//        $.ajax({
//            type: "POST",
//            url: action,
//            data: { id, nombre, descripcion, estado, funcion },
//            success: (response) => {
//                console.log(response);
//                this.restablecer();
//            }
//        });

//    }

//    restablecer() {
//        document.getElementById("Nombre").value = "";
//        document.getElementById("Descripcion").value = "";
//        document.getElementById("mensaje").innerHTML = "";
//        document.getElementById("Estado").selectedIndex = 0;
//        $('#modalAC').modal('hide');
//        $('#ModaEstado').modal('hide');
//        filtrarDatos(1, "nombre");
//}
}

