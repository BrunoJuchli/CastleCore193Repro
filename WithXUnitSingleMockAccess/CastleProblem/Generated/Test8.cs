using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test8
    {
        private readonly Mock<IClass8> aClass;

        public Test8()
        {
            this.aClass = new Mock<IClass8>();
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
