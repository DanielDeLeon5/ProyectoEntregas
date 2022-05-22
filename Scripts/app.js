function calculosPeso(peso) {
    let tarifa = 0;
    if (peso <= 10) {
        tarifa = 25;
        $(':input[type="submit"]').prop('disabled', false);
    } else if (peso > 10 && peso <= 20) {
        tarifa = 40;
        $(':input[type="submit"]').prop('disabled', false);
    } else if (peso > 20 && peso <= 30) {
        tarifa = 60;
        $(':input[type="submit"]').prop('disabled', false);
    } else if (peso > 30 && peso <= 40) {
        tarifa = 75;
        $(':input[type="submit"]').prop('disabled', false);
    } else {
        $(':input[type="submit"]').prop('disabled', true);
    }
    $("#PrecioPaquete").val(tarifa);
}

$(document).ready(function () {
    alert($('input:hidden[id=UsuarioId]').val(1));
    alert($('input:hidden[id=RepartidorId]').val(1));
    $("#Peso").keyup(function () {
        calculosPeso($("#Peso").val());
    });

});