OS=osx
ARCH=arm64
dotnet publish  --sc --os $OS -a $ARCH -o "../bin/$OS-$ARCH" cron-parser.console/cron-parser.console.csproj

OS=osx
ARCH=x64
dotnet publish  --sc --os $OS -a $ARCH -o "../bin/$OS-$ARCH" cron-parser.console/cron-parser.console.csproj

OS=linux
ARCH=x64
dotnet publish  --sc --os $OS -a $ARCH -o "../bin/$OS-$ARCH" cron-parser.console/cron-parser.console.csproj

OS=linux
ARCH=arm
dotnet publish  --sc --os $OS -a $ARCH -o "../bin/$OS-$ARCH" cron-parser.console/cron-parser.console.csproj

OS=linux
ARCH=arm64
dotnet publish  --sc --os $OS -a $ARCH -o "../bin/$OS-$ARCH" cron-parser.console/cron-parser.console.csproj

OS=win
ARCH=x64
dotnet publish  --sc --os $OS -a $ARCH -o "../bin/$OS-$ARCH" cron-parser.console/cron-parser.console.csproj

OS=win
ARCH=x86
dotnet publish  --sc --os $OS -a $ARCH -o "../bin/$OS-$ARCH" cron-parser.console/cron-parser.console.csproj
