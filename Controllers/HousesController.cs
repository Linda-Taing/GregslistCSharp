using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GregslistCSharp.Controllers;

[ApiController]
[Route("api/[controller]")]


public class HousesController : ControllerBase
{
    private readonly HousesService housesService;
    public HousesController(HousesService housesService)
    {
        this.housesService = housesService;
    }
}
