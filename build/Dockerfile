From microsoft/dotnet
EXPOSE 80,443,5000,5001
WORKDIR /app
COPY ./HomeProject/bin/Debug/netcoreapp3.0/publish/ .
RUN cd ./HomeProject/bin/Debug/netcoreapp3.0/publish/
ENTRYPOINT ["dotnet", "HomeProject.dll","--urls='https://*:5001'"]