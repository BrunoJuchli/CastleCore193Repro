using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test940
    {
        private readonly Mock<IClass940> aClass;

        public Test940()
        {
            this.aClass = new Mock<IClass940>();
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
