using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test856
    {
        private readonly Mock<IClass856> aClass;

        public Test856()
        {
            this.aClass = new Mock<IClass856>();
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
