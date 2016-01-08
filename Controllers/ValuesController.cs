using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using AcklenAveApplication.Entities;
using AcklenAveApplication.Interfaces;
using AcklenAveApplication.Models;
using AutoMapper;

namespace AcklenAveApplication.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly ISecretPayloadRepository _secretPayloadRepository;

        public ValuesController(ISecretPayloadRepository secretPayloadRepository)
        {
            _secretPayloadRepository = secretPayloadRepository;
        }

        [HttpPost]
        // POST api/values
        public void Post([FromBody]SecretPayloadRegisterModel Payload)
        {
            var payload = Mapper.Map<SecretPayload>(Payload);
            _secretPayloadRepository.Create(payload);
        }
    }
}
