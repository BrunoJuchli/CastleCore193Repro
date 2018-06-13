using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test824
    {
        private readonly Mock<IClass824> aClass;

        public Test824()
        {
            this.aClass = new Mock<IClass824>();
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
