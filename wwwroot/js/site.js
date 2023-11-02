document.addEventListener("DOMContentLoaded", function atualizarQuantidade(p,q) {
    var inputQtd = document.getElementById(p);
    var qtdProduto =document.getElementById(q);
    qtdProduto.textContent = inputQtd.value;    
    console.log("Quantidade atualizada: "+ qtdProduto);
});