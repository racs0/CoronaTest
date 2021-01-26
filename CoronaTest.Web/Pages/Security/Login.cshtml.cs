using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using CoronaTest.Core.Contracts;
using CoronaTest.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoroneTest.Web.Pages.Security
{
    public class LoginModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISmsService _smsService;

        [BindProperty]
        [Required(ErrorMessage = "Die {0} ist verpflichtend")]
        [StringLength(10, ErrorMessage = "Die {0} muss genau 10 Zeichen lang sein!", MinimumLength = 10)]
        [DisplayName("SVNr")]
        public string SocialSecurityNumber { get; set; }
        
        [BindProperty]
        [Required(ErrorMessage = "Die {0} ist verpflichtend")]
        [StringLength(16, ErrorMessage = "Die {0} muss zw. {1} und {2} Zeichen lang sein!", MinimumLength = 5)]
        [DisplayName("Handynummer")]
        public string Mobilenumber { get; set; }

        public LoginModel(
            IUnitOfWork unitOfWork, 
            ISmsService smsService)
        {
            _unitOfWork = unitOfWork;
            _smsService = smsService;
        }

      
    }
}
