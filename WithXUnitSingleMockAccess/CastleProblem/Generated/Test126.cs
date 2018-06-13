using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test126
    {
        private readonly Mock<IClass126> aClass;

        public Test126()
        {
            this.aClass = new Mock<IClass126>();
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
