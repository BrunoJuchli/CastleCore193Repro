using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test94
    {
        private readonly Mock<IClass94> aClass;

        public Test94()
        {
            this.aClass = new Mock<IClass94>();
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
