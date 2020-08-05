FROM mcr.microsoft.com/dotnet/core/sdk:3.1 as build-env
WORKDIR /services/demo

COPY *.sln  ./
COPY demo-microservices/  ./demo-microservices
COPY demo-microservices-test/  ./demo-microservices-test
RUN dotnet restore
RUN dotnet test
