@echo off
cls

.paket\paket.exe restore
if errorlevel 1 (
  exit /b %errorlevel%
)

pushd Content\
call build.cmd
if errorlevel 1 (
  exit /b %errorlevel%
)
call build.cmd Clean
if errorlevel 1 (
  exit /b %errorlevel%
)
popd

packages\build\FAKE\tools\FAKE.exe build.fsx %*
