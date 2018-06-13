using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test147
    {
        private readonly Mock<IClass147> aClass;

        public Test147()
        {
            this.aClass = new Mock<IClass147>();
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
