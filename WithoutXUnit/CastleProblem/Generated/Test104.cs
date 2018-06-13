using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test104
    {
        private readonly Mock<IClass104> aClass;

        public Test104()
        {
            this.aClass = new Mock<IClass104>();
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
