using bancomat.app.Data.Repository.AccountToRepo;
using bancomat.app.Data.Repository.BalanceActionRepo;
using bancomat.app.Data.Repository.BalanceRepo;
using bancomat.app.Models;
using bancomat.app.Models.Transfer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Security.Claims;






namespace bancomat.app.Controllers
{
    public class BancomatController : Controller
    {
        private readonly ILogger<BancomatController> _logger;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IBalanceRepository _balanceRepository;
        private readonly IAuditItemsRepository _auditItemsRepository;
        private readonly IAccountToRepository _accountToRepository;

        public BancomatController(UserManager<IdentityUser> userManager,
                                  ILogger<BancomatController> logger,
                                  IBalanceRepository balanceRepository,
                                  IAuditItemsRepository auditItemsRepository,
                                  IAccountToRepository accountToRepository )
        {
            _userManager = userManager;
            _logger = logger;
            _balanceRepository = balanceRepository;
            _auditItemsRepository = auditItemsRepository;
            _accountToRepository = accountToRepository;
        }

       

      
        [HttpPost]
        public IActionResult TransferTo([FromBody] AccountTo model)
        {
            //AspNetUserContext ac = new AspNetUserContext();
            //AspNetUserModel userEmail = (AspNetUserModel)ac.userDetails.Where(ue => ue.Email == model.Username);
            //Console.WriteLine(userEmail);
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userBalance = _balanceRepository.GetByUserId(userId);
            var balanceTo = _balanceRepository.GetByUserId(model.UserId);
            userBalance.Amount -= model.Amount; 
            balanceTo.Amount += model.Amount;
            _balanceRepository.UpdateUserBalance(userBalance);
            _balanceRepository.UpdateUserBalance(balanceTo);

            return Ok();
        }
        public IActionResult Balance()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userBalance = _balanceRepository.GetByUserId(userId);
            if (userBalance == null)
            {
                userBalance = new UserBalance()
                {
                    Amount = 0,
                    UserId = userId
                };
                _balanceRepository.CreateUserBalance(userBalance);
            }
            return View(userBalance);
        }

        [HttpPost]
        public IActionResult ChangeBalanceValue([FromBody] ChangeBalanceModel model)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userBalance = _balanceRepository.GetByUserId(userId);
            var auditItem = new AuditItem()
            {
                InitAmount = userBalance.Amount,
                UserId = userId
            };

            if (model.ToIncrement && model.Amount <= 4000)
            {
                userBalance.Amount += model.Amount;
                auditItem.NewAmount = userBalance.Amount;
                auditItem.Details = "Deposit was done.";
            }
            else if (!(model.ToIncrement) && model.Amount <= 500)
            {
                userBalance.Amount -= model.Amount;
                auditItem.NewAmount = userBalance.Amount;
                auditItem.Details = "Withdraw was done.";
            }
            _balanceRepository.UpdateUserBalance(userBalance);
            _auditItemsRepository.InsertAuditItem(auditItem);
            return Ok();
        }
        public IActionResult Deposit()
        {
            return View();
        }

        public IActionResult Withdraw()
        {
            return View();
        }
        public IActionResult TransferTo()
        {
            return View();
        }
    }
}

//var userName = User.FindAll(ClaimTypes.Name);
//Account account = new Account
//{
//    Email = userName.ToString()


//};
//_accountToRepository.CreateAccountTo(account);
//return Ok();
