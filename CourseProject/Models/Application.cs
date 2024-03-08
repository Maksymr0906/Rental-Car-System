using System;
using System.IO;
using System.Windows.Forms;

namespace CourseProject
{
    public sealed class Application : Entity
    {
        public enum ApplicationType
        {
            ORDER_CAR,
            RENT_ENDED,
        }
        public Guid OrderId { get; set; }
        public string RejectionComment { get; set; }
        public ApplicationType Type { get; set; }

        public override void ReadFromFile(string line)
        {
            base.ReadFromFile(line);
            string[] parts = line.Split(',');
            OrderId = Guid.Parse(parts[2]);
            RejectionComment = parts[3];
            Type = (ApplicationType)Enum.Parse(typeof(ApplicationType), parts[4]);
        }

        public override void WriteToFile(StreamWriter writer)
        {
            base.WriteToFile(writer);
            writer.WriteLine($",{OrderId},{RejectionComment},{Type}");
        }

        private static Application firstApplication;
        private Application Next { get; set; }
        public static void AddApplication(Application newApplication)
        {
            if (firstApplication == null)
            {
                firstApplication = newApplication;
            }
            else
            {
                Application current = firstApplication;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newApplication;
            }
        }

        public static void ViewApplications()
        {
            Application current = firstApplication;
            while (current != null)
            {
                MessageBox.Show($"OrderId: {current.OrderId}, RejectionComment: {current.RejectionComment}, Type: {current.Type}");
                current = current.Next;
            }
        }
    }
}
