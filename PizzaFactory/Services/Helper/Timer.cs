namespace PizzaFactory.Services.Helper
{
    class Timer : ITimer
    {
        public void Delay(int durationInMilliseconds)
        {
            System.Threading.Thread.Sleep(durationInMilliseconds);
        }
    }
}