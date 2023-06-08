using Microsoft.AspNetCore.Mvc;
using Task_19.Model.Data;
using Task_19.Model;
using Task_19.Views.Home;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Task_19.Controllers
{
    public class HomeController : Controller
    {
        private readonly ConnectionDb db = new ConnectionDb("DbConnection"); 


        public IActionResult Index()
        {
            return View(db.DatabaseData.ToList());
        }

        public IActionResult Info(Personalities person)
        {
           
            var list = db.DatabasePersonalData.ToList();

            PersonalData personalData = new PersonalData();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ID_Personalitie == person.ID)
                {
                    personalData = list[i];
                    break;
                }
            }

            if (personalData.Description == null) 
            {
                personalData.Description = "Нет данных";
            }

            if (personalData.PhoneNumber == null)
            {             
                personalData.PhoneNumber = "Нет данных";         
            }

            if (personalData.Address == null)
            {
                personalData.Address = "Нет данных";
            }

            return View((person, personalData));
        }


 

    }
}
