﻿namespace PetPlanetWebApp.Models
{
    public class TokenResponse
    {
        public string? TokenType { get; set; }
        public int ExpiresIn { get; set; }
        public string? AccessToken { get; set; }
    }
}
