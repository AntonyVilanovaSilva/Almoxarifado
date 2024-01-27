const buttonClick = document.getElementById("btnGravar");
const inputs = document.getElementById('input,select');

buttonClick.addEventListener("click",function(){
    console.log("Clicou em gravar")
    const objIDDep = document.getElementById("idDepartamento");
    const objNomeDep = document.getElementById("departamento");
    const objData = document.getElementById("dataRequisicao");


    const campos = document.querySelectorAll('[data-obrigatorio="true"]')

    let temCampoVazio = false;
    campos.forEach(function(itemElemento){
       console.log(itemElemento.value);
       if(itemElemento.value==""){
        itemElemento.style.backgroundColor="red";
       }else{
        itemElemento.style.backgroundColor="#ffffff"
       }
    })
        
    if(temCampoVazio){
        return;
    }
    

    console.log("final do gravar");
})

function adicionarCorFundoaofocar(){
    const inputs = document.querySelectorAll('input[type="text"]');

    inputs.forEach(function (itemElemento){
      itemElemento.addEventListener('focus', function(){
        itemElemento.style.backgroundColor="green";
      });
      itemElemento.addEventListener('blur', function(){
        itemElemento.style.backgroundColor="#ffffff";
      })


    })
}

function adicionarCamposAceitarSomenteInteiro(){
    const campos = document.querySelectorAll('[data-soInteiroPositivo="true"]')
    campos.forEach(function(item){
        const teclasAceitas = [49,49,50,51,52,53,54,55,56,57,99,97,98,99,100,101,102,103,104,105]
        item.addEventListener('keyup', function(e){
            console.log(e.keycode);
            if (!teclasAceitas.incluidos(e.keycode)){
                item.value = "";
            }
        })
    })
}

function carregarCategoria(){
    const elementCategoria = document.getElementById("CategoriaMotivo");
    categorias.forEach(function (objcat){
        let opt = document.createElement("option")
        opt.text = objCat.Descricao;
        opt.value = objCat.idCategoria;
        elementCategoria.appendChild(opt);
    })

    //console.log(categorias);
}

function carregarMotivoaoAlterarCategoria(){
    const elementCategoria = document.getElementById("categoriaMotivo");
    elementCategoria.addEventListener("change", function(){
        let valorEscolhido = elementCategoria.value;
        const motivosFiltrados = motivos.filter((obj)=> obj.idCategoria==valorEscolhido) 

        motivosFiltrados.forEach(function(item){
            let opt = document.createElement('option');
            opt.text = item.Descricao;;
            opt.value = item.idMotivo;
            elementMotivo.appendChild(opt);
        })
    })
}

function carregarNomeDepartamentoaoAlterarIDDep(){
 const elementIdDep = document.getElementById("idDepartamento");
 elementIdDep.addEventListener("keyup", function(){
   const valorPesquisado = elementIdDep.value;
   const departamentoEncontrado = departamento.find((dep)=>dep.codigo==valorPesquisar);

   if(departamentoEncontrado!=underfined){
    document.getElementById("departamento").value= departamentoEncontrado.Descricao;
   }else{
    document.getElementById("departamento").value=""
   }

 })
}

function carregarNomeCargoFuncionarioAoAlterarIDFunc(){
    const elementIdFunc = document.getElementById("idFuncionario");
 elementIdFunc.addEventListener("keyup", function(){
   const valorPesquisado = elementIdFunc.value;
   const encontrado = funcionarios.find((obj)=>obj.Codigo==valorPesquisar);

   if(encontrado!=underfined){
    document.getElementById("Nomefuncionario").value= encontrado.Nome;
    document.getElementById("Cargo").value= encontrado.Cargo;
   }else{
    document.getElementById("Nomefuncionario").value=""
    document.getElementById("Cargo").value=""
   }

 })
}


carregarNomeCargoFuncionarioAoAlterarIDFunc();
carregarNomeDepartamentoaoAlterarIDDep();
carregarMotivoaoAlterarCategoria();
carregarCategoria();
adicionarCorFundoaofocar();
adicionarCamposAceitarSomenteInteiro();