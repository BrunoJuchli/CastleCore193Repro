using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test819
    {
        private readonly Mock<IClass819> aClass;

        public Test819()
        {
            this.aClass = new Mock<IClass819>();
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
