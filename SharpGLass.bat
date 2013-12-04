@ECHO off
set targetdir=%cd%
cd "../../../../SharpGLass"
set refloco=../DnD/DnD-fancy/Ref
echo %cd%
MSBuild ../SharpGLass/SharpGLass.sln /t:Rebuild /p:Configuration=Debug /nologo
cd SharpGLass/bin/Debug
copy SharpGlass.* %targetdir%
copy SharpGLass.* %refloco%