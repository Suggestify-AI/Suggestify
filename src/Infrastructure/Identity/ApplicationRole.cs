using Microsoft.AspNetCore.Identity;
using Suggestify.WebUI.Shared.Authorization;

namespace Suggestify.Infrastructure.Identity;

public class ApplicationRole : IdentityRole
{
    public Permissions Permissions { get; set; }
}
