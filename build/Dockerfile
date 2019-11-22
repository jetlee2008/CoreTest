From mcr.microsoft.com/dotnet/core/aspnet:3.0 AS runtime
WORKDIR /app
COPY /root/CoreTest/HomeProject/bin/Debug/netcoreapp3.0/publish/ /app
RUN cd /app
ENTRYPOINT ["dotnet", "HomeProject.dll"]