var url = "https://viacep.com.br/ws/63530000/json/"

function searchCep() {
    let dataCep
    let cep = document.getElementById("cep").value
    $.getJSON(`https://viacep.com.br/ws/${cep}/json/`, function(data) {         
        dataCep = `<ul class="list-group">
                        <li class="list-group-item">CEP: ${data.cep}</li>
                        <li class="list-group-item">DDD: ${data.ddd}</li>
                        <li class="list-group-item">Bairro: ${data.bairro}</li>
                        <li class="list-group-item">Localidade: ${data.localidade}</li>
                        <li class="list-group-item">Logradouro: ${data.logradouro}</li>
                        <li class="list-group-item">Complemento: ${data.complemento}</li>
                        <li class="list-group-item">UF: ${data.uf}</li>
                    </ul>`
        document.getElementById("result-cep").innerHTML = dataCep
    });
}
