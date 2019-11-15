using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ProtoBusiness;
using ProtoEntity;

namespace ProtoService
{
    /// <summary>
    /// Summary description for TemperatureConverter
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
    // [System.Web.Script.Services.ScriptService]
    public class TemperatureConverter : System.Web.Services.WebService
    {
        [WebMethod]
        public TemperatureUnit ConvertFahrenheitToCelcius(double fahrenheit)
        {
            var temperatureConverter = new ProtoBusiness.TemperatureConverter();

            var celcius = temperatureConverter.ConvertFahrenheitToCelcius(fahrenheit);

            return new TemperatureUnit()
            {
                Value = celcius,
                UnitShortName = nameof(Unit.Celcius).Substring(0, 1),
                Unit = Unit.Celcius
            };
        }

        [WebMethod]
        public double ConvertCelciusToFahreheit(double celcius)
        {
            var temperatureConverter = new ProtoBusiness.TemperatureConverter();

            return temperatureConverter.ConvertCelciusToFahrenheit(celcius);
        }
    }
}