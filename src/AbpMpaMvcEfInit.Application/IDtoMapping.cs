﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpMpaMvcEfInit
{
   internal interface IDtoMapping
    {
        void CreateMapping(IMapperConfigurationExpression mapperConfig);
    }
}
