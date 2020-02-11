# netcore-microservices-example
Objetivo: Usar HTTP GET (sin parámetros) y manejo de errores
Basado en: https://github.com/jersson/microservices-templates
---
El objetivo es programar un microservicio que luego será usado como plantilla de código. Se usará dotnetcore y C#.

**Cómo ejecutar el código** </br>

Puedes ejecutar este comando en la consola:
```
dotnet run
```
Si todo está bien, verás un mensaje como este:
```
info: Microsoft.Hosting.Lifetime[0]
      Now listening on: https://localhost:5001
```

**Cómo probar el código** </br>

También puedes usar la terminal para ejecutar el siguiente comando :)

```
curl https://localhost:5001/books
```

Verás lo siguiente:

```
{"status":"500","message":"internal error","type":"internal"}
```

Mientras que en la consola que ejecutaste 'npm start', verás algo como esto:
```
fail: demo_microservices_netcore.Api.Controllers.BooksController[0]
      Status:500, Message:Error here!, StackTrace:   at 
      ...
```

Si no te gusta la terminal, puedes usar Postman :D