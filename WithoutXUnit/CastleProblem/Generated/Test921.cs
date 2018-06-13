using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test921
    {
        private readonly Mock<IClass921> aClass;

        public Test921()
        {
            this.aClass = new Mock<IClass921>();
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
