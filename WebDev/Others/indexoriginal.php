<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html>
    <head>
        <title>Feira de exportacacao</title>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
		<meta name="description" content="Fixed Fade Out Menu: A CSS and jQuery Tutorial" />
        
        <link rel="stylesheet" href="css/style.css" type="text/css" charset="utf-8"/>
        <link rel="stylesheet" href="css/style1.css">
    </head>
    <style>
        body{
            margin:0px;
            padding:0px;           
            font-family:Arial;
			 background:#eea78a   no-repeat top center;
        }
		a.back{
            width:256px;
            height:73px;
            position:fixed;
            bottom:15px;
            right:15px;
            background:transparent  no-repeat top left;
        }
        .scroll{
            width:133px;
            height:61px;
            position:fixed;
            bottom:15px;
            left:20px;
            background:transparent  no-repeat top left;
        }
        .info{
            text-align:right;

        }
		.desc{
			height:90px;
			width:100%;
			position:absolute;
			top:1000px;
			left:0px;
			background:transparent  no-repeat center center;
		}
		#top{
			top:0px;
			left:0px;
			position:absolute;
			width:100%;
			height:10px;
		}
		#bottom{
			top:1500px;
			left:0px;
			position:absolute;
			width:100%;
			height:90px;
			
		}
           
                
                #mbtnavbar { 
    background: #060505; 
    width: auto; 
    color: #FFF; 
        margin: 0px; 
        padding: 0; 
        position: relative; 
        border-top:0px solid #960100; 
        height:35px; 
} 
#mbtnav { 
    margin: 0; 
    padding: 0; 
} 
#mbtnav ul { 
    float: left; 
    list-style: none; 
    margin: 0; 
    padding: 0; 
} 
#mbtnav li { 
    list-style: none; 
    margin: 0; 
    padding: 0; 
        border-left:1px solid #333; 
        border-right:1px solid #333; 
        height:35px; 
} 
#mbtnav li a, #mbtnav li a:link, #mbtnav li a:visited { 
    color: #FFF; /* fundo dos titulos*/
    display: block; 
   font:normal 12px Helvetica, sans-serif; 
   margin: 0; 
    padding: 9px 12px 10px 12px; 
        text-decoration: none; 
} 
#mbtnav li a:hover, #mbtnav li a:active { 
    background: #000000; /*MUDA O FUNDO DO TITULO*/
    color: #FFF; /* muda a cor DO TEXTO DO TITULO*/ 
    display: block; 
    text-decoration: none; 
        margin: 0; 
    padding: 9px 12px 10px 12px; 
} 
#mbtnav li { 
    float: left; 
    padding: 0; 
} 
#mbtnav li ul { 
    z-index: 9999; 
    position: absolute; 
    left: -999em; 
    height: auto; 
    width: 160px; 
    margin: 0; 
    padding: 0; 
} 
#mbtnav li ul a { 
    width: 140px; 
} 
#mbtnav li ul ul { 
    margin: -25px 0 0 161px; 
} 
#mbtnav li:hover ul ul, #mbtnav li:hover ul ul ul, #mbtnav li.sfhover ul ul, #mbtnav li.sfhover ul ul ul { 
    left: -999em; 
} 
#mbtnav li:hover ul, #mbtnav li li:hover ul, #mbtnav li li li:hover ul, #mbtnav li.sfhover ul, #mbtnav li li.sfhover ul, #mbtnav li li li.sfhover ul { 
    left: auto; 
} 
#mbtnav li:hover, #mbtnav li.sfhover { 
    position: static; 
} 
#mbtnav li li a, #mbtnav li li a:link, #mbtnav li li a:visited { 
    background: #333333;/*FUNDO DO SUBTITULO*/ 
    width: 120px; 
    color: #FFF; /*MUDA A COR DO TEXTO DO SUBTITULO*/
    display: block;  
    font:normal 12px Helvetica, sans-serif; 
    margin: 0; 
    padding: 9px 12px 10px 12px; 
    text-decoration: none; 
    z-index:9999; 
    border-bottom:1px dotted #333; 
} 
#mbtnav li li a:hover, #mbtnavli li a:active { 
    background: #000000; /* MUDA A COR QUANDO PASSA ENCIMA DO SUBTITULO*/ 
    color: #FFF; /* MUDA A COR DO TEXTO DO SUBTITULO*/
    display: block; 
    margin: 0; 
    padding: 9px 12px 10px 12px; 
    text-decoration: none; 
}

.grow img {
  height: 200px;
  width: 200px;
 /*EM CIMA  O TAMANHO QUE VAI FICAR */
  -webkit-transition: all 1s ease;
     -moz-transition: all 1s ease;
       -o-transition: all 1s ease;
      -ms-transition: all 1s ease;
          transition: all 1s ease;
}
 
.grow img:hover {
  width: 300px;
  height: 300px;
  /*EM CIMA TAMNHO QUE VAI CRESCER*/
}

#final
{
    left:0px;
    position:absolute;
    width:100%;
    height:200px;
    margin-top:100px;/* AQUI MUDA ATE ONDE VAI O PRETO*/
    background-color:#333333;                  
			
    /* TRANSICAO DE FOTOS*/
    

    </style>
    <body >
     
        </div>
        
        <div id="nav"> 
            <ul>
                
                 <li><a>JA E CADASTRADO?</a></li> 
                
               <li><a>CONTATO</a></li>
                
                <li><a class="top" href="#top"><span></span></a></li>
                <li><a class="bottom" href="#bottom"><span></span></a></li>
                <a class="bottom" ><img src="/images/home.jpg" width="18" height="15"></a></li>
                
                <li class="search">
		<input type="text"/><input class="searchbutton" type="submit" value=""/>
		</li>
            
             <li><a class="bottom" 
             <a class="bottom" ><img src="/images/carrinho.png" width="18" height="15"></a></li>
               
                
            </ul>
        </div>        
		<div id="top"></div>
		<div class="desc"></div>
		<div id="bottom"></div>
		<div class="scroll"></div>
        <div class="info">
            <a class="back" href=""></a>
            
                
        </div>

        <script type="text/javascript" src="jquery-1.3.2.js"></script>
        <script type="text/javascript">
           $(function() {
                $(window).scroll(function(){
					var scrollTop = $(window).scrollTop();
					if(scrollTop !== 0)
						$('#nav').stop().animate({'opacity':'0.2'},400);
					else	
						$('#nav').stop().animate({'opacity':'1'},400);
				});
				
				$('#nav').hover(
					function (e) {
						var scrollTop = $(window).scrollTop();
						if(scrollTop !== 0){
							$('#nav').stop().animate({'opacity':'1'},400);
						}
					},
					function (e) {
						var scrollTop = $(window).scrollTop();
						if(scrollTop !== 0){
							$('#nav').stop().animate({'opacity':'0.2'},400);
						}
					}
				);
            }); 
        </script>
        
        
           
        
            
            <!--transicao�o-->
    </body>
    <style>
       	
		
		a,img {border: none;}
		.trs {-webkit-transition:all ease-out 0.5s;
			-moz-transition:all ease-out 0.5s;
			-o-transition:all ease-out 0.5s;
			-ms-transition:all ease-out 0.5s;
			transition:all ease-out 0.5s;}
		
		#slider {position: relative; z-index: 1;}
		#slider a { position: absolute; top: 0; left: 0; opacity: 0;filter:alpha(opacity=0);}
		.ativo {opacity: 1!important; filter:alpha(opacity=100)!important;}
		
		/*controladores*/
		span {background: #0190EE; cursor: pointer; opacity: 0;filter:alpha(opacity=0); position: absolute; bottom: 40%; width: 43px; height: 43px; z-index: 5;}
		.next {right: 10px;}
		.next:before,.next:after {left: 21px;}
		.next:before {
			-webkit-transform: rotate(-42deg);
			top: 5px;
		}
		.next:after {
			-webkit-transform: rotate(-132deg);
			top: 19px;
		}
		.next:before,.next:after,.prev:before,.prev:after {content: "";
			height: 20px;
			background: #fff;
			width: 1px;
			position: absolute;
		}
		.prev {left: 10px;}
		.prev:before,.prev:after {left: 18px;}
		.prev:before {
			-webkit-transform: rotate(42deg);
			top: 5px;
		}
		.prev:after {
			-webkit-transform: rotate(132deg);
			top: 19px;
		}
		figure:hover span {opacity: 0.76;filter:alpha(opacity=76);}
		figure {
			max-width: 937px;
			height: 354px;
			position: relative;
			overflow: hidden;
			margin: 50px auto;
		}
		figcaption {padding-left: 20px;color: #fff; font-family: "Kaushan Script","Lato","arial"; font-size: 22px; background: rgba(1, 144, 238, 0.76); width: 100%; position: absolute; bottom: 0; left: 0; line-height: 55px; height: 55px; z-index: 5}
	 
	 #meio
	 {
		 background-color:#333333;
		 width:auto;
		 height:auto;
                 
		 
		 }
		
     
   
}
        </style>
        <body>
            <div id="meio">
              
	<figure>
		<span class="trs next"></span>
		<span class="trs prev"></span>

		<div id="slider">
                    <a href="#" class="trs" <img src="imagem1.jpg" alt="LEGENDA"
                                                 style="margin-left:25%" width="90%" height="300"></img></a>
                    <a href="#" class="trs"><img src="imagem3.jpg" alt="MINHA LEGENDA 2" 
                                                 style="margin-left:25%" width="90%" height="300"></img>
                    </a>		
		</div>

		<figcaption></figcaption>
	</figure>

	<script type="text/javascript">
		function setaImagem(){
			var settings = {
				primeiraImg: function(){
					elemento = document.querySelector("#slider a:first-child");
					elemento.classList.add("ativo");
					this.legenda(elemento);
				},
				slide: function(){
					elemento = document.querySelector(".ativo");
					if(elemento.nextElementSibling){
						elemento.nextElementSibling.classList.add("ativo");
						settings.legenda(elemento.nextElementSibling);
						elemento.classList.remove("ativo");
					}else{
						elemento.classList.remove("ativo");
						settings.primeiraImg();
					}
				},
				proximo: function(){
					clearInterval(intervalo);
					elemento = document.querySelector(".ativo");
					
					if(elemento.nextElementSibling){
						elemento.nextElementSibling.classList.add("ativo");
						settings.legenda(elemento.nextElementSibling);
						elemento.classList.remove("ativo");
					}else{
						elemento.classList.remove("ativo");
						settings.primeiraImg();
					}
					intervalo = setInterval(settings.slide,4000);
				},
				anterior: function(){
					clearInterval(intervalo);
					elemento = document.querySelector(".ativo");
					
					if(elemento.previousElementSibling){
						elemento.previousElementSibling.classList.add("ativo");
						settings.legenda(elemento.previousElementSibling);
						elemento.classList.remove("ativo");
					}else{
						elemento.classList.remove("ativo");						
						elemento = document.querySelector("a:last-child");
						elemento.classList.add("ativo");
						this.legenda(elemento);
					}
					intervalo = setInterval(settings.slide,4000);
				},
				legenda: function(obj){
					var legenda = obj.querySelector("img").getAttribute("alt");
					document.querySelector("figcaption").innerHTML = legenda;
				}
			}
			//chama o slide
			settings.primeiraImg();
			//chama a legenda
			settings.legenda(elemento);
			//chama o slide à um determinado tempo
			var intervalo = setInterval(settings.slide,4000);
			document.querySelector(".next").addEventListener("click",settings.proximo,false);
			document.querySelector(".prev").addEventListener("click",settings.anterior,false);
		}
		window.addEventListener("load",setaImagem,false);
	</script>
    </div>
        </body>
    <body>
        <div id="preenchre" style="width:auto;height: 90px;background-color: blue;
             margin-top: 50%;
             float: left;"></div>
       
                
                <nav>
      <div class="mbtnavbar">
        <ul id='mbtnav'>
             <li><a href='LINK da Home'>Home</a></li>  
          <li class="yellow"><a href="index.html">Título</a>
              <ul>  
                <li><a href='SUBLINK_1'>SUBTITULO</a></li>  
                <li><a href='SUBLINK_2'>SUBTITULO</a></li>  
                <li><a href='SUBLINK_3'>SUBTITULO</a></li>  
              </ul>  
          </li>
          <li class="green"><a href="index.html">Título</a>
          <ul>  
                <li><a href='SUBLINK_1'>SUBTITULO</a></li>  
                <li><a href='SUBLINK_2'>SUBTITULO</a></li>  
                <li><a href='SUBLINK_3'>SUBTITULO</a></li>  
              </ul>  
          </li>
          <li class="active"><a href="index.html">Título</a>
          <ul>  
                <li><a href='SUBLINK_1'>SUBTITULO</a></li>  
                <li><a href='SUBLINK_2'>SUBTITULO</a></li>  
                <li><a href='SUBLINK_3'>SUBTITULO</a></li>  
              </ul>  
          </li>
          <li class="red"><a href="index.html">Título</a>
          <ul>  
                <li><a href='SUBLINK_1'>SUBTITULO</a></li>  
                <li><a href='SUBLINK_2'>SUBTITULO</a></li>  
                <li><a href='SUBLINK_3'>SUBTITULO</a></li>  
              </ul>  
          </li>
          <li class="purple"><a href="index.html">titulo</a>
          <ul>  
                <li><a href='SUBLINK_1'>SUBTITULO</a></li>  
                <li><a href='SUBLINK_2'>SUBTITULO</a></li>  
                <li><a href='SUBLINK_3'>SUBTITULO</a></li>  
              </ul>  
          </li>
             <li class="purple"><a href="index.html">Ttitulo</a>
          <ul>  
                <li><a href='SUBLINK_1'>SUBTITULO</a></li>  
                <li><a href='SUBLINK_2'>SUBTITULO</a></li>  
                <li><a href='SUBLINK_3'>SUBTITULO</a></li>  
              </ul>  
          </li>
             <li class="purple"><a href="index.html">Titulo</a>
          <ul>  
                <li><a href='SUBLINK_1'>SUBTITULO</a></li>  
                <li><a href='SUBLINK_2'>SUBTITULO</a></li>  
                <li><a href='SUBLINK_3'>SUBTITULO</a></li>  
              </ul>  
          </li>
             <li class="purple"><a href="index.html">Titulo</a>
          <ul>  
                <li><a href='SUBLINK_1'>SUBTITULO</a></li>  
                <li><a href='SUBLINK_2'>SUBTITULO</a></li>  
                <li><a href='SUBLINK_3'>SUBTITULO</a></li>  
              </ul>  
          </li>
             <li class="purple"><a href="index.html">Titulo</a>
          <ul>  
                <li><a href='SUBLINK_1'>SUBTITULO</a></li>  
                <li><a href='SUBLINK_2'>SUBTITULO</a></li>  
                <li><a href='SUBLINK_3'>SUBTITULO</a></li>  
              </ul>  
          </li>
             
        </ul>
      </div>
    </nav>
  </header>
        <div class="grow pic"
             style="background-color:white; 
             width: 80%; height: 1000px; 
              margin-top: 5%;
              float: top;
              margin-left: 10%;
              ">
  <img src="http://loja.imaginarium.com.br/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/I/m/Imagem_201_1538.jpg" alt="portrait"
       width="50" height="100" style="margin-top:80px;margin-left: 50px"></img>
     
       <img src="http://loja.imaginarium.com.br/media/catalog/product/cache/1/small_image/720x/9df78eab33525d08d6e5fb8d27136e95/I/m/Imagem_201_1534.jpg" 
           width="50" height="100" style="margin-top:80px"></img>
          
           <img src="http://modafeminina.biz/wp-content/uploads/2014/03/Louis-Vuitton1.jpg" 
               width="50" height="100" style="margin-top:80px"></img>
          
               <img src="http://www.todavoce.com.br/wp-content/uploads/2010/06/historia-bolsas-13.jpg"  
                    width="50" height="100" style="margin-top:80px;margin-left: 50px"></img>
          
          <img src="http://3o25uwxo8z93lfi0ydxf1qqo.wpengine.netdna-cdn.com/wp-content/uploads/2015/08/bolsa-paul-frank-6588776198a05b646e865623ae50a1fd1.jpg"
               width="50" height="100" style="margin-top:80px"></img>
          
               <img src="http://www.muitofacil.biz/img/fotos/bolsa%20de%20franja%206.jpg" 
               width="50" height="100" style="margin-top:80px;"></img>
          
               <img src="http://www.dicasdemulher.com.br/wp-content/gallery/bolsa-lv-2/bolsa-lv-11.jpg" 
               width="50" height="100" style="margin-top:80px;margin-left: 50px"></img>
          
               <img src="http://www.lojasrenner.com.br/images/variant/large/535762870-16_z_1.jpg"   
               width="50" height="100" style="margin-top:80px;"></img>
          
               <img src="http://webluxo.com.br/home/wp-content/uploads/2015/06/bolsa-prada-2015-1.jpg"
               width="50" height="100" style="margin-top:80px"></img>
        </div>

  <div id="final">
        </div>
        
    </body>
</html>



