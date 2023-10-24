# Cron-parser

## Folders structure

### /src

this folder contains the dotnet source code and it includes a console app and a unit test project for testing the main Parse method 


### /bin

this folder  contains the self-contained compiled dotnet code. This means you don't need dotnet sdk or runtime to run it.


## How to run the parser

### dotnet sdk not installed:
- head to the bin folder
- head into the appropriate folder based on your OS architecture
- run _./cron-parser "args"_ -> i.e.: _./cron-parser "*/15 0 1,15 * 1-5 /usr/bin/find"_


### dotnet sdk installed:
 - head to the src/cron-parser.console folder

 - run _dotnet run "args"_  -> i.e.: _dotnet run "*/15 0 1,15 * 1-5 /usr/bin/find"_

 this command will compile the source code and run it with the args provided




## Running tests

### dotnet sdk not installed:
- run the _./run-tests.sh_ ( or _bash ./run-tests.sh_ if the script doesn't have execution permissions) script inside the src folder (this will spin up a dotnet 6 container and run the tests)


### dotnet sdk installed:
- head to src/cron-parser.tests
- run _dotnet test_

