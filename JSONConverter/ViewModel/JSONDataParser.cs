using JSONConverter.Model;
using System.IO;

namespace JSONConverter.ViewModel
{
    class JSONDataParser
    {
        JSONData _jsonData;
        public JSONDataParser(JSONData jsonData)
        {
            _jsonData = jsonData;
        }
        public void ReadJSONFile(string fileName)
        {
            using var reader = new StreamReader(fileName);
            _jsonData.JSONContent = reader.ReadToEnd();
        }
    }
}
