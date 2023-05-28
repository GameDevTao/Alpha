set WORKSPACE=..\

set GEN_CLIENT=%WORKSPACE%\Tools\ExcelPlugin\ClientServer.exe
set CONF_ROOT=%WORKSPACE%\Excel

%GEN_CLIENT% -j cfg --^
 -d %CONF_ROOT%\Defines\__root__.xml ^
 --input_data_dir %CONF_ROOT%\Datas ^
 --output_code_dir ..\Assets\Setting ^
 --output_data_dir ..\Assets\Table\json ^
 --gen_types code_cs_unity_json,data_json ^
 -s client 

pause