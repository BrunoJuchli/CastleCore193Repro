using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test818
    {
        private readonly Mock<IClass818> aClass;

        public Test818()
        {
            this.aClass = new Mock<IClass818>();
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
