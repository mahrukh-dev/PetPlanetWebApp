using Microsoft.AspNetCore.Mvc;
using PetPlanetWebApp.Server.Services;
using PetPlanetWebApp.Shared.Utils;
using PetPlanetWebApp.Shared.Utils;

namespace PetPlanetWebApp.Server.Controllers
{
    public class PetfinderAuthController : Controller
    {
        private readonly PetfinderAuthService _petfinderAuthService;

        public PetfinderAuthController(PetfinderAuthService petfinderAuthService)
        {
            _petfinderAuthService = petfinderAuthService;
        }

        public async Task<IActionResult> YourAction()
        {
            try
            {
                string accessToken = await _petfinderAuthService.GetAccessTokenAsync();

                // Use the accessToken as needed (e.g., for subsequent API requests)
                // ...

                Variables.TOKEN = accessToken;

                return Ok($"Access Token: {accessToken}");
            }
            catch (Exception ex)
            {
                // Handle exceptions
                return StatusCode(500, "Error fetching access token from Petfinder API");
            }
        }
    }

}
