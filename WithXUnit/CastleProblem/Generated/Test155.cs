using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test155
    {
        private readonly Mock<IClass155> aClass;

        public Test155()
        {
            this.aClass = new Mock<IClass155>();
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
