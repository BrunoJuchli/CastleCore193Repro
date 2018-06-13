using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test703
    {
        private readonly Mock<IClass703> aClass;

        public Test703()
        {
            this.aClass = new Mock<IClass703>();
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
