using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test713
    {
        private readonly Mock<IClass713> aClass;

        public Test713()
        {
            this.aClass = new Mock<IClass713>();
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
