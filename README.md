# dotnet-demo-service

A tiny ASP.NET (net8.0) web service for **testing ci-bootstrap end to end**.

It exposes one endpoint:

```
GET /greeting?name=<name>   ->   {"message": "Hello, <name>!"}
```

This repo intentionally has **no CI/CD workflows** — point the CI agent (then the CD
agent) at it to generate them. A correct `Dockerfile` is included so the built image
actually runs `DotnetService.dll` on port 8080 and the deploy serves a real response.

```bash
dotnet test                              # build + tests
dotnet run --project src/DotnetService   # run locally
```
