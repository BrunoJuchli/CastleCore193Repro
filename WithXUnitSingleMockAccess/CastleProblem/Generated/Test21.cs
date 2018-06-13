using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test21
    {
        private readonly Mock<IClass21> aClass;

        public Test21()
        {
            this.aClass = new Mock<IClass21>();
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
