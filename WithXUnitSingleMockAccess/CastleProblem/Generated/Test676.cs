using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test676
    {
        private readonly Mock<IClass676> aClass;

        public Test676()
        {
            this.aClass = new Mock<IClass676>();
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
