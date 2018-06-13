using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test930
    {
        private readonly Mock<IClass930> aClass;

        public Test930()
        {
            this.aClass = new Mock<IClass930>();
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
