REM WEB API WARM UP
bin\ab.exe -n 10000 -c 100 -H Accept:application/json http://localhost:62157/api/hello
REM WEB API
bin\ab.exe -n 100000 -c 100 -H Accept:application/json -g webapi.dat http://localhost:62157/api/hello

REM SERVICESTACK WARM UP
bin\ab.exe -n 10000 -c 100 -H Accept:application/json http://localhost:57119/hello
REM SERVICESTACK
bin\ab.exe -n 100000 -c 100 -H Accept:application/json -g servicestack.dat http://localhost:57119/hello

REM ### Generate graph ###
bin\gnuplot460win32\gnuplot.exe plot.p

del webapi.dat
del servicestack.dat