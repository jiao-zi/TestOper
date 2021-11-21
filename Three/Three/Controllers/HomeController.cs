using Microsoft.AspNetCore.Mvc;
using Three.Services;

namespace Three.Controllers
{
    public class HomeController : Controller
    {
        //DI依赖注入，在StartUp里面注册了实例，注入参数的IClock注册的对应实例ChinaClock的实例
        public HomeController(IClock clock)
        { 
        
        }
    }
}
