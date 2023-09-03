using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Clase_1.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;
    [BindProperty]
    public Form Form {get; set;}

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        var parametro = Request.Query["parametros"];
        Form = new Form();
        Form.Mail=parametro;
        Form.Password="1234";

    }

    public IActionResult OnPost(){
        if (!ModelState.IsValid){
            return Page();
        }
        var formValues = Form;
        return RedirectToPage("/index");
        }
}

