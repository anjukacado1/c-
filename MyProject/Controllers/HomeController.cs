using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyProject.Models;
using Microsoft.Data.SqlClient;

namespace MyProject.Controllers;



public class HomeController : Controller
{
    SqlConnection con= new SqlConnection();
    SqlCommand com= new SqlCommand();

    SqlDataReader? dr;

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Contactus()
    {
        return View();
    }

    public IActionResult Product()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }
    

    void ConnectionString(){
    con.ConnectionString ="data source=192.168.1.240\\SQLEXPRESS; database=cad_Farmkart; User Id=CADBATCH01; Password=CAD@123pass; TrustServerCertificate=True";
    } 
    [HttpPost]

    public IActionResult VerifyLogin(LoginModel lmodel){
        ConnectionString();
        con.Open();
        com.Connection=con;
        com.CommandText="select * from Farmkart_login where username='"+lmodel.username+"' and Password='"+lmodel.password+"' ";
        dr=com.ExecuteReader();

        if(dr.Read()){
            con.Close();
            return View("create");

        }
        else{
              con.Close();
            return View("Error");


        }
       
    }
    [HttpGet]
    public IActionResult Register()
    {
        return View();

    }

   

 [HttpPost]

    public IActionResult Verifyregister(RegisterModel rmodel)
    {
        ConnectionString();
        con.Open();
        com.Connection=con;
        com.CommandText= "insert into Farmkart_reg(username,email,password) values('"+rmodel.username+"', '"+rmodel.email+"', '"+rmodel.password+"');";

        int anjuka=com.ExecuteNonQuery();

        if(anjuka>0){
            con.Close();
            return RedirectToAction("login");

        }
        else{
              con.Close();
            return RedirectToAction("Error");


        }
       
    }
    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

