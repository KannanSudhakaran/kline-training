namespace Lab03ControllerAndActions.Services
{
    public class DataService : IDataService
    {

        public string GetData()
        {

            var luckyNumber = new Random().Next(1, 100);
            return "Your lucky number is " + luckyNumber;

        }
    }
}
