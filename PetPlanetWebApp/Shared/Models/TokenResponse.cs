﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPlanetWebApp.Shared.Models
{
    public class TokenResponse
    {
        public string TokenType { get; set; }
        public int ExpiresIn { get; set; }
        public string AccessToken { get; set; }
    }
}
