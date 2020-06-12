To build and test the image:

```
docker build . -t sqlitetest
docker run sqlitetest
```

It should print:

```
Opening connection...
Opened connection.
Created table.
```

The program works when the base Docker image is changed to `mcr.microsoft.com/dotnet/core/sdk:3.1-alpine3.11`
