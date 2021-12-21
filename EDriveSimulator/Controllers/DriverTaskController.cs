using EDriveSimulator.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace EDriveSimulator.Controllers
{
    [ApiController]
    [Route("dataexchange/api/v1/performances/tasks")]
    public class DriverTaskController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<DriverTask> Get(int trainNumber, string date)
        {
            var random = new Random();
            var ptCarslist = new List<string>() { "100", "110", "120", "130", "140", "150", "160", "180", "170", "190", "200", "LK", "FSN", "FGSP", "FPP" };
            var driverslist = new List<string>() { "Liam", "Noah", "William", "James", "Benjamin", "Lucas", "Henry", "Alexander", "Lucy", "Amanda", "Sam", "Ali", "David", "Simon", "Rebecca", "ELLIS APERS", "CHRIS DE SAMBER", "JOREN LEMAIRE", "CHRIS DE SAMBER", "JURGEN DESAEGHER" };
            var prefixList = new List<string>() { "EM", "ME", "SE", "LT", "TI", "", "", "", "", "", "", "" };
            var missionList = new List<string>() { "HLP", "AFREL", "DRIVE" };
            var idfList = new List<string>() { "903572006", "833680002", "903572006", "0491358384", "918288002", "524085016", "912063005", };
            var depoList = new List<string>() { "FN", "FPP", "FDR", "LK" };
            var performanceList = new List<string>() { "0030", "0080", "0354", "0010", "0020", "0032", "0070", "1245", "0124", "0012", "0090", "0100", "0300", "0200", "0001", "0003", "01460", "0060", "0054", "0071", "0032", "0045", "0064", "0900" };
            var phoneNumberList = new List<string>() { "+32200169536", "+32569845475", "+32485659874", "+32485574568", "+32485523978", "+324855478962", "+32485301564", "+32465478454" };
            var data = new List<DriverTask>();

            for (int i = 0; i < 4; i++)
            {
                data.Add(
                     new DriverTask()
                     {
                         BeginHour = DateTime.Now.AddHours(-2),
                         EndHour = DateTime.Now.AddHours(-1),
                         Depot = depoList[random.Next(depoList.Count)],
                         IdfNumber = idfList[random.Next(idfList.Count)],
                         Mission = missionList[random.Next(missionList.Count)],
                         PerformanceNumber = performanceList[random.Next(performanceList.Count)],
                         PhoneNumber = phoneNumberList[random.Next(phoneNumberList.Count)],
                         Status = "TOSTART",
                         PtcarFrom = ptCarslist[random.Next(ptCarslist.Count)],
                         PtcarTo = ptCarslist[random.Next(ptCarslist.Count)],
                         TrainDriverName = driverslist[random.Next(driverslist.Count)],
                         TrainNumber = trainNumber,
                         TrainNumberPrefix = prefixList[random.Next(prefixList.Count)],
                         TrainNumberSuffix = prefixList[random.Next(prefixList.Count)]
                     }
                    );
            }
            return data;
        }
    }
}
