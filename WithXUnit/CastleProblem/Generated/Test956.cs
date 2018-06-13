using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test956
    {
        private readonly Mock<IClass956> aClass;

        public Test956()
        {
            this.aClass = new Mock<IClass956>();
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
