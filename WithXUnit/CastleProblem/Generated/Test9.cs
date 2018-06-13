using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test9
    {
        private readonly Mock<IClass9> aClass;

        public Test9()
        {
            this.aClass = new Mock<IClass9>();
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
