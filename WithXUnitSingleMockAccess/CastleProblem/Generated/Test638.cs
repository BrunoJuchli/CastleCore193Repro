using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test638
    {
        private readonly Mock<IClass638> aClass;

        public Test638()
        {
            this.aClass = new Mock<IClass638>();
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
