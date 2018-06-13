using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test851
    {
        private readonly Mock<IClass851> aClass;

        public Test851()
        {
            this.aClass = new Mock<IClass851>();
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
