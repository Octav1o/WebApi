using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Base;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers;

[ApiController, Route("api/[controller]")]
public class BorrowController : ApiControllerBase<Borrow>
{
    public BorrowController(DataContext context, ILogger<Borrow> logger) : base(context, logger)
    {

    }
}