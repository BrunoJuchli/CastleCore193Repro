using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test301
    {
        private readonly Mock<IClass301> aClass;

        public Test301()
        {
            this.aClass = new Mock<IClass301>();
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
