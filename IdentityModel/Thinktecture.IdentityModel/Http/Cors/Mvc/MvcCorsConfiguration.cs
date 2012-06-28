﻿/*
 * Copyright (c) Dominick Baier & Brock Allen.  All rights reserved.
 * see license.txt
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Thinktecture.IdentityModel.Http.Cors.Mvc
{
    public class MvcCorsConfiguration : CorsConfiguration
    {
        static MvcCorsConfiguration()
        {
            Configuration = new MvcCorsConfiguration()
            {
                ResourceNameIncludesActionName = true
            };
        }

        public static MvcCorsConfiguration Configuration { get; set; }
        public bool ResourceNameIncludesActionName { get; set; }
    }
}
