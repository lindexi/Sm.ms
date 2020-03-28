# Sm.ms

| Build | NuGet |
|--|--|
|![](https://github.com/lindexi/Sm.ms/workflows/.NET%20Core/badge.svg)|[![](https://img.shields.io/nuget/v/smms)](https://www.nuget.org/packages/smms)|

## Getting Started

NuGet install:

```csharp
dotnet add package smms 
```

Create a Smms object and set the api token

```csharp
            var smms = new Smms("xxx");
```

And you can generate the api token form [https://sm.ms/home/apitoken](https://sm.ms/home/apitoken)

And then you can upload the image and receive the result string

```csharp
            var file = new FileInfo(@"F:\lindexi\logo.png");
            Console.WriteLine(await smms.UploadImage(file.OpenRead(), file.Name));
```
