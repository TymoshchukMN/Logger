namespace Module2_HW5_06062023.DateProvider
{
    using System.IO;
    using Module2_HW5_06062023.Interfaces;

    internal class FileService : IDataProvider
    {
        public void WriteIntoFile(Logger logger)
        {
            File.WriteAllText("log.txt", string.Join(((char)10).ToString(), logger.Logs));
        }
    }
}
