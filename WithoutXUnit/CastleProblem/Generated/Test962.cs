using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test962
    {
        private readonly Mock<IClass962> aClass;

        public Test962()
        {
            this.aClass = new Mock<IClass962>();
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
