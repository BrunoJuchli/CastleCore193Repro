using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test475
    {
        private readonly Mock<IClass475> aClass;

        public Test475()
        {
            this.aClass = new Mock<IClass475>();
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
