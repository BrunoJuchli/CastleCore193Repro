using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test49
    {
        private readonly Mock<IClass49> aClass;

        public Test49()
        {
            this.aClass = new Mock<IClass49>();
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
