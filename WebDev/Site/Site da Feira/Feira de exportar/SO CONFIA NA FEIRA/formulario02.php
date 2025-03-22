<?php
  //apos carregar o seu idenx ele cguarda aquele valor aqui
  
$usuario = filter_input(INPUT_POST, "usu");
$senha = filter_input(INPUT_POST, "sen");

 if ($usuario=="vdamiao" && $senha==3)
 {
     echo 'SEJA BEM VINDO';;
 }
 else if ("$usuario!=vdamiao")
 {
     echo "Usuario invalido";
 }
 else if ("$senha!=3")
 {
     echo "senha inválida";
 }
 else {
echo" usario ou senha invalidos";     
}
?>