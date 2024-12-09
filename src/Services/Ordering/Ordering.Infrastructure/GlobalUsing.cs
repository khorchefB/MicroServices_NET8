﻿global using Microsoft.AspNetCore.Http;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.ChangeTracking;
global using Microsoft.EntityFrameworkCore.Diagnostics;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.DependencyInjection.Extensions;
global using Ordering.Domain.Abstractions;
global using Ordering.Domain.Models;
global using Ordering.Domain.ValueObjects;
global using Ordering.Infrastructure.Data;
global using Ordering.Infrastructure.Data.Interceptors;
global using System.Security.Claims;