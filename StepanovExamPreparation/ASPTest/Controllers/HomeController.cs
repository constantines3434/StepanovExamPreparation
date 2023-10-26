using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace ASPTest.Controllers
{
    public class HomeController : ControllerBase
    {
        private List<Model> _models;
        private string _pathToJson;

        public HomeController()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
            // получаем конфигурацию проекта где есть путь до файла
            var config = new ConfigurationBuilder().AddJsonFile(filePath).Build();
            _pathToJson = config["Path"]; // путь до файла со студентами, который мы указали в appsettings.json
    
            if (System.IO.File.Exists(_pathToJson)) //проверка если файл существует
            {
                string jsonString = System.IO.File.ReadAllText(_pathToJson); // считываем все данные с файла в виде json строки
                List<Model> models = JsonSerializer.Deserialize<List<Model>>(jsonString); // преобразуем json в список студентов

                if (models != null)
                {
                    _models = models;
                }
                else
                    throw new Exception("No models, list is null");
            }
            else // если файл не найден то Exception
            {
                throw new Exception("Can't find file");
            }
        }
        //с помощью тройного слэша можно делать автодокументирование в сваггере

        /// <summary>
        /// return list of students
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("models")]
        public List<Model> GetModel()
        {
            return _models;
        }

        [HttpGet, Route("models/{id}")]
        public Model GetModelById(int Id)
        {
            var model = _models.FirstOrDefault(s => s.Id == Id);
            if (model == null) throw new Exception("Model with id not found");
            return model;
        }

        [HttpPost, Route("AddModel/{Id}/{Name}")]
        public void AddModel(int Id, string Name, double value)
        {
            Model model = new Model{ Id = Id, Name = Name, ExchangeRate = value }; //создаем нового студента 

            _models.Add(model); //добавляем его в наш список
            string json = JsonSerializer.Serialize(_models); // делаем из списка json строку
            System.IO.File.WriteAllText(_pathToJson, json); //перезаписываем json в файл
        }
    }
}
