using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test877
    {
        private readonly Mock<IClass877> aClass;

        public Test877()
        {
            this.aClass = new Mock<IClass877>();
        }

        [Theory]
        [InlineData(true)]
        public void DoSomething(bool value)
        {
            this.aClass.Setup(x => x.DoSomething()).Returns(value);

            Assert.Equal(this.aClass.Object.DoSomething(), value);
        }
    }
}
