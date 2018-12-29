FROM 346design/dotnet.corert

LABEL maintainer="346.design"

WORKDIR /app

EXPOSE 80

COPY src/Akalink/dist .

ENTRYPOINT ./akalink
