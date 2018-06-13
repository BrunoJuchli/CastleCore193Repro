using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test776
    {
        private readonly Mock<IClass776> aClass;

        public Test776()
        {
            this.aClass = new Mock<IClass776>();
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
