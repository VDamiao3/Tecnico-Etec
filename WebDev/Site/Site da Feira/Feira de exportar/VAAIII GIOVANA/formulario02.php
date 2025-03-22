            <?php
  //apos carregar o seu idenx ele cguarda aquele valor aqui
  $conecta=mysql_connect("host","root","vertrigo");
$usuario = filter_input(INPUT_POST, "usu");
$senha = filter_input(INPUT_POST, "sen");


// INCLUINDO A CONECXAO  COM O BANCO DE DADOS 
include 'conexao.php';
$busca="select * from login"; // vai pegar a busca e precisa armazenala
// armazena o comando SQL na variavel
$result=  mysqli_query($con, $busca);
// itoçozpi o mysqli query para executar o comando SQL acima 
// dentro da conexao com o banco de dados que foi criada , $ con

// agora que armazenou tem que verificar busca de linha em linha
        
        $linha=  mysqli_num_rows($result);
// mysql num rows  conta quantas linhas de resultado 
        // foram retornadas , ou sea, exemplo, se tinha tres informações 
        // no banco de dados  que foram retornadas  string $linha recebe 3
        
        for($i=0; $i<$linha; $linha ++)
        /*criamos uma estrutura de repetição que termina o incio
 da varredura do meu baanco de dados ate o limite de retorno 
         * das informaçõe          */
// no banco de dados começa sempre do 0 pq  a primeira rodada ele ja le a linha 1
        
        {
            $coluna=  mysqli_fetch_array($result); // aqui ele dividi por colunas 
            /*array é um vetor */
             $usuario= $coluna['Usuario'] ;
             $usuario=$coluna ['Senha'];
             $usuario=$coluna['Lcod'];
          // agora ele vai guardar na variavel e buscar o resultado nas colunas
            
 
    
 
 if ("$pessoa==$usuario&& $codigo==$senha && $tipo==1")
 {
     echo "Aluno";
     break;
 }
 else if ("$pessoa==$usuario && $codigo==$senha && $tipo==2")
 {
     echo "administrativo";
     break;;
 }
 else {
  echo "usuario ou senhas invalidas";
  break;
}
        }
       
        
        ?>