using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test478
    {
        private readonly Mock<IClass478> aClass;

        public Test478()
        {
            this.aClass = new Mock<IClass478>();
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
