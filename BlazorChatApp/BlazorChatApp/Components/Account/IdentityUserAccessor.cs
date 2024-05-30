using BlazorChatApp.DataAccess.DbModels.Identity.Tables;
using Microsoft.AspNetCore.Identity;

namespace BlazorChatApp.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<US_User> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<US_User> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
