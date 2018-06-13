using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test108
    {
        private readonly Mock<IClass108> aClass;

        public Test108()
        {
            this.aClass = new Mock<IClass108>();
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
