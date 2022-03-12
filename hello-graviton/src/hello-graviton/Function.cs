using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace helloGraviton
{
    public class Function
    {

        /// <summary>
        /// A simple function that takes a temperature in degrees Celsius and returns a conversion to degrees Fahrehneit.
        /// </summary>
        /// <param name="input">degrees Celsius</param>
        /// <param name="context"></param>
        /// <returns>degrees Fahrenheit</returns>
        public double FunctionHandler(double degreesC, ILambdaContext context)
        {
            return (degreesC * 9/5) + 32;
        }
    }
}