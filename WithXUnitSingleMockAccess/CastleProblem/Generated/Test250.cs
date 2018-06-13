using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test250
    {
        private readonly Mock<IClass250> aClass;

        public Test250()
        {
            this.aClass = new Mock<IClass250>();
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
