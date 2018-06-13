using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test646
    {
        private readonly Mock<IClass646> aClass;

        public Test646()
        {
            this.aClass = new Mock<IClass646>();
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
