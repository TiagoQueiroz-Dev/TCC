
function calcularValorTotal(p,q,r,s) {
    calcularValorParcial(p,q,r);
    somarTotal(r,s);
    
    // console.log(document.getElementById(r).innerText)
}

function calcularValorParcial(p, q, r) {

    var unidadeSemVirgula = (document.getElementById(p).innerText).toString();
    var valorUnidade = unidadeSemVirgula.replace(',', '.');
    valorUnidade = parseFloat(valorUnidade) || 0;

    //console.log(valorUnidade);

    var inputQtd = parseFloat(document.getElementById(q).value) || 0;

    //console.log(inputQtd);

    var valorParcial = parseFloat(document.getElementById(r).value) || 0;
    //console.log(valorParcial);

    valorParcial += valorUnidade * inputQtd;

    //valor passado em formato de string porém com . ao inves de , para facilitar o calculo total posteriormente
    document.getElementById(r).innerText = valorParcial.toString();
};

function somarTotal(r,s) {
    var valorParcial = document.getElementById(r).innerText|| 0;
    valorParcial = parseFloat(valorParcial);

    console.log(valorParcial)

    var valorTotal = (document.getElementById(s).innerText).replace(',','.');
    valorTotal = parseFloat(valorTotal);
    console.log(valorTotal);
   
    //var valorTotal = parseFloat(totalComVirgula);
    //console.log(typeof valorTotal)
    
    
    
    valorTotal += valorParcial;    
   


    document.getElementById(s).innerText = valorTotal.toString().replace('.',',');


}