using System;
using System.Collections.Generic;
using System.IO;

namespace CourseProject
{
    public class ApplicationManager
    {
        private static readonly string APPLICATION_FILENAME;
        public static List<Application> Applications { get; set; }

        static ApplicationManager()
        {
            APPLICATION_FILENAME = "applications.txt";

            if (!File.Exists(APPLICATION_FILENAME))
            {
                File.Create(APPLICATION_FILENAME).Close();
            }

            ReadApplicationsFromFile();
        }

        private static void ReadApplicationsFromFile()
        {
            Applications = new List<Application>();

            string[] lines = File.ReadAllLines(APPLICATION_FILENAME);

            foreach (var line in lines)
            {
                var application = new Application();
                application.ReadFromFile(line);
                Applications.Add(application);
            }
        }

        public static void WriteApplicationsToFile()
        {
            using (var writer = new StreamWriter(APPLICATION_FILENAME, false))
            {
                foreach (var application in Applications)
                {
                    application.WriteToFile(writer);
                }
            }
        }

        public static void AddApplication(Application application)
        {
            Applications.Add(application);
        }

        public static void UpdateApplication(Application application)
        {
            for (int i = 0; i < Applications.Count; i++)
            {
                if (Applications[i].Id == application.Id)
                {
                    Applications[i] = application;
                }
            }
        }

        public static Application GetApplicationById(Guid id)
        {
            foreach (var application in Applications)
            {
                if (application.Id == id)
                {
                    return application;
                }
            }

            return null;
        }
    }
}
