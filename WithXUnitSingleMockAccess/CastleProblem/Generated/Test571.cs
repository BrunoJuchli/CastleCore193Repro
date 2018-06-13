using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test571
    {
        private readonly Mock<IClass571> aClass;

        public Test571()
        {
            this.aClass = new Mock<IClass571>();
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
