@echo off
cls

.paket\paket.exe restore
if errorlevel 1 (
  exit /b %errorlevel%
)

pushd Content\
call build.cmd
call build.cmd Clean
popd

packages\build\FAKE\tools\FAKE.exe build.fsx %*
