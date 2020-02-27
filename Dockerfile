# Get Base Image (Full .NET Core SDK)
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 
WORKDIR /usr/src/app
# Copy csproj and restore
COPY *.csproj ./
RUN dotnet restore
# Copy everything else and build
COPY . ./
RUN chmod +x ./start.sh
CMD ["/bin/sh", "start.sh"]