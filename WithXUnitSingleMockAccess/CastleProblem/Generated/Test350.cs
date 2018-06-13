using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test350
    {
        private readonly Mock<IClass350> aClass;

        public Test350()
        {
            this.aClass = new Mock<IClass350>();
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
