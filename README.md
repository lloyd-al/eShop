# eShop
Build e-commerce application based on microservice architecture, clean code architecture. 
Building Microservices using Asp.Net Web API, Docker, RabbitMQ, Ocelot API Gateway, MongoDB, Redis, SqlServer

## MongoDB Set-up


` docker pull mongo `

` docker run -d --name mongodb  -p 27017:27017 -e MONGO_INITDB_ROOT_USERNAME=mongoadmin -e MONGO_INITDB_ROOT_PASSWORD=secret mongo `

```
-d                                       - runs the container in background;
--name mongodb                           - defines a friendly name for the container;
-p 27888:27017                           - declares that the local port 27888 is mapped to the internal 27017 port;
-e MONGO_INITDB_ROOT_USERNAME=mongoadmin - sets the root username (-e sets the environment variables);
-r MONGO_INITDB_ROOT_PASSWORD=secret     - sets the root password;
mongo                                    - name of the image to run;
```

` docker exec -it mongodb bash `

` mongo --host localhost -u mongoadmin -p secret --authenticationDatabase admin `


## Redis Set-up

` docker pull redis `

` docker run -d --name eshop-redis -p 6379:6379 redis `

` docker exec -it eshop-redis /bin/bash `

` redis-cli `


## RabbitMQ Set-up

` docker pull rabbitmq `

` docker run -d --hostname local-rabbit --name eshop-rabbit -p 15672:15672 -p 5672:5672 rabbitmq:3-management `

` http://localhost:15672 (guest/guest) `


#
Following packages need to be installed in each project


## Common Services for the enitre project

**Common.Core**

>Install-Package Microsoft.AspNetCore.Http.Features

>Install-Package Newtonsoft.Json

#
**Common.Infrastructure**

>Install-Package Microsoft.EntityFrameworkCore

>Install-Package MailKit

>Install-Package NLog

>Install-Package Microsoft.AspNetCore.Mvc.Versioning

>Install-Package Microsoft.AspNetCore.Mvc.Versioning.ApiExplorer

>Install-Package Microsoft.AspNetCore.Mvc.ApiExplorer

#
**Common.EventBusRabbitMQ**

>Install-Package RabbitMQ.Client

>Install-Package Newtonsoft.Json


## Catalog Project

**Features/Catalog.Core**

>Install-Package MongoDB.Driver
>
>Install-Package MongoDB.Bson


#
**Features/Catalog.Infrastructure**

>Install-Package Microsoft.EntityFrameworkCore

>Install-Package MongoDB.Driver

>Install-Package Microsoft.Extensions.Configuration

#
**Features/Catalog.Application**

>Install-Package AutoMapper.Extensions.Microsoft.DependencyInjection


#
**Features/Catalog.API**

>Install-Package Swashbuckle.AspNetCore

>Install-Package NLog.Config

>Install-Package Microsoft.AspNetCore.Mvc.Versioning


## Basket Project

**Features/Basket.Core**

>Install-Package StackExchange.Redis


#
**Features/Basket.Infrastructure**

>Install-Package Microsoft.EntityFrameworkCore

>Install-Package Microsoft.Extensions.Configuration

>Install-Package Microsoft.Extensions.Options

>Install-Package Newtonsoft.Json

>Install-Package StackExchange.Redis


#
**Features/Basket.Application**

>Install-Package AutoMapper.Extensions.Microsoft.DependencyInjection


#
**Features/Basket.API**

>Install-Package Swashbuckle.AspNetCore

>Install-Package NLog.Config

>Install-Package Microsoft.AspNetCore.Mvc.Versioning

>Install-Package AutoMapper.Extensions.Microsoft.DependencyInjection


