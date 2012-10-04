REM ### Web API ###
bin\ab.exe -n 100 -c 10 -H Accept:application/json -g webapi.dat http://localhost:62157/api/hello
bin\gnuplot460win32\gnuplot.exe webapi_plot.p
del webapi.dat