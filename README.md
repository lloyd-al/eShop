# eShop
Build e-commerce application based on microservice architecture, clean code architecture. 
Building Microservices using Asp.Net Web API, Docker, RabbitMQ, Ocelot API Gateway, MongoDB, Redis, SqlServer


Following packages need to be installed in each project

#

**Common.Core**

>Install-Package Microsoft.AspNetCore.Http.Features

>Install-Package Newtonsoft.Json

#
**Common.Infrastructure**

>Install-Package Microsoft.EntityFrameworkCore

>Install-Package MailKit

>Install-Package NLog

#
**Features/Catalog.Core**

>Install-Package MongoDB.Driver
>
>Install-Package MongoDB.Bson


#
**Features/Catalog.Infrastructure**

>Install-Package Microsoft.EntityFrameworkCore

>Install-Package MongoDB.Driver


#
**Features/Catalog.Application**

>Install-Package AutoMapper.Extensions.Microsoft.DependencyInjection


#
**Features/Catalog.API**

>Install-Package Swashbuckle.AspNetCore

>Install-Package NLog.Config

>Install-Package Microsoft.AspNetCore.Mvc.Versioning
