using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test796
    {
        private readonly Mock<IClass796> aClass;

        public Test796()
        {
            this.aClass = new Mock<IClass796>();
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
