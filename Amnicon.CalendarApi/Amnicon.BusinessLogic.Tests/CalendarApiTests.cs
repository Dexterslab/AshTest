using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Amnicon.BusinessLogic.Tests
{
    [TestClass]
    public class CalendarApiTests   
    {
        // I added unit tests project for only Business layer because that's where the real business logic should stay and unit tests will 
        // make more sense here. the rest of the layers going be pass DTO around based on N-tier architecture. 
        

        [TestMethod]
        public void CalendarServiceTests()
        {
            // Unit tests here

    // FOR Mocks I would use MOQ framework here. 




        }
    }
}
