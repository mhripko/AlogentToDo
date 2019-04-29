using AlogentToDo.Properties;

namespace AlogentToDo
{
    /// <summary>
    /// The Settings Service is used to set Application and/or User specific settings.
    /// 
    /// Since these settings are specific to this assembly, it's marked internal!
    /// </summary>
    internal class SettingsService : ISettingsService
    {
        public bool FirstRun
        {
            get { return Settings.Default.FirstRun; }
            set { Settings.Default.FirstRun = value; }
        }

        /// <summary>
        /// Save the settings...
        /// </summary>
        public void Save()
        {
            Settings.Default.Save();
        }

        /// <summary>
        /// ToDoFileName will return the filename holding the ToDo list.
        /// </summary>
        public string ToDoFileName
        {
            get { return Settings.Default.ToDoFileName; }
        }
    }

    /// <summary>
    /// The SettingsService interface. For clarity and simplicity, it's included in the SettingsService code file
    /// but in a production app would be in it's own interface file.
    /// </summary>
    internal interface ISettingsService
    {
        bool FirstRun { get; set; }
        void Save();
        string ToDoFileName { get; }
    }
}
