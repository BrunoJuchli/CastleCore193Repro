using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test45
    {
        private readonly Mock<IClass45> aClass;

        public Test45()
        {
            this.aClass = new Mock<IClass45>();
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
