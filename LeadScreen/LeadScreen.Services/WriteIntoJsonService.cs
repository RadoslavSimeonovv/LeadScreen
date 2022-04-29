using LeadScreen.Services.Contracts;
using System.IO;
using System.Text.Json;

namespace LeadScreen.Services
{
    /// <summary>
    /// Service for using the local json storage to write new lead in
    /// </summary>
    public class WriteIntoJsonService : IWriteIntoJsonService
    {
        public void Write(object obj, string fileName)
        {
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            var jsonString = JsonSerializer.Serialize(obj, options);
            File.WriteAllText(fileName, jsonString);
        }
    }
}
