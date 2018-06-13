using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test635
    {
        private readonly Mock<IClass635> aClass;

        public Test635()
        {
            this.aClass = new Mock<IClass635>();
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
