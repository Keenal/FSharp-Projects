# Lucas's Square Pyramid (F#)

DOS Project 1 by Udit Jaitly and Keenal Shah


# Work Unit 

  - After multiple experiments, we found 10 worker actors to provide an efficient solution to implement parellelism. Each actor performs computation for N / 10.
  - A supervisor actor spawns ten worker actors. Each actor is given a range in form of starting limit and ending limit. For each number in that range every actor computes the problem of finding perfect squares that are sum of consecutive squares. 
  - For example: if our N = 10^6 and k = 4, each actor is assigned to compute the above problem for 10^5 numbers. 

### Input

- N = 10^6 
- k = 4
- The --langversion:preview flag is required for the program to be able to access the akka framework for F#.


     dotnet fsi --langversion:preview lucas_pyramid.fsx 1000000 4
    
### Output
- The ratio of CPU time to REAL time is about 4 - 6 for problems bigger than 10^6 which indicates the usage of multiple cores for computation. 



    Real: 00:00:04.856, CPU: 00:00:24.965, GC gen0: 3432, gen1: 1, gen2: 0

### Largest Problem
##### Input
    dotnet fsi --langversion:preview lucas_pyramid.fsx 100000000 24
##### Output
    1
    9
    20
    25
    44
    76
    121
    197
    304
    353
    540
    856
    1301
    2053
    3112
    3597
    5448
    8576
    12981
    20425
    30908
    35709
    54032
    84996
    128601
    202289
    306060
    353585
    534964
    841476
    1273121
    2002557
    12602701
    52422128
    3029784
    82457176
    3500233
    5295700
    34648837
    8329856
    19823373
    29991872
    Real: 00:18:06.164, CPU: 01:28:14.003, GC gen0: 717911, gen1: 119, gen2: 10