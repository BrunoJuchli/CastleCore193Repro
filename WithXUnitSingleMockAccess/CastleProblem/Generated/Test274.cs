using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test274
    {
        private readonly Mock<IClass274> aClass;

        public Test274()
        {
            this.aClass = new Mock<IClass274>();
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
