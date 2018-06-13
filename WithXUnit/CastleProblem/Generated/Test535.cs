using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test535
    {
        private readonly Mock<IClass535> aClass;

        public Test535()
        {
            this.aClass = new Mock<IClass535>();
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
