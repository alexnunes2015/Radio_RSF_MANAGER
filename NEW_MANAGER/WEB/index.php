<HTML>
  <HEAD>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <TITLE>RSF - Player Dinamico</TITLE>
    <link rel="stylesheet" type="text/css" href="css/style.css">
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
          <source src="RSF_PUB.mp3"> 
        </audio>
        <audio id="rsf_player_2" hidden>
          <source src=".mp3"> 
        </audio>
        <div id="player_ui">
          <img onclick="Switch_Muted()" id="muted_btn" src="Images/mute_0.png" width="32" style="cursor: pointer;">
        </div>
        <img onclick="Switch_Stream()" id="stream_btn" style="position:absolute;cursor: pointer;top:110px;left:10px;" src="Images/dynamic.png" height="24" width="120">
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
              <option id='playlist_get/get.php'>Variada</option>
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
                      HTML=HTML+"<tr><td width='10px'>"+tmp[1]+"</td><td width='200px'>"+tmp[2]+"</td><td width='150px'>"+tmp[3]+"</td><td style='text-align:right;'><a href='#' onclick='remove(\""+tmp[0]+"\");'>Remover</a></td></tr>";
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
 var current_PlayList="";
 var d = new Date();
 var lastHour = d.getHours();
 var sayHour=false;
 var flag_progamsList=false;
 var lastMinute=-1;
 /*localStorage.removeItem("programs"); // Apenas para apagar em DEBUG
 var programs = new Array();
 programs[0]="0|00:00|ipja|sdjoads";
 programs[1]="1|00:00|pjasdj|odaasdds";
 programs[2]="2|00:00|pjasdj|oads";
 localStorage["programs"]=JSON.stringify(programs);*/
  
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
   if(document.getElementById("rsf_player_1").src!="http://rsf.ddns.net:8000/live.mp3"){
      document.getElementById("rsf_player_1").pause();
      document.getElementById("rsf_player_1").src="http://rsf.ddns.net:8000/live.mp3";
      document.getElementById("rsf_player_1").play();
      document.getElementById("stream_btn").src="Images/direct.png";
   }else{
     document.getElementById("rsf_player_1").pause();
     document.getElementById("rsf_player_1").src="RSF_PUB.mp3";
     document.getElementById("rsf_player_1").play();
     document.getElementById("stream_btn").src="Images/dynamic.png";
     getAudio("rsf_player_2"); 
   }
 }
    
 function getAudio(playerName){
   var xhttpa = new XMLHttpRequest();
    xhttpa.onreadystatechange = function() {
    if (this.readyState == 4 && this.status == 200) {
       // Typical action to be performed when the document is ready:
       document.getElementById(playerName).src = "playlist_get/"+current_PlayList+ this.responseText;
      }
    };
    xhttpa.open("GET", "playlist_get/"+current_PlayList+"get.php", true);
    xhttpa.send();   
 }
  
  
 function addProgram(){
   var newprograms = new Array();
   var newIndex=0;
   try{
     var tmpPrograms=JSON.parse(localStorage["programs"]);
     for(var i=0;i<tmpPrograms.length;i++){
      var tmpString=tmpPrograms[i].split("|");
      newprograms[newIndex]=newIndex+"|"+tmpString[1]+"|"+tmpString[2]+"|"+tmpString[3];
      newIndex++;
     }
   }catch(e){}   newprograms[newIndex]=newIndex+"|"+document.getElementById("horas").value+":"+document.getElementById("Minutos").value+"|"+document.getElementById("path").value+"|"+document.getElementById("dia_semana").value;
   localStorage["programs"]=JSON.stringify(newprograms);
   loadList();
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
      var tags = ID3.getAllTags(document.getElementById(playerName).src);
      document.getElementById("current_Music").innerText=tags.artist + " - " + tags.title;
     });
 }
    
 function OnStart(){
   getAudio("rsf_player_2"); 
   document.getElementById("rsf_player_1").play();
   loadList();
   setInterval(Manager,900);
  }
    
 function Manager(){
   var tmpD = new Date();
   var tmpH = tmpD.getHours(); 
   var tmpM = tmpD.getMinutes();
   if(lastHour!=tmpH){
     sayHour=true;
     lastHour=tmpH;
   }
   var tmpPrograms=JSON.parse(localStorage["programs"]);
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
    if((tmpHour[0]==tmpH) && (tmpHour[1]==tmpM) && (lastMinute!=tmpM)){
      if(tmpString[1]!="Variada"){
        if(serverPrograms.indexOf(tmpString[2]) > -1){
          current_PlayList=tmpString[2];
        }
      }else{
        current_PlayList="";
      }
      if(current_Player==1){
        getAudio("rsf_player_2"); 
        alert("Player 2");
      }else{
        getAudio("rsf_player_1"); 
        alert("Player 1");
      }
      lastMinute=tmpM;
      current_PlayList=current_PlayList+"/";
      break;
    }
   }
 } 
 
 $("#rsf_player_1").bind('ended', function(){
      document.getElementById("rsf_player_2").play();
      document.getElementById("rsf_player_1").src="";
      current_Player=2;
      if(sayHour){
        document.getElementById("rsf_player_1").src="Clock/"+lastHour+".wav";
        sayHour=false;
      }else{
        getAudio("rsf_player_1");  
      }
      getID3("rsf_player_2");      
  });
  $("#rsf_player_2").bind('ended', function(){
      document.getElementById("rsf_player_1").play();
      document.getElementById("rsf_player_2").src="";
      current_Player=1;
      if(sayHour){
        document.getElementById("rsf_player_2").src="Clock/"+lastHour+".wav";
        sayHour=false;
      }else{
        getAudio("rsf_player_2");  
      }
      getID3("rsf_player_2");
  });
</script>
