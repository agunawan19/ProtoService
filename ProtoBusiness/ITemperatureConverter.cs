namespace ProtoBusiness
{
    public interface ITemperatureConverter
    {
        double ConvertCelciusToFahrenheit(double celcius);
        double ConvertFahrenheitToCelcius(double fahrenheit);
    }
}