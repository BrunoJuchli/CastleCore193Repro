using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test344
    {
        private readonly Mock<IClass344> aClass;

        public Test344()
        {
            this.aClass = new Mock<IClass344>();
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
