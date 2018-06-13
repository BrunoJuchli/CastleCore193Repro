using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test771
    {
        private readonly Mock<IClass771> aClass;

        public Test771()
        {
            this.aClass = new Mock<IClass771>();
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
