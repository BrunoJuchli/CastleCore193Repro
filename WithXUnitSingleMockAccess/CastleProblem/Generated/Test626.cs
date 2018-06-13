using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test626
    {
        private readonly Mock<IClass626> aClass;

        public Test626()
        {
            this.aClass = new Mock<IClass626>();
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
