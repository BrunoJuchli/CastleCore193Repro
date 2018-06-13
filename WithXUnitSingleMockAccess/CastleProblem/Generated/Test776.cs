using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test776
    {
        private readonly Mock<IClass776> aClass;

        public Test776()
        {
            this.aClass = new Mock<IClass776>();
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
