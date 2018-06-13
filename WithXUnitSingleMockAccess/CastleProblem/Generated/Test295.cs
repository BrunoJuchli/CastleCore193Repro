using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test295
    {
        private readonly Mock<IClass295> aClass;

        public Test295()
        {
            this.aClass = new Mock<IClass295>();
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
