using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test387
    {
        private readonly Mock<IClass387> aClass;

        public Test387()
        {
            this.aClass = new Mock<IClass387>();
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
