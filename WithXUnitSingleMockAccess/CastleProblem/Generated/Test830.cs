using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test830
    {
        private readonly Mock<IClass830> aClass;

        public Test830()
        {
            this.aClass = new Mock<IClass830>();
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
