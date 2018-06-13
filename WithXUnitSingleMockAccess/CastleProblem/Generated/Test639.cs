using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test639
    {
        private readonly Mock<IClass639> aClass;

        public Test639()
        {
            this.aClass = new Mock<IClass639>();
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
