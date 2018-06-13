using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test625
    {
        private readonly Mock<IClass625> aClass;

        public Test625()
        {
            this.aClass = new Mock<IClass625>();
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
