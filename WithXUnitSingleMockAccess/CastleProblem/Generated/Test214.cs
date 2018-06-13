using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test214
    {
        private readonly Mock<IClass214> aClass;

        public Test214()
        {
            this.aClass = new Mock<IClass214>();
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
