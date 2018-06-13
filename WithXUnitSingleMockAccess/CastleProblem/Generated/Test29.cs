using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test29
    {
        private readonly Mock<IClass29> aClass;

        public Test29()
        {
            this.aClass = new Mock<IClass29>();
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
