using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test934
    {
        private readonly Mock<IClass934> aClass;

        public Test934()
        {
            this.aClass = new Mock<IClass934>();
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
