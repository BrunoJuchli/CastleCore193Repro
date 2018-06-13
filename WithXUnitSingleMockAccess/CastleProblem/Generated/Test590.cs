using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test590
    {
        private readonly Mock<IClass590> aClass;

        public Test590()
        {
            this.aClass = new Mock<IClass590>();
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
