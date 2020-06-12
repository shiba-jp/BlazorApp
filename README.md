# BlazorApp

## How to make this solution

```
//空のソリューション作成
BlazorApp> dotnet new sln

//プロジェクト作成
//認証方式：アプリ内の認証方式
BlazorApp> mkdir src
BlazorApp> dotnet new blazorserver -au individual -o .\src\ -n BlazorApp

//テストプロジェクト作成
BlazorApp> mkdir test
BlazorApp> dotnet new xunit -o .\test\ -n BlazorApp.Test

//ソリューションにプロジェクトを追加
BlazorApp> dotnet sln add .\src\BlazorApp.csproj
BlazorApp> dotnet sln add .\test\BlazorApp.Test.csproj

//テストプロジェクトにソースプロジェクトの参照を追加
BlazorApp> dotnet add .\test\BlazorApp.Test.csproj reference .\src\BlazorApp.csproj
```

## Build

```
BlazorApp> dotnet build BlazorApp.sln

or 

BlazorApp\src> dotnet build
BlazorApp\test> dotnet build
```

## Run

```
BlazorApp\src> dotnet run
```

Access to http://localhost:5000

## Test

```
BlazorApp\test> dotnet test
```

