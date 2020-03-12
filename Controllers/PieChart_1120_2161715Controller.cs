using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication_Core_mvc.Data;

namespace WebApplication_Core_mvc.Controllers
{
   
    public class PieChart_1120_2161715Controller : Controller
    {
        private readonly MvcMovieContext _context;
        public PieChart_1120_2161715Controller(MvcMovieContext context)
        {
            _context = context;
        }
        public IActionResult PieChart()
        {
            var creationsByLikes = _context.Class1s.Include(c => c.name).ToList();
            return View();
        }
       // [HttpGet]
        //public JsonResult PieChartDraw(string sDate, string eDate, string gameCode)
        //{
        //    try
        //    {
        //        List<PieData> pieDatas = new List<PieData>();
        //        var startDate = DateTime.Today;
        //        var endDate = DateTime.Today.AddDays(1);
        //        if (sDate != null && eDate != null)
        //        {
        //            startDate = DateTime.Parse(sDate);
        //            endDate = DateTime.Parse(eDate);
        //        }

        //        //Our Database
        //        var result = _context.GameBanks
        //            .Where(m => m.RequestDateTime >= startDate && m.RequestDateTime < endDate)
        //            .GroupBy(p => p.Status)
        //            .Select(g => new
        //            {
        //                Count = g.Count(),
        //                Status = g.Key
        //            }).ToList();

        //        var resultList = string.Empty;
        //        var nameList = new List<string>();

        //        foreach (var element in result)
        //        {
        //            resultList = resultList + element.Count + ",";

        //            switch (Convert.ToInt32(element.Status))
        //            {
        //                case 0:

        //                    nameList.Add("UNCERTAIN");
        //                    break;
        //                case 1:

        //                    nameList.Add("CONFIRM");
        //                    break;
        //                case 2:

        //                    nameList.Add("CANCEL");
        //                    break;
        //            }
        //        }

        //        PieData pieData1 = new PieData();
        //        pieData1.Count_ListRazer = resultList.TrimEnd(',').Trim().Split(',').ToList();
        //        pieData1.Status_ListRazer = nameList;
        //        pieDatas.Add(pieData1);
        //        //ViewBag.Count_List = resultList.TrimEnd(',').Trim();
        //        //ViewBag.Status_List =
        //        //    Newtonsoft.Json.JsonConvert.SerializeObject(nameList);



        //        //RAZER Database
        //        var resultRazer = _context.GameConfirmResponses
        //            .Where(m => m.requestDateTime >= startDate && m.requestDateTime < endDate)
        //            .GroupBy(p => p.status)
        //            .Select(g => new
        //            {
        //                Count = g.Count(),
        //                Status = g.Key
        //            }).ToList();

        //        var resultListRazer = string.Empty;
        //        var nameListRazer = new List<string>();

        //        foreach (var element in resultRazer)
        //        {
        //            resultListRazer = resultListRazer + element.Count + ",";

        //            switch (Convert.ToInt32(element.Status))
        //            {
        //                case 0:

        //                    nameListRazer.Add("UNCERTAIN");
        //                    break;
        //                case 1:

        //                    nameListRazer.Add("CONFIRM");
        //                    break;
        //                case 2:

        //                    nameListRazer.Add("CANCEL");
        //                    break;
        //            }
        //        }

        //        PieData pieData2 = new PieData();
        //        pieData2.Count_ListRazer = resultListRazer.TrimEnd(',').Trim().Split(',').ToList();
        //        pieData2.Status_ListRazer = nameListRazer;
        //        pieDatas.Add(pieData2);
        //        //ViewBag.Count_ListRazer = resultListRazer.TrimEnd(',').Trim();
        //        //ViewBag.Status_ListRazer =
        //        //    Newtonsoft.Json.JsonConvert.SerializeObject(nameListRazer);
        //        pieDatas = new List<PieData>();
        //      return new JsonResult(pieDatas);
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
      
    }

    public class PieData
    {
        public List<string> Count_ListRazer { get; set; }
        public List<string> Status_ListRazer { get; set; }
    }
}