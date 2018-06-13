using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test575
    {
        private readonly Mock<IClass575> aClass;

        public Test575()
        {
            this.aClass = new Mock<IClass575>();
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
