using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test401
    {
        private readonly Mock<IClass401> aClass;

        public Test401()
        {
            this.aClass = new Mock<IClass401>();
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
