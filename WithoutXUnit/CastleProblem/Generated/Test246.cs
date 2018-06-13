using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test246
    {
        private readonly Mock<IClass246> aClass;

        public Test246()
        {
            this.aClass = new Mock<IClass246>();
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
