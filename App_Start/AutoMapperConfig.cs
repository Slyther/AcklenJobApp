using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AcklenAveApplication.Entities;
using AcklenAveApplication.Models;
using AutoMapper;

namespace AcklenAveApplication.App_Start
{
    public class AutoMapperConfig
    {
        public static void ConfigureMappings()
        {
            Mapper.CreateMap<SecretPayloadRegisterModel, SecretPayload>();
            Mapper.CreateMap<SecretPayload, SecretPayloadDisplayModel>();
        }
    }
}