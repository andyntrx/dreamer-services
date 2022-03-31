﻿using Dreamers.Application.Encounters;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Dreamers.Aura.Api.Controllers.v1
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class ClientEncounterController :  BaseApiController
    {

        public ClientEncounterController(IMediator mediator) : base(mediator)
        {

        }

        [HttpGet("{ucid}")]
        public async Task<IActionResult> Get(Guid ucid)
        {
            var encounter = await Mediator.Send(new GetClientEncounter { ClientUcid = ucid });
            return Ok(encounter);
        }
    }
}