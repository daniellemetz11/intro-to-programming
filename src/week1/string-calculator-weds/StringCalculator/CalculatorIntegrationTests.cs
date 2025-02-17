using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Logging;

namespace StringCalculator;
public class CalculatorIntegrationTests
{
  [Theory]
  [InlineData("1")]

  public void CallsLoggerWithResult(string numbers)
  {

    var mockedLogger = Substitute.For<ILogger>();

    var calculator = new Calculator(mockedLogger);

    var result = calculator.Add(numbers);

    mockedLogger.Received(1).Write(numbers);
  }


  [Theory]
  [InlineData("1")]

  public void WhenTheLoggerFailsCallAWebServiceToReportIt(string numbers)
  {
    var stubbedLogger = Substitute.For<ILogger>();
    var mockedWebService = Substitute.For<IWebService>();
    var message = Guid.NewGuid().ToString();


    stubbedLogger.When(c => c.Write(Arg.Any<string>())).Throw(new LoggingException("log file is full");

    var calculator = new Calculator(stubbedLogger, mockedWebService);

    calculator.Add(numbers);


    mockedWebService.Received(1).NotifyOfLoggingFailure(message);
  }
}
