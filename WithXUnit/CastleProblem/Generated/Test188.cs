using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test188
    {
        private readonly Mock<IClass188> aClass;

        public Test188()
        {
            this.aClass = new Mock<IClass188>();
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
