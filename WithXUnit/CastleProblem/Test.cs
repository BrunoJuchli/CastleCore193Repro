using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test
    {
        private readonly Mock<IClass> aClass;

        public Test()
        {
            this.aClass = new Mock<IClass>();
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