namespace Module2_HW5_06062023.DateProvider
{
    using System.IO;
    using Module2_HW5_06062023.Interfaces;
    using Module2_HW5_06062023.Json;
    using Newtonsoft.Json;

    internal class FileService : IDataProvider
    {
        public void WriteIntoFile(Logger logger)
        {
            var configFile = File.ReadAllText("ConfigLogFile.json");
            var configJSON = JsonConvert.DeserializeObject<Config>(configFile);

            File.WriteAllText("log.txt", string.Join(((char)10).ToString(), logger.Logs));
        }
    }
}
