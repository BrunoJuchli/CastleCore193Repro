using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test827
    {
        private readonly Mock<IClass827> aClass;

        public Test827()
        {
            this.aClass = new Mock<IClass827>();
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
