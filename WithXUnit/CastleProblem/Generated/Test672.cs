using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test672
    {
        private readonly Mock<IClass672> aClass;

        public Test672()
        {
            this.aClass = new Mock<IClass672>();
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void DoSomething(bool value)
        {
            this.aClass.Setup(x => x.DoSomething()).Returns(value);

            Assert.Equal(this.aClass.Object.DoSomething(), value);
        }
    }
}
