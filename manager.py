#!/usr/bin/env python
# REQUIRE mpg123 

import os, random, datetime, time;

def prtsrc(text):
    now = datetime.datetime.now()
    print("["+str(now.hour)+":"+str(now.minute)+":"+str(now.second)+"] - "+text);

now = datetime.datetime.now()
lastHour=int(now.hour);
musicCounter=0;
pubPlayListCounter=0;
currentPlayList="Variada";
currentMusic="";
playedProgram=False;

os.system("clear");
prtsrc("Playing Start intro");
os.system("mpg123 RSF_PUB.mp3 > /dev/null 2>&1");

while True:
    try:
        time.sleep(1);
    except KeyboardInterrupt as identifier:
        print("\nBYE!!");
        quit();

    # GESTOR DE MUSICAS
    currentMusic=random.choice(os.listdir("playlist_get/"+currentPlayList));
    prtsrc("Playing: "+currentMusic);
    current_file=open("CURRENT.txt", "w");
    current_file.write("Playing: "+currentMusic[:-4].replace("_", ' '));
    current_file.close();
    try:
        os.system("mpg123 'playlist_get/"+currentPlayList+"/"+currentMusic+"' > /dev/null 2>&1");
    except expression as identifier:
        prtsrc("ERROR PLAYING "+currentMusic);
	musicCounter=musicCounter+1;

	
    # PUBLICIDADES
    if(musicCounter>3):
        prtsrc("PUB!!!");
        if(pubPlayListCounter>4):
            os.system("mpg123 playlist_get/"+currentPlayList+"/intro.mp3 > /dev/null 2>&1");
            pubPlayListCounter=0;
        else:
            os.system("mpg123 pubs/"+random.choice(os.listdir("pubs/"))+" > /dev/null 2>&1");
            pubPlayListCounter=pubPlayListCounter+1;
        musicCounter=0;

    # RELOGIO
    now = datetime.datetime.now();
    if(now.hour!=lastHour):
        prtsrc("RELIGO das "+str(now.hour));
        os.system("mpg123 Clock/"+str(now.hour)+".mp3 > /dev/null 2>&1");
        lastHour=int(now.hour);
        playedProgram=False;
    
    # GESTOR DE PLAYLISTS
    now = datetime.datetime.now();
    if(now.hour==6):
        pubPlayListCounter=0;
        currentPlayList="POPRock";
    if(now.hour==12):
        pubPlayListCounter=0;
        currentPlayList="Variada";
    if(now.hour==18):
        pubPlayListCounter=0;
        currentPlayList="Dance";
    if(now.hour==22):
        pubPlayListCounter=0;
        currentPlayList="Romantic";

    # GESTOR DE PROGRAMAS
    now = datetime.datetime.now();
    if(now.hour==20 and playedProgram==False):
        playedProgram=True;
        prtsrc("Chapolin Colorado");
        os.system("mpg123 'programs/Chapolin Colorado/"+random.choice(os.listdir("programs/Chapolin Colorado/"))+"' > /dev/null 2>&1");
    if(now.hour==13 and playedProgram==False):
        playedProgram=True;
        prtsrc("Hora de leitura");
        os.system("mpg123 'programs/Hora de leitura/"+random.choice(os.listdir("programs/Hora de leitura/"))+"' > /dev/null 2>&1");
    if(now.hour==23 and playedProgram==False):
        playedProgram=True;
        prtsrc("Skecths");
        os.system("mpg123 'programs/Skecths/"+random.choice(os.listdir("programs/Skecths/"))+"' > /dev/null 2>&1");
    if(now.hour==10 and playedProgram==False):
        playedProgram=True;
        prtsrc("Chaves");
        os.system("mpg123 'programs/Chaves/"+random.choice(os.listdir("programs/Chaves/"))+"' > /dev/null 2>&1");
    
    # GESTOR DE INPUT STREAMS
    with open('STREAMING.TXT', 'r') as file:
        data = file.read().replace('\n', '')
        if(data!=""):
            prtsrc("RECEBENDO STREAMING de "+data+" ( ! PARA TERMINAR CTRL+C uma vez)");
            current_file=open("CURRENT.txt", "w");
            current_file.write("Playing: Our Program ");
            current_file.close();
            os.system("mpg123 "+data+" --loop -1 > /dev/null 2>&1");
            with open("STREAMING.TXT", "w") as text_file:
                text_file.write("");

    
