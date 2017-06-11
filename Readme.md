1. NodeJS
	- Javascript - dynamic, interpreted, prototypical inheritance
	- Web browser vs server
	- Standard library

2. Code
	- NodeJS package manager
	- NodeJS module system
	- NodeJS web framework - express.js
	- Testing a NodeJS app
		docker-compose run --rm node
		`npm install express`
		`npm install express --save`
		Show hello, world
		Change to hello dotnet user group
		Refresh - still hello, world
		restart - refresh
		add test for parameter
		npm install mocha chai chai-http --save-dev
		Show mocha/chai in devDependencies
		run tests - watch failure
		Fix code and rerun tests
	- build docker image and show running

3. Dotnet Core
	- History:
		- C#, Mono, Xamarin, MS acquiring Xamarin, containers, multi-platform, breaking .NET apart to make it more modular, dotnet Core
	- Language - compiled, static, classic inheritance

4. Code
	- dotnet CLI / VS Code
	- NuGet package manager / new csproj format
	- Dotnet web framework - ASP.NET Core
	- Testing a dotnet core app

		`docker-compose run --rm vscode`
		go view -> integrated terminal
		`dotnet new webapi`
		- show new csproj format with package references included
		`dotnet run`
		- show app running in browser
		- create test project (xunit) `dotnet new xunit`
		- add reference to main project `dotnet add reference ../app/app.csproj`
		- add reference to ASP.NET Core test package `dotnet add package Microsoft.AspNetCore.TestHost`
		- run tests
		- fix failing test and rerun

	- build docker image and show running