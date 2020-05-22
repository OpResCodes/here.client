using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Here.Client
{
    public class ApiKeys
    {
        public string AppId { get; set; }
        public string ApiKey { get; set; }

        public static ApiKeys LoadFromJson(string filePath)
        {
            using (var file = File.OpenText(filePath))
            {
                using (var reader = new JsonTextReader(file))
                {
                    var jsonSerializer = new JsonSerializer();
                    return jsonSerializer.Deserialize<ApiKeys>(reader);
                }
            }
        }

    }
}
