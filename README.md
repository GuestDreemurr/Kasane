## Kasane
Kasane is a experimental reimplementation of the REST API for the Uplay Wii U App, as well as Ubisoft's "Online Config Service".

## Hosting
1. Clone the repository.
2. Install [.NET 10 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/10.0) if you haven't already.
3. CD into the folder you cloned the repo into and run "dotnet run"
4. Configure a DNS [server](https://github.com/MH-Oldschool/mhosdns) to redirect `onlineconfigservice.ubi.com` `static8.cdn.ubi.com` `static2.cdn.ubi.com` `uplay-avatars.s3.amazonaws.com` to the IP that is hosting Kasane
5. Set your Wii U's Primary DNS to the IP of the server running the DNS server.

## Configuration
There is very little to configure besides the port, you must proxy the port you set to port 80 using nginx or another proxy in order for the Uplay App to access it.

## Why is there no Database?
This is a very experimental project and I currently have no way of **properly** doing authentication without being able to get service tokens from Pretendo Network due to how Ubisoft did login on Uplay for the Wii U (see https://github.com/PretendoNetwork/account/issues/202). So a database would be pretty much useless.

