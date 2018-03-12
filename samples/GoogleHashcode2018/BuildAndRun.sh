#/bin/bash

dotnet restore ./Rides.Host/Rides.Host.csproj
dotnet restore ./Rides.Client/Rides.Client.csproj
dotnet build --no-restore ./Rides.Host/Rides.Host.csproj
dotnet build --no-restore ./Rides.Client/Rides.Client.csproj

# Run the 2 console apps in different windows

dotnet run --project ./Rides.Host/Rides.Host.csproj --no-build & 
sleep 10
dotnet run --project ./Rides.Client/Rides.Client.csproj --no-build &