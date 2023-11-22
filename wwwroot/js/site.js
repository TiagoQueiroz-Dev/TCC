function atualizarQuantidade(p,q)  {
    var inputQtd = document.getElementById(p);
    var qtdProduto = document.getElementById(q);
    
    qtdProduto.textContent = inputQtd.value;
    console.log(qtdProduto.textContent);
};

function calcularValorProdutos(p){

    var unidadeSemVirgula = p.toString();
    var valorUnidade = unidadeSemVirgula.replace(',','.');

    console.log(valorUnidade);
    
    

    // document.getElementById(i).innerText = 'Total = R$ '+ parseFloat(valorTotal);
};