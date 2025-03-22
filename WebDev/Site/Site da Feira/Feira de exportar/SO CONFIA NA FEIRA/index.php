<?php
?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html>
    <head>
        <title>Feira de exportacao</title>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
		<meta name="description" content="Fixed Fade Out Menu: A CSS and jQuery Tutorial" />
        
        <link rel="stylesheet" href="css/style.css" type="text/css" charset="utf-8"/>
        <link rel="stylesheet" href="css/style1.css" type="text/css"  charset="utf-8"/>
        <link rel="stylesheet" href="css/style2.css" type="text/css"  charset="utf-8"/>
        
       
        <link  href="css/style2.css" rel="stylesheet" media="(max-width: 640px)" href="max-640px.css"></link>
           <link href="css/style2.css" rel="stylesheet" media="(min-width: 640px)" href="min-640px.css"></link>
    <link href="css/style2.css" rel="stylesheet" media="(orientation: portrait)" href="portrait.css"></link>
    <link href="css/style2.css"rel="stylesheet" media="(orientation: landscape)" href="landscape.css"></link>

    </head>
    
      
    <body>
        <div id="nav"> <!-- AQUI É A DIV QUE FICA FIXADA -->
            <ul>
                
                
               <li><a>CONTATO</a></li>
                
               <li><a 
                       class="top" href="#top">
                       <img src="images/top.png"></img><span></span>
                   </a></li>
               <li><a 
                       class="bottom" href="#bottom">
                       <img src="images/bottom.png"></img><span></span>
                   </a></li>
                <a class="bottom" >
                    <img src="/images/home.jpg" width="18" height="15"></img>
                </a></li>
                
                <li class="search">
		<input type="text"/><input class="searchbutton" type="submit" value=""/>
		</li>
            
             <li><a class="bottom" 
             <a class="bottom" ><img src="/images/carrinho.png" width="18" height="15"></a></li>
               
                
            </ul>
            </ul>
        </div>        
		<div id="top"></div>
		<div class="desc"></div>
		<div id="bottom"></div>
		<div class="scroll"></div>
        <div class="info">
            <a class="back" 
               href=""></a>
        </div>

                <script type="text/javascript" src="javascript/jquery-1.3.2.js"></script>
                <script type="text/javascript" src="javascript/fixed.js"></script>
        
        
              
              <div align="right" style=
                   "float:right;
                   width:auto;
                   height: auto;
                   background-color:#333333; 
                   margin-top:-75px ">
                       
              <form action="formulario02.php " method="POST" > <!--input comoando para criar uma janela para digitar--, POST(SIGILO)
                                                impede o usuario ver  e o GET(ECOMERCES) -->
                  <p><font color="#FFFFFF">usuario<input type="text" maxlength="30" name="usu" value="ex.usuario@gmail.com"></input></font></p>
                  <p><font color="#FFFFFF">senha<input type="password" maxlength="15" name="sen"></input></font></p>
                   <input type="submit" value="Cadastrar" style="margin-left:-50px"> </input>
                   
                  
                   </div>                                
              <div id="marca" aling="left"
                   style="float:left;
                   width: 1350px ;
                   height:75px;
                   background-color:#333333;
                   margin-top:-90px;  ">
                   
                  <h1 class="marca"><font color="#FFFFFF" size="60"><p>MARCA PRODUTO </p></font></h1>
                  
                      
              </div>           
            
</form>
              
              
              <!--SLIDE SHOW-->
              
              <div id="meio" style="margin-top: 110px; background-color: #333333; " >
               <figure>
		
                   <span class="trs next"></span>
		
                   <span class="trs prev"></span>            <!--HEIGTH ALTURA E WIDTH LARGURA-->

                <div id="slider" style="margin-top:0px; ">
                  <center>
                      <a href="#" class="trs"><img src="images/imagem1.jpg" alt="Legenda da imagem 1" 
                      style="margin-left:auto" width="1000px" height="500"></img>
            </a>
                      <a href="#" class="trs"><img src="images/imagem3.jpg" alt="Legenda da imagem 2" 
                     style="margin-left:0%" width="1000px" height="500"></img>
             </a>
            </center>
		</div>

		<figcaption></figcaption>
	</figure>

                  <script type="text/javascript" src="javascript/slideshow.js"></script>
    </div>
              
              
              
   
  
                 <nav>
      <div class="mbtnavbar" style="margin-top: 0px">
        <ul id='mbtnav'>
            <li class="yellow"><a href="../../../Program Files/VertrigoServ/www/index.html">Titulo</a>
              <ul>  
                <li><a href='../../../Program Files/VertrigoServ/www/SUBLINK_1'>SUBTITULO</a></li>  
                <li><a href='../../../Program Files/VertrigoServ/www/SUBLINK_2'>SUBTITULO</a></li>  
                <li><a href='../../../Program Files/VertrigoServ/www/SUBLINK_3'>SUBTITULO</a></li>  
              </ul>  
          </li>
             
          <li class="yellow"><a href="../../../Program Files/VertrigoServ/www/index.html">Titulo</a>
              <ul>  
                <li><a href='../../../Program Files/VertrigoServ/www/SUBLINK_1'>SUBTITULO</a></li>  
                <li><a href='../../../Program Files/VertrigoServ/www/SUBLINK_2'>SUBTITULO</a></li>  
                <li><a href='../../../Program Files/VertrigoServ/www/SUBLINK_3'>SUBTITULO</a></li>  
              </ul>  
          </li>
          <li class="green"><a href="../../../Program Files/VertrigoServ/www/index.html">Titulo</a>
          <ul>  
                <li><a href='../../../Program Files/VertrigoServ/www/SUBLINK_1'>SUBTITULO</a></li>  
                <li><a href='../../../Program Files/VertrigoServ/www/SUBLINK_2'>SUBTITULO</a></li>  
                <li><a href='../../../Program Files/VertrigoServ/www/SUBLINK_3'>SUBTITULO</a></li>  
              </ul>  
          </li>
          <li class="active"><a href="../../../Program Files/VertrigoServ/www/index.html">Titulo</a>
          <ul>  
                <li><a href='../../../Program Files/VertrigoServ/www/SUBLINK_1'>SUBTITULO</a></li>  
                <li><a href='../../../Program Files/VertrigoServ/www/SUBLINK_2'>SUBTITULO</a></li>  
                <li><a href='../../../Program Files/VertrigoServ/www/SUBLINK_3'>SUBTITULO</a></li>  
              </ul>  
          </li>
          <li class="red"><a href="../../../Program Files/VertrigoServ/www/index.html">Titulo</a>
          <ul>  
                <li><a href='../../../Program Files/VertrigoServ/www/SUBLINK_1'>SUBTITULO</a></li>  
                <li><a href='../../../Program Files/VertrigoServ/www/SUBLINK_2'>SUBTITULO</a></li>  
                <li><a href='../../../Program Files/VertrigoServ/www/SUBLINK_3'>SUBTITULO</a></li>  
              </ul>  
          </li>
          <li class="purple"><a href="../../../Program Files/VertrigoServ/www/index.html">Titulo</a>
          <ul>  
                <li><a href='../../../Program Files/VertrigoServ/www/SUBLINK_1'>SUBTITULO</a></li>  
                <li><a href='../../../Program Files/VertrigoServ/www/SUBLINK_2'>SUBTITULO</a></li>  
                <li><a href='../../../Program Files/VertrigoServ/www/SUBLINK_3'>SUBTITULO</a></li>  
              </ul>  
          </li>
             <li class="purple"><a href="../../../Program Files/VertrigoServ/www/index.html">Titulo</a>
          <ul>  
                <li><a href='../../../Program Files/VertrigoServ/www/SUBLINK_1'>SUBTITULO</a></li>  
                <li><a href='../../../Program Files/VertrigoServ/www/SUBLINK_2'>SUBTITULO</a></li>  
                <li><a href='../../../Program Files/VertrigoServ/www/SUBLINK_3'>SUBTITULO</a></li>  
              </ul>  
          </li>
             <li class="purple"><a href="../../../Program Files/VertrigoServ/www/index.html">Titulo</a>
          <ul>  
                <li><a href='../../../Program Files/VertrigoServ/www/SUBLINK_1'>SUBTITULO</a></li>  
                <li><a href='../../../Program Files/VertrigoServ/www/SUBLINK_2'>SUBTITULO</a></li>  
                <li><a href='../../../Program Files/VertrigoServ/www/SUBLINK_3'>SUBTITULO</a></li>  
              </ul>  
          </li>
             <li class="purple"><a href="../../../Program Files/VertrigoServ/www/index.html">Titulo</a>
          <ul>  
                <li><a href='../../../Program Files/VertrigoServ/www/SUBLINK_1'>SUBTITULO</a></li>  
                <li><a href='../../../Program Files/VertrigoServ/www/SUBLINK_2'>SUBTITULO</a></li>  
                <li><a href='../../../Program Files/VertrigoServ/www/SUBLINK_3'>SUBTITULO</a></li>  
              </ul>  
          </li>
             <li class="purple"><a href="../../../Program Files/VertrigoServ/www/index.html">Titulo</a>
          <ul>  
                <li><a href='../../../Program Files/VertrigoServ/www/SUBLINK_1'>SUBTITULO</a></li>  
                <li><a href='../../../Program Files/VertrigoServ/www/SUBLINK_2'>SUBTITULO</a></li>  
                <li><a href='../../../Program Files/VertrigoServ/www/SUBLINK_3'>SUBTITULO</a></li>  
              </ul>  
          </li>
             
        </ul>
      </div>
    </nav>

  
        
        <!--CONTEUDO DO SITE-->
           <div class="grow pic"
             style="background-color:white; 
             width: 80%; height: 1000px; 
              margin-top: 0%;
              float: top;
              margin-left: 10%;
              ">
               <center>
               <p>
  <img src=
       "http://loja.imaginarium.com.br/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/I/m/Imagem_201_1538.jpg" 
       alt="portrait" width="50" height="100" style="margin-top:80px;  "></img>
     
       <img src=
            "http://loja.imaginarium.com.br/media/catalog/product/cache/1/small_image/720x/9df78eab33525d08d6e5fb8d27136e95/I/m/Imagem_201_1534.jpg" 
           width="50" height="100" style="margin-top:80px;"></img>
          
           <img src="http://modafeminina.biz/wp-content/uploads/2014/03/Louis-Vuitton1.jpg" 
               width="50" height="100" style="margin-top:80px; "></img>
               </p>
               <p>
          
               <img src="http://www.todavoce.com.br/wp-content/uploads/2010/06/historia-bolsas-13.jpg"  
                    width="50" height="100" style="margin-top:80px;"></img>
          
          <img src=
               "http://3o25uwxo8z93lfi0ydxf1qqo.wpengine.netdna-cdn.com/wp-content/uploads/2015/08/bolsa-paul-frank-6588776198a05b646e865623ae50a1fd1.jpg"
               width="50" height="100" style="margin-top:80px; "></img>
          
               <img src="http://www.muitofacil.biz/img/fotos/bolsa%20de%20franja%206.jpg" 
               width="50" height="100" style="margin-top:80px; "></img>
               </p>
               <p>
          
               <img src="http://www.dicasdemulher.com.br/wp-content/gallery/bolsa-lv-2/bolsa-lv-11.jpg" 
               width="50" height="100" style="margin-top:80px; "></img>
          
               <img src="http://www.lojasrenner.com.br/images/variant/large/535762870-16_z_1.jpg"   
               width="50" height="100" style="margin-top:80px; "></img>
          
               <img src="http://webluxo.com.br/home/wp-content/uploads/2015/06/bolsa-prada-2015-1.jpg"
               width="50" height="100" style="margin-top:80px; "></img>
               </p>
               </center>
        </div>
       
        
          <div id="final">
              
               <section class="about" style="margin-top: 50px">
                   
   
                   <p class="about-links">
      <a href="" target="_parent">Contato</a>
      <a href="" target="_parent">Sobre</a>
    </p>
    
                   <p class="about-author">
       <a href="" target="_blank"></a> 
      <a href="" target="_blank"></a><br>
      <a href="" target="_blank"></a>
    </p>
  
               </section>
        
          </div>
    </body>
</html>
