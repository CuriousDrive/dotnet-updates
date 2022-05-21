
// string weatherMessage = "\"TemperatureRanges\":\n" + 
//                         "{\n" +
//                         $"  \"High\" : {high}\n" +
//                         $"  \"Low\" : {low}\n" +
//                         "}";

int high = 70;
int low = 55;
string weatherMessage = $$"""
                        "TemperatureRanges":
                        {
                          "High" : {{high}}
                          "Low" : {{low}}
                        }
                        """;
Console.WriteLine(weatherMessage);