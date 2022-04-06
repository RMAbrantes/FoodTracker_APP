﻿namespace FoodTracker_APP.Areas.Identity.Pages.Account.Manage;

public class IndexModel : PageModel
{
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;

    public IndexModel(
        UserManager<User> userManager,
        SignInManager<User> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }
    
    public string Username { get; set; }
    
    [TempData]
    public string StatusMessage { get; set; }
    
    [BindProperty]
    public InputModel Input { get; set; }

    public class InputModel
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Username")]
        public string Username { get; set; }

        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Profile Picture")]
        public byte[] ProfilePicture { get; set; }
    }

    private async Task LoadAsync(User user)
    {
        var userName = await _userManager.GetUserNameAsync(user);
        var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
        var firstName = user.FirstName;
        var lastName = user.LastName;
        var profilePicture = user.ProfilePicture;

        Username = userName;
        Input = new InputModel
        {
            PhoneNumber = phoneNumber,
            Username = userName,
            FirstName = firstName,
            LastName = lastName,
            ProfilePicture = profilePicture
        };
    }

    public async Task<IActionResult> OnGetAsync()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
        {
            return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        }

        await LoadAsync(user);
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
        {
            return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        }

        if (!ModelState.IsValid)
        {
            await LoadAsync(user);
            return Page();
        }

        var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
        if (Input.PhoneNumber != phoneNumber)
        {
            var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
            if (!setPhoneResult.Succeeded)
            {
                StatusMessage = "Unexpected error when trying to set phone number.";
                return RedirectToPage();
            }
        }

        var firstName = user.FirstName;
        var lastName = user.LastName;
        if (Input.FirstName != firstName)
        {
            user.FirstName = Input.FirstName;
            await _userManager.UpdateAsync(user);
        }
        if (Input.LastName != lastName)
        {
            user.LastName = Input.LastName;
            await _userManager.UpdateAsync(user);
        }

        await _signInManager.RefreshSignInAsync(user);
        StatusMessage = "Your profile has been updated";
        return RedirectToPage();
    }
}
