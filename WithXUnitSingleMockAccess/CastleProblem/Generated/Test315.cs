using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test315
    {
        private readonly Mock<IClass315> aClass;

        public Test315()
        {
            this.aClass = new Mock<IClass315>();
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
