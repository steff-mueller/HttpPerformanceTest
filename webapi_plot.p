# output as png image
set terminal png

# save file to "out.png"
set output "webapi.png"

# graph title
set title "ab -n 100 -c 10"

# nicer aspect ratio for image size
set size 1,0.7

# y-axis grid
set grid y

# x-axis label
set xlabel "request"

# y-axis label
set ylabel "response time (ms)"

# plot data from "webapi.dat" using column 9 with smooth sbezier lines
# and title of "asp.net Web API" for the given data
plot "webapi.dat" using 9 smooth sbezier with lines title "asp.net Web API"