FROM mcr.microsoft.com/dotnet/core/sdk:3.1.302-alpine3.12 as build-env

WORKDIR /services/demo

COPY . ./

RUN dotnet restore \ 
    && dotnet test