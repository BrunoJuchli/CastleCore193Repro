using System;
using System.Diagnostics;
using Moq;

namespace NetCoreRepro.ToDuplicate
{
    public class Test472
    {
        private readonly Mock<IClass472> aClass;

        public Test472()
        {
            this.aClass = new Mock<IClass472>();
        }

        public void DoSomething()
        {
            try
            {
                this.aClass.Setup(x => x.DoSomething()).Returns(true);
                bool result = this.aClass.Object.DoSomething();
            }
            catch (BadImageFormatException)
            {
                Debugger.Launch();
            }
        }
    }
}
