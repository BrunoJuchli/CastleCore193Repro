using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test227
    {
        private readonly Mock<IClass227> aClass;

        public Test227()
        {
            this.aClass = new Mock<IClass227>();
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
