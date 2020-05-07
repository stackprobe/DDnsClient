C:\Factory\Tools\RDMD.exe /RC out

COPY /B DDnsClient\DDnsClient\bin\Release\DDnsClient.exe out
COPY /B DDnsClient\DDnsClient\dc16_error.ico out\ErrorIcon.dat

C:\Factory\Tools\xcp.exe doc out

C:\Factory\SubTools\zip.exe /O out DDnsClient

IF NOT "%1" == "/-P" PAUSE
