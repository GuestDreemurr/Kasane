// controllerbase for all the profileservices controllers
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route(BaseURL)]
public class ProfileService : ControllerBase
{
    public const string BaseURL = "/UplayServices/UplayFacade/ProfileServicesFacadeRESTXML.svc/REST/"; 
}