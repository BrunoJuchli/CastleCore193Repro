using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test966
    {
        private readonly Mock<IClass966> aClass;

        public Test966()
        {
            this.aClass = new Mock<IClass966>();
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
