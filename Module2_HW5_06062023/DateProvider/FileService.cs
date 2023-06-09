namespace Module2_HW5_06062023.DateProvider
{
    using System;
    using System.IO;
    using Module2_HW5_06062023.Interfaces;
    using Module2_HW5_06062023.Json;
    using Newtonsoft.Json;

    public class FileService : IDataProvider
    {
        public void WriteIntoFile(Logger logger)
        {
            const string ConfFilePath = "C:\\Users\\add\\source\\repos" +
                "\\Module2_HW5_06062023\\Module2_HW5_06062023\\Json" +
                "\\ConfigLogFile.json";

            var configFile = File.ReadAllText(ConfFilePath);
            var configJSON = JsonConvert.DeserializeObject<Config>(configFile);

            string[] filesInDir = Directory.GetFiles(
                configJSON.Logger.DirectoryPath);

            if (filesInDir.Length >= 3)
            {
                int indexOlderFile = 0;
                DateTime creationTime = File.GetCreationTime(
                    filesInDir[indexOlderFile]);

                for (int i = 1; i < filesInDir.Length; i++)
                {
                    if (creationTime > File.GetCreationTime(
                    filesInDir[i]))
                    {
                        creationTime = File.GetCreationTime(
                        filesInDir[i]);
                        indexOlderFile = i;
                    }
                }

                File.Delete(filesInDir[indexOlderFile]);
            }

            string path = $"{configJSON.Logger.DirectoryPath}" +
                $"\\{DateTime.Now.ToString("hh.mm.ss dd.MM.yyyy")}" +
                $"{configJSON.Logger.FileExtension}";

            File.WriteAllText(
                path,
                string.Join(
                    configJSON.Logger.LineSeparator.ToString(),
                    logger.Logs));
        }
    }
}
