﻿using Dreamer.Application.Features.Documents;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Dreamer.Aura.Api.Controllers.v1
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class ClientDocumentController : BaseApiController
    {
        public ClientDocumentController(IMediator mediator) : base(mediator)
        {

        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id) => Ok(await Mediator.Send(new GetClientDocuments { ClientUcid = id }));
    }
}
