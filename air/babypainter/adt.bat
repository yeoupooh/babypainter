@echo off

call set_air
rem set AIRSDK_HOME=d:\Apps\AdobeAIRSDK

set APP_KEYFILE="example.pfx"
set APP_KEYPASS=example

set APP_PATH="bin-debug"

call set_app

echo APP_NAME=%APP_NAME%
echo APP_ADDED_FILES=%APP_ADDED_FILES%
echo.

set APP_AIRFILE="%APP_NAME%.air"
set APP_XMLFILE="%APP_PATH%\%APP_NAME%-app.xml"
set APP_SWFFILE="%APP_NAME%.swf"

echo APP_AIRFILE=%APP_AIRFILE%
echo APP_XMLFILE=%APP_XMLFILE%
echo APP_SWFFILE=%APP_SWFFILE%
echo.

java -jar "%AIRSDK_HOME%\lib\adt.jar" -package -storetype pkcs12 -keystore %APP_KEYFILE% -storepass %APP_KEYPASS% %APP_AIRFILE% %APP_XMLFILE% -C %APP_PATH% %APP_SWFFILE% %APP_ADDED_FILES%

pause