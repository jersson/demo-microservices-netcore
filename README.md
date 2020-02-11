# netcore-microservices-example
Goal: Use HTTP GET (without parameters) and error handling
Based on: https://github.com/jersson/microservices-templates
---
The goal here is coding a microservice template using dotnetcore and C#

**How to run the code** </br>

Run this command in the console:
```
dotnet run
```
If everything is okay, you'll see this message:
```
info: Microsoft.Hosting.Lifetime[0]
      Now listening on: https://localhost:5001
```

**How to test the code** </br>
You can also use the terminal :)

```
curl https://localhost:5001/books
```

You'll see:
```
{"status":"500","message":"internal error","type":"internal"}
```

Besides, in your original terminal (npm start), you'll see something like:
```
fail: demo_microservices_netcore.Api.Controllers.BooksController[0]
      Status:500, Message:Error here!, StackTrace:   at 
      ...
```

If you don't like the terminal you can use Postman :D

