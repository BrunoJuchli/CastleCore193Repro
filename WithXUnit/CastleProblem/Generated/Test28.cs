using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test28
    {
        private readonly Mock<IClass28> aClass;

        public Test28()
        {
            this.aClass = new Mock<IClass28>();
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
