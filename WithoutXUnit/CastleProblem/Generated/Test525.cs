using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test525
    {
        private readonly Mock<IClass525> aClass;

        public Test525()
        {
            this.aClass = new Mock<IClass525>();
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
