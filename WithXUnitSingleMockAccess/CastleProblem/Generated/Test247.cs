using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test247
    {
        private readonly Mock<IClass247> aClass;

        public Test247()
        {
            this.aClass = new Mock<IClass247>();
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
