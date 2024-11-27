using Microsoft.AspNetCore.Mvc;
using NewsManagementSystem.APIs.Common;
using NewsManagementSystem.Infrastructure.Models;

namespace NewsManagementSystem.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class AdminFindManyArgs : FindManyInput<Admin, AdminWhereInput> { }