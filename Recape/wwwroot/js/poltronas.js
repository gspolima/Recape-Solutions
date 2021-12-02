export default function Poltronas() {

    let $poltronas = $('.btn[data-poltrona-id]');

    //console.log($poltronas);

    $poltronas.click(function (event) {
        let $clicado = $(event.target);
        let disponivel = $clicado.hasClass('btn-outline-success');


        if (disponivel) {
            $clicado.removeClass('btn-outline-success').addClass('btn-success');
        }
        else {
            $clicado.removeClass('btn-success').addClass('btn-outline-success');
        }
    });
}