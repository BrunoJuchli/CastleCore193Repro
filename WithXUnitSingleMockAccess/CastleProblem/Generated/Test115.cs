using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test115
    {
        private readonly Mock<IClass115> aClass;

        public Test115()
        {
            this.aClass = new Mock<IClass115>();
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
