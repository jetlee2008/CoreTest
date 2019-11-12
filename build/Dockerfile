From microsoft/dotnet
WORKDIR /app
COPY HomeProject/bin/Debug/netcoreapp3.0/publish/ /app
RUN cd ./HomeProject/bin/Debug/netcoreapp3.0/publish/
ENTRYPOINT ["dotnet", "HomeProject.dll","--urls='https://*:5001'"]