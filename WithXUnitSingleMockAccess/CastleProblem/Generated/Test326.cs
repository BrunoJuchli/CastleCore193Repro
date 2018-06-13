using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test326
    {
        private readonly Mock<IClass326> aClass;

        public Test326()
        {
            this.aClass = new Mock<IClass326>();
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
