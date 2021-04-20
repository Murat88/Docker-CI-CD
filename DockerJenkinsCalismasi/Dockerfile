#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env  #base þmage olarak .net core sdk kullanýlacak
WORKDIR /app #container içerisinde çalýþacaðýmýz klasörü temsil eder.

COPY *.csproj .  #dockerfile'ýn olduðu dizindeki .csproj dosyasýný app klasörünün içine kopyaladým

RUN dotnet restore #dependincies altýndaki bütün paketlerin indirilmesini saðlar.

COPY . ./ # içersinde bulunduðum klasördeki bütün dosyalarý app klasörünün altýnda taþýdým.

RUN dotnet publish --no-restore -c Release -o out   #release olarak publish et ve out klasörünün içerisine çýkar . Restore yapma çünkü zaten yaptýk.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/out . # app/out dizinindeki dosyalarýn hepsini çalýþma dizinine alýyoruz
ENTRYPOINT ["dotnet","DockerJenkinsCalismasi.dll"] #dotnet exe'sine DockerJenkinsCalismasi.dll 'i parametre olarak gönderiyoruz.