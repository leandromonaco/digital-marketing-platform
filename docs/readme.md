Install Docker Desktop: https://www.docker.com/products/docker-desktop
Use Linux Containers
docker run -e "ACCEPT_EULA=Y" --name "sw-sql" -e "SA_PASSWORD=S0ftw4r3W0rk3r" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest 


Update Model after DB Schema changes

1 - Install EF command
    dotnet tool install -g dotnet-ef --version 3.0.0
2 - Update EF command (if required)
    dotnet tool update -g dotnet-ef --version 3.1.4
3 - Navigate C:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Model
4 - Update EF Model Classes
    dotnet ef dbcontext scaffold "Data Source=localhost,1433;Initial Catalog=DigitalMarketing;Persist Security Info=True;User ID=sa;Password=S0ftw4r3W0rk3r" Microsoft.EntityFrameworkCore.SqlServer -o Database -f
	
	
libwebp-1.1.0-windows-x64
https://developers.google.com/speed/webp/docs/using

cd D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Tools\WebP_Converter\tools
cwebp -q 80 "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\wwwroot\tenants\arystec\images\arystec-cover.jpg" -o "D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\wwwroot\tenants\arystec\images\arystec-cover.webp"

https://github.com/dotnet/tye/blob/master/docs/README.md
https://github.com/dotnet/tye/blob/master/docs/reference/schema.md
https://github.com/dotnet/tye/blob/master/docs/getting_started.md

Check Version
tye --version

dotnet tool install -g Microsoft.Tye --verson "0.2.0-alpha.20258.3"
dotnet tool update -g Microsoft.Tye --version "0.5.0-alpha.20555.1"


cd D:\Build\AgilityManager\DigitalMarketing
tye build

Create tye YAML File
tye init

Debug mode
tye build -v Debug