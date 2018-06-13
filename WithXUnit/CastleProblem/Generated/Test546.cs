using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test546
    {
        private readonly Mock<IClass546> aClass;

        public Test546()
        {
            this.aClass = new Mock<IClass546>();
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
