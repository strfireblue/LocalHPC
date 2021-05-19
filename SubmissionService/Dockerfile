#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["SubmissionService/SubmissionService.csproj", "SubmissionService/"]
RUN dotnet restore "SubmissionService/SubmissionService.csproj"
COPY . .
WORKDIR "/src/SubmissionService"
RUN dotnet build "SubmissionService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SubmissionService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SubmissionService.dll"]