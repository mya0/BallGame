#! /bin/sh

  /Applications/Unity/Unity.app/Contents/MacOS/Unity \
	-batchmode \
	-nographics \
	-silent-crashes \
	-logFile $(pwd)/unity.log \
	-projectPath "$(pwd)" \
	-buildOSXUniversalPlayer "$(pwd)/Build/osx/BallGame.app" \
	-quit
  
  cat $(pwd)/unity.log
