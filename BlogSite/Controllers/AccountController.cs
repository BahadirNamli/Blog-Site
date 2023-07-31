using BlogSite.Data;
using BlogSite.Models;
using Microsoft.AspNetCore.Mvc;

public class AccountController : Controller
{
    private readonly AppDbContext _dbContext;

    public AccountController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(User user)
    {
        if (ModelState.IsValid)
        {
            // Parolayı hashleyerek güvenli bir şekilde saklamak için uygun yöntem kullanılmalıdır.
            // Bu örnek için basitlik için doğrudan şifreyi saklıyoruz. Bu güvenli değildir.
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            // Başarılı kayıt sonrası yönlendirme yapılabilir.
        }
        return View(user);
    }
}

