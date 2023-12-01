
function calcularValorTotal(p, q, r, s, size) {
    calcularValorParcial(p, q, r);
    atribuirTotal(s, size);

}

function calcularValorParcial(p, q, r) {

    var unidadeSemVirgula = (document.getElementById(p).innerText).toString();
    var valorUnidade = unidadeSemVirgula.replace(',', '.');
    valorUnidade = parseFloat(valorUnidade) || 0;


    var inputQtd = parseFloat(document.getElementById(q).value) || 0;


    var valorParcial = parseFloat(document.getElementById(r).innerText) || 0;

    valorParcial = (valorUnidade * inputQtd).toFixed(2);

    document.getElementById(r).innerText = valorParcial.toString();
};


function atribuirTotal(s, size) {

    var valorTotal = parseFloat(valorTotal);
    valorTotal = 0;

    for (var i = 1; i <= size; i++) {
        i = i.toString();
        var valorParcial = document.getElementById(i + "-lista").innerText || 0;
        valorParcial = parseFloat(valorParcial);
        valorTotal += valorParcial;
    }
    valorTotal = valorTotal.toFixed(2)

    document.getElementById(s).innerText = valorTotal.toString().replace('.', ',');
}

// document.addEventListener("DOMContentLoaded", function (){

//         var data = new Date();

//         var ano = data.getFullYear();
//         var mes = (data.getMonth() + 1).toString().padStart(2, '0');
//         var dia = data.getDate().toString().padStart(2, '0');

//         var dataHoje = `${ano}-${mes}-${dia}`;
        
//         document.getElementById("Data_aluguel").value = dataHoje;
        
// });

