using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test461
    {
        private readonly Mock<IClass461> aClass;

        public Test461()
        {
            this.aClass = new Mock<IClass461>();
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
