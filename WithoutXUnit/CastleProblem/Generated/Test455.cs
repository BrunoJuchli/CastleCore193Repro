using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test455
    {
        private readonly Mock<IClass455> aClass;

        public Test455()
        {
            this.aClass = new Mock<IClass455>();
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
