using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test811
    {
        private readonly Mock<IClass811> aClass;

        public Test811()
        {
            this.aClass = new Mock<IClass811>();
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
