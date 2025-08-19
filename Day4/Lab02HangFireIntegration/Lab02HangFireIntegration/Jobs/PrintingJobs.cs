namespace Lab02HangFireIntegration.Jobs
{
    public class PrintingJobs
    {

        public void HelloWorld(string message) {

            Console.WriteLine(DateTime.UtcNow);
            Console.WriteLine(message);
        }
    }
}
