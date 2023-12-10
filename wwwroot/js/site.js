
function calcularValorTotal(p, q, r, s, size) {
    calcularValorParcial(p, q, r);
    atribuirTotal(s, size);

}

function calcularValorParcial(p, q, r) {
    var unidadeSemVirgula = (document.getElementById(p).innerText).toString();
    var valorUnidade = unidadeSemVirgula.replace(',', '.');
    valorUnidade = parseFloat(valorUnidade) || 0;
    
    console.log(document.getElementById(r))

    var inputQtd = parseFloat(document.getElementById(q).value) || 0;


    var valorParcial = parseFloat(document.getElementById(r).innerText) || 0;

    valorParcial = (valorUnidade * inputQtd).toFixed(2);

    document.getElementById(r).innerText = valorParcial.toString();
};

function cancelarNota() {
    window.location.href = '@Url.Action("Index", "novoPedido")';
}

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


function SomarTotalDesc(i,j,k,l){
    var inputSubTotal = document.getElementById(i).value || 0;
    var inputDesc = document.getElementById(j).value || 0;
    var inputPagPrevio = document.getElementById(l).value || 0;

    var subTotal = parseFloat(inputSubTotal);
    var desconto = parseFloat(inputDesc);
    var previo = parseFloat(inputPagPrevio);

    var total = subTotal-subTotal*(desconto/100);
    if(total <0){
        total = 0;
    }
    
    if(previo > total){
        previo = total
        document.getElementById(l).value = previo.toFixed(2).replace('.',',');
    }else

    document.getElementById(k).value = total.toFixed(2).replace('.',',');
    

}


