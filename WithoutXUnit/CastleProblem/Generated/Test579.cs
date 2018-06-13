using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test579
    {
        private readonly Mock<IClass579> aClass;

        public Test579()
        {
            this.aClass = new Mock<IClass579>();
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
