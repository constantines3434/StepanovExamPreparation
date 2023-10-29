using System.Xml.Serialization;

namespace Ex18
{
    [XmlRoot("Root")]
    public class Root
    {
        [XmlElement("Data")]
        public List<Data> Datas { get; set; }
    }
    public class Data
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double? ExchangeRates { get; set; }

        public Data() { }
        
    }
}
