using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test652
    {
        private readonly Mock<IClass652> aClass;

        public Test652()
        {
            this.aClass = new Mock<IClass652>();
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
