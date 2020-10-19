using System;

namespace ReadOutLibrary
{
    public class ReadOut
    {

        public int SensorId { get; set; }
        public string LokaleId { get; set; }
        public float Temp { get; set; }
        public int Fugt { get; set; }
        public int COtwo { get; set; }
        public int Tryk { get; set; }


        public ReadOut()
        {

        }

        public override string ToString()
        {
            return $"SensorId: {SensorId}, LokaleId: {LokaleId}, Temp: {Temp}, Fugt: {Fugt}, COtwo: {COtwo}, Tryk: {Tryk}";
        }
    }
}
