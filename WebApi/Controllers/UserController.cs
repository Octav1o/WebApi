using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Base;
using WebApi.Data;
using WebApi.Models;

namespace WebAppi.Controllers;

[ApiController, Route("api/[controller]")]

public class UserController : ApiControllerBase<User>
{
    public UserController(DataContext context, ILogger<User> logger) : base(context, logger)
    {

    }
}