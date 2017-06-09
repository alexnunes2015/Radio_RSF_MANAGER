<HTML>
  <HEAD>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <TITLE>RSF - Player Dinamico</TITLE>
    <link rel="stylesheet" type="text/css" href="css/style.css">
    <link rel="shortcut icon" href="favicon.ico" type="image/x-icon" />
     <meta charset="UTF-8">
  </HEAD>
  <BODY onload="OnStart()">
    <img src="Images/all.jpg" style="position:fixed;top:0px;left:0px;width:100%;height:100%;z-index:-999;">
    <div id="page_title">
      <img src="Images/rsf_logo.png">
      <div style="display:inline-block;position:absolute;top:20px;left:120px;">
        <h3><i><b>Player Dinamico BETA</b></i></h3>
      </div>
    </div>
    <div id="Player_win">
        <img src="Images/visualizer.gif" style="position:absolute;height:220px;width:320px;top:100px;background-color:black;color:green;">
        <marquee direction="right" id="current_Music" style="border-radius:3px;margin-left:41;z-index:3;position:absolute;width:270px;top:327px;background-color:rgba(1,1,1,0.5);color:green;">Rede São Francisco</marquee>
        <audio id="rsf_player_1" hidden>
          <source src="http://rsf.ddns.net:8000/live">
        </audio>
        <audio id="rsf_player_2" hidden>
        </audio>
        <div id="player_ui">
          <img onclick="Switch_Muted()" id="muted_btn" src="Images/mute_0.png" width="32" style="cursor: pointer;">
        </div>
        <img onclick="Switch_Stream()" id="stream_btn" style="position:absolute;cursor: pointer;top:110px;left:10px;" src="Images/direct.png" height="24" width="120">
     </div>
     <div id="program_list">
       <center>
         <div id="add_programs">
            <select id="horas">
              <?php
               for($i=0;$i<24;$i++){
                 echo '<option value="'.$i.'">'.$i.'</option>';
               }
              ?>
           </select> Horas e
           <select id="Minutos">
              <?php
               for($i=0;$i<60;$i++){
                 echo '<option value="'.$i.'">'.$i.'</option>';
               }
              ?>
           </select> Minutos   |<select id="path">
              <option disabled>Playlists</option>
              <?php
                $plists=scandir("playlist_get/");
                foreach($plists as $plist){
                  if($plist!="." and $plist!=".." and $plist!="get.php"){
                    echo "<option id='playlist_get/".$plist."'/get.php>".$plist."</option>";
                  }
                }
              ?>
              <option disabled>_________</option>
              <option disabled>Programas</option>
              <?php
                $plists=scandir("programs/");
                foreach($plists as $plist){
                  if($plist!="." and $plist!=".." and $plist!="get.php"){
                    echo "<option id='programs/".$plist."'>".$plist."</option>";
                  }
                }
              ?>
           </select>
             |  Passa: <select id="dia_semana">
              <option id="fimdesemana">Durante o fim de semana</option>
              <option id="nasemana" selected>Durante a semana</option>
           </select>
           | | <button onclick="addProgram();">Adicionar</button>
         </div>
       </center>
       <center>
       <dir id="programas">
         <script>
            function loadList(){
              try{
                var programs_list = JSON.parse(localStorage["programs"]);
                if(programs_list.length>0){
                  var HTML="<div class='datagrid'><center><table>"+
                      "<thead>"+
                      "<tr>"+
                      "<th>Horas</th><th>Nome</th><th>Momento da semana</th><th></th>"+
                      "</tr>"+
                      "</thead>"+
                      "<tbody>";
                    for (i = 0; i < programs_list.length; i++) {
                      var tmp=programs_list[i].split("|");
                      HTML=HTML+"<tr><td width='10px'>"+tmp[1]+"</td><td width='200px'>"+tmp[2]+"</td><td width='150px'>"+tmp[3]+"</td><td style='text-align:right;'><a href='#' onclick='force(\""+tmp[0]+"\");'>Forçar</a> | <a href='#' onclick='remove(\""+tmp[0]+"\");'>Remover</a></td></tr>";
                    }
                    HTML=HTML+"</tbody>"+
                      "</table></center></div>";
                    document.getElementById("programas").innerHTML=HTML;
                  }else{
                  document.getElementById("programas").innerHTML="<h2><font color='red'>Não existem programas adicionados ainda</font></h2>";
                }
              }catch(e){
                document.getElementById("programas").innerHTML="<h2><font color='red'>Não existem programas adicionados ainda</font></h2>";
              }
            }
         </script>
       </dir>
       </center>
    </div>
  </BODY>
</HTML>

<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js" type="text/javascript"></script>
<script src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.4/jquery-ui.min.js" type="text/javascript"></script>
<script src="js/id3-minimized.js" type="text/javascript"></script>
<script>
 var current_Player=1;
 var current_PlayList="Variada/";
 var d = new Date();
 var lastHour = d.getHours();
 var sayHour=false;
 var flag_progamsList=false;
 var lastMinute=-1;
 var musicCounter=-1;
 var listenProgram="";

 setInterval(function(){
	 if(document.getElementById("rsf_player_2").paused && document.getElementById("rsf_player_1").paused){
		document.getElementById("rsf_player_1").src="RSF_PUB.mp3";
		document.getElementById("rsf_player_1").play(); 
		current_Player=1;
	}
 },9000)

 function Switch_Muted(){
   if(document.getElementById("rsf_player_1").muted){
     document.getElementById("rsf_player_1").muted=false;
     document.getElementById("rsf_player_2").muted=false;
     document.getElementById("muted_btn").src="Images/mute_0.png";
   }else{
     document.getElementById("rsf_player_1").muted=true;
     document.getElementById("rsf_player_2").muted=true;
     document.getElementById("muted_btn").src="Images/mute_1.png";
   }
 }

 function Switch_Stream(){
   if(document.getElementById("rsf_player_1").src!="http://rsf.ddns.net:8000/live"){
      document.getElementById("rsf_player_1").pause();
      document.getElementById("rsf_player_1").src="http://rsf.ddns.net:8000/live";
      document.getElementById("rsf_player_1").play();
      document.getElementById("rsf_player_2").pause();
      document.getElementById("stream_btn").src="Images/direct.png";
      document.getElementById("current_Music").innerText="Emissão Directo";
   }else{
     document.getElementById("rsf_player_1").pause();
     document.getElementById("rsf_player_1").src="RSF_PUB.mp3";
     document.getElementById("rsf_player_1").play();
     document.getElementById("rsf_player_2").pause();
     document.getElementById("stream_btn").src="Images/dynamic.png";
     document.getElementById("current_Music").innerText="Rádio Dinamica";
     getAudio("rsf_player_2");
   }
 }

 function getAudio(playerName){
	try {
		var xhttpa = new XMLHttpRequest();
		xhttpa.onreadystatechange = function() {
		if (this.readyState == 4 && this.status == 200) {
		   // Typical action to be performed when the document is ready:
		   document.getElementById(playerName).src = "playlist_get/"+current_PlayList+this.responseText;
		  }
		};
		xhttpa.open("GET", "playlist_get/"+current_PlayList+"get.php", true);
		xhttpa.send();
	}
	catch(err) {
		getAudio(playerName);
	}
 }

 function addProgram(){
   var newprograms = new Array();
   var newIndex=0;
   try{
     var tmpPrograms=JSON.parse(localStorage['programs']);
     for(var i=0;i<tmpPrograms.length;i++){
      var tmpString=tmpPrograms[i].split("|");
      newprograms[newIndex]=newIndex+"|"+tmpString[1]+"|"+tmpString[2]+"|"+tmpString[3];
      newIndex++;
     }
   }catch(e){}   
   newprograms[newIndex]=newIndex+"|"+document.getElementById("horas").value+":"+document.getElementById("Minutos").value+"|"+document.getElementById("path").value+"|"+document.getElementById("dia_semana").value;
   localStorage["programs"]=JSON.stringify(newprograms);
   loadList();
 }

 function force(id){
	 var currentTMP="";
	 var tmpPrograms=JSON.parse(localStorage["programs"]);
	 for(var i=0;i<tmpPrograms.length;i++){
	   var tmpString=tmpPrograms[i].split("|");
	   if(tmpString[0]==id){
		 currentTMP=tmpString[2];
	   }
	 }
	 //Check if is list
	 var isList
	 var serverPrograms=new Array();
     <?php
        $plists=scandir("playlist_get/");
        $id=0;
        foreach($plists as $plist){
          if($plist!="." and $plist!=".." and $plist!="get.php"){
            echo 'serverPrograms['.$id.']="'.$plist.'";';
            $id++;
          }
        }
     ?>
	 ////////////////////
	 if(serverPrograms.indexOf(currentTMP) > -1){
		current_PlayList=currentTMP+"/";
	  }else{
		try{
			var xhttpb = new XMLHttpRequest();
			xhttpb.onreadystatechange = function() {
			if (this.readyState == 4 && this.status == 200) {
			   // Typical action to be performed when the document is ready:
				listenProgram="programs/"+currentTMP+"/"+ this.responseText;
			  }
			};
			xhttpb.open("GET", "programs/"+currentTMP+"/get.php", true);
			xhttpb.send();
		}catch(err){
				
		}
	  }
	  alert("Evento '"+currentTMP+"' forçado com exito");
}
 
 function remove(id){
   if(confirm("Tem a certeza que pertende apagar este evento?")){
     var newprograms = new Array();
     var tmpPrograms=JSON.parse(localStorage["programs"]);
     var newIndex=0;
     for(var i=0;i<tmpPrograms.length;i++){
       var tmpString=tmpPrograms[i].split("|");
       if(tmpString[0]!=id){
         newprograms[newIndex]=newIndex+"|"+tmpString[1]+"|"+tmpString[2]+"|"+tmpString[3];
         newIndex++;
       }
     }
     localStorage["programs"]=JSON.stringify(newprograms);
   }
   loadList();
 }

 function getID3(playerName){
   ID3.loadTags(document.getElementById(playerName).src, function() {
	  try{
		  var tags = ID3.getAllTags(document.getElementById(playerName).src);
		  document.getElementById("current_Music").innerText=tags.artist + " - " + tags.title;
	  }catch(err){
		  document.getElementById("current_Music").innerText="Rádio São Francisco";
	  }

  });
 }

 function OnStart(){
   document.getElementById("rsf_player_1").src="http://rsf.ddns.net:8000/live";
   document.getElementById("rsf_player_1").play();
   loadList();
   setInterval(Manager,900);
  }

 function Manager(){
   var tmpD = new Date();
   var tmpH = tmpD.getHours();
   var tmpM = tmpD.getMinutes();
 
   if(listenProgram==""){
     if(lastHour!=tmpH){
       sayHour=true;
       lastHour=tmpH;
     }
   }
   if(musicCounter==2){
     musicCounter=0;
     try{
		 var xhttpa = new XMLHttpRequest();
		  xhttpa.onreadystatechange = function() {
		  if (this.readyState == 4 && this.status == 200) {
			 // Typical action to be performed when the document is ready:
			 if(current_Player==1){
				document.getElementById("rsf_player_2").src = "pubs/"+ this.responseText;
			  }else{
				document.getElementById("rsf_player_1").src = "pubs/"+ this.responseText;
			  }
			}
		  };
		  xhttpa.open("GET", "pubs/get.php", true);
		  xhttpa.send();
      }catch(err){
	  }
   }else{
     var tmpPrograms=JSON.parse(localStorage['programs']);
     var serverPrograms=new Array();
     <?php
        $plists=scandir("playlist_get/");
        $id=0;
        foreach($plists as $plist){
          if($plist!="." and $plist!=".." and $plist!="get.php"){
            echo 'serverPrograms['.$id.']="'.$plist.'";';
            $id++;
          }
        }
     ?>
     for(var i=0;i<tmpPrograms.length;i++){
      var tmpString=tmpPrograms[i].split("|");
      var tmpHour=tmpString[1].split(":");
      var playInThisDay=false;
      if(tmpString[3]=="Durante o fim de semana" && (([0,6].indexOf(new Date().getDay()) != -1)==true)){
        playInThisDay=true;
      }
      if(tmpString[3]=="Durante a semana" && (([0,6].indexOf(new Date().getDay()) != -1)==false)){
        playInThisDay=true;
      }
      if((tmpHour[0]==tmpH) && (tmpHour[1]==tmpM) && (lastMinute!=tmpM) && playInThisDay){
		  if(serverPrograms.indexOf(tmpString[2]) > -1){
			current_PlayList=tmpString[2];
		  }else{
			try{
				var xhttpb = new XMLHttpRequest();
				xhttpb.onreadystatechange = function() {
				if (this.readyState == 4 && this.status == 200) {
				   // Typical action to be performed when the document is ready:
					listenProgram="programs/"+tmpString[2]+"/"+ this.responseText;
				  }
				};
				xhttpb.open("GET", "programs/"+tmpString[2]+"/get.php", true);
				xhttpb.send();
			}catch(err){
					
			}
		  }
        if(current_Player==1){
          getAudio("rsf_player_2");
        }else{
          getAudio("rsf_player_1");
        }
        lastMinute=tmpM;
        current_PlayList=current_PlayList+"/";
        break;
      }
     }
   }
 }


 $("#rsf_player_1").bind('ended', function(){
	try{
	  if(listenProgram==""){
		  if(sayHour){
			document.getElementById("rsf_player_1").src="Clock/"+lastHour+".mp3";
			document.getElementById("rsf_player_1").play();
			sayHour=false;
			getAudio("rsf_player_2");
		  }else{
			musicCounter++;
			document.getElementById("rsf_player_2").play();
			document.getElementById("rsf_player_1").src="";
			current_Player=2;
			getAudio("rsf_player_1");
		  }
		  getID3("rsf_player_2");
	  }else{
		  document.getElementById("rsf_player_2").src=listenProgram;
		  document.getElementById("rsf_player_2").play();
	  }
      listenProgram="";
     }catch(err){}
  });
  $("#rsf_player_2").bind('ended', function(){
	  try{
		if(listenProgram==""){
		  if(sayHour){
			document.getElementById("rsf_player_2").src="Clock/"+lastHour+".mp3";
			document.getElementById("rsf_player_2").play();
			sayHour=false;
			getAudio("rsf_player_1");
		  }else{
			musicCounter++;
			document.getElementById("rsf_player_1").play();
			document.getElementById("rsf_player_2").src="";
			current_Player=1;
			getAudio("rsf_player_2");
		  }
		  getID3("rsf_player_2");
      }else{
		  document.getElementById("rsf_player_1").src=listenProgram;
		  document.getElementById("rsf_player_1").play();
	  }
      listenProgram="";
     }catch(err){}
  });
</script>
