using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileHubCursProiectUI.Dto
{
    class ReserveHotelDto
    {
        public static List<ReserveHotelDto> LoadValuesFromJsonFile()
        {
            var myFile = @"C:\Users\CE062342\source\repos\AgileHubCursProiectUI\AgileHubCursProiectUI\ReserveHotelTestData.json";

            try
            {
                using (var reader = new StreamReader(myFile))
                {
                    var json = reader.ReadToEnd();
                    var config = JObject.Parse(json).SelectToken("ReserveHotelDto").ToString();
                    var myTestDataList = JsonConvert.DeserializeObject<List<ReserveHotelDto>>(config);

                    return myTestDataList;
                }

            }
            catch (Exception)
            {
                throw new Exception($"There's a problem with file {myFile}");
            }
        }
    }
}
