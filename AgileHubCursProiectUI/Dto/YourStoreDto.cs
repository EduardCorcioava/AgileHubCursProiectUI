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
    class YourStoreDto
    {
        public static List<YourStoreDto> LoadValuesFromJsonFile()
        {
            var myFile = @"C:\Users\CE062342\source\repos\AgileHubCursProiectUI\AgileHubCursProiectUI\YourStoreTestData.json";

            try
            {
                using (var reader = new StreamReader(myFile))
                {
                    var json = reader.ReadToEnd();
                    var config = JObject.Parse(json).SelectToken("YourStoreDto").ToString();
                    var myTestDataList = JsonConvert.DeserializeObject<List<YourStoreDto>>(config);

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
