#! /bin/sh

echo "Download Unity"
curl -o cs/Unity.pkg https://netstorage.unity3d.com/unity/5d30cf096e79/MacEditorInstaller/Unity-2017.1.1f1.pkg

echo "Install Unity"
sudo installer -dumplog -package cs/Unity.pkg -target /
