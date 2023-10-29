using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Ex18.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private List<Data> _datas;
        private string PathXML;

        public DataController()
        {
            PathXML = "data.xml";

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Root));
            using (FileStream fs = new FileStream(PathXML, FileMode.OpenOrCreate))
            {
                Root root = (Root)xmlSerializer.Deserialize(fs);
                _datas = root.Datas;
            }
        }

        [HttpGet, Route("Datas")]
        public List<Data> GetDatas()
        {
            return _datas;
        }

        [HttpGet, Route("Datas/{id}")]
        public Data GetDataById(int id)
        {
            var data = _datas.FirstOrDefault(x => x.Id == id);
            if (data == null)
                throw new Exception("Data = null");
            return data;
        }

        [HttpPost, Route("Datas/{Name}")]
        public void AddData(int id, string name, double exchangeraites)
        {
            Data data = new Data { Id = id, Name = name, ExchangeRates= exchangeraites };

            _datas.Add(data);
            XmlSerializer serializer = new XmlSerializer(typeof(Data));
            using (FileStream fs = new FileStream(PathXML, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, _datas);
            }
        }
    }
}
