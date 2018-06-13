using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test482
    {
        private readonly Mock<IClass482> aClass;

        public Test482()
        {
            this.aClass = new Mock<IClass482>();
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
