
using Newtonsoft.Json;
namespace RefectionPractice
{
    class Car
    {
        [JsonProperty(Required = Required.Always)]
        public string Model { get; set; }
        public int Year { get; set; }
    }
}
