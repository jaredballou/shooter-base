#!/bin/bash

#cd /
#sudo mkdir valve
#cd valve
#sudo wget http://media.steampowered.com/client/runtime/steam-runtime-sdk_latest.tar.xz
#sudo tar xvf steam-runtime-sdk_latest.tar.xz
#sudo mv steam-runtime-sdk_2013-09-05 steam-runtime

cd source-sdk-2013/sp/src
./createallprojects
./creategameprojects
cd ../../mp/src
./createallprojects
./creategameprojects
