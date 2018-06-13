using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test853
    {
        private readonly Mock<IClass853> aClass;

        public Test853()
        {
            this.aClass = new Mock<IClass853>();
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
