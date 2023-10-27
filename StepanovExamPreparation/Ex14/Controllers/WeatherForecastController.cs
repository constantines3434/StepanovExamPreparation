using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text.Json;

namespace Ex14.Controllers
{   
    [Route("[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private List<Data> _datas;   //список рабочих данных
        private string _pathToJSON; //файл с данными Data
        public DataController()
        {
            //можно заменить на путь к json файлу
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
            var config = new ConfigurationBuilder().AddJsonFile(filePath).Build();
            _pathToJSON = config["Path"];

            //файл существует
            if(System.IO.File.Exists(_pathToJSON))
            {
                string jsonString = System.IO.File.ReadAllText(_pathToJSON);
                List<Data> datas = JsonSerializer.Deserialize<List<Data>>(jsonString);

                if (datas != null)
                    _datas = datas;
                else
                    Console.WriteLine("File with data is null");
            }
            else
                Console.WriteLine("File not exist");
        }

        /// <summary>
        /// Get All Elements
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("datas")]
        public List<Data> GetDatas()
        {
            return _datas;
        }

        /// <summary>
        /// Get element from Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [HttpGet, Route("datas/{id}")]
        public Data GetDataById(int id)
        {
            var data = _datas.FirstOrDefault(x => x.Id == id);
            if(data == null)
                throw new Exception("data with this Id is null");
            return data;
        }

        /// <summary>
        /// Add element in Data
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="exchangeRates"></param>
        [HttpPost, Route("AddDatas/{Name}")]
        public void AddData(int id, string name, double exchangeRates)
        {
            Data data = new Data { Id = id, Name = name, ExchangeRates = exchangeRates };

            _datas.Add(data);
            string JSONString = JsonSerializer.Serialize(_datas);
            System.IO.File.WriteAllText(_pathToJSON, JSONString);    
        }
    }
}