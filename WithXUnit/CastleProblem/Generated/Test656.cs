using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test656
    {
        private readonly Mock<IClass656> aClass;

        public Test656()
        {
            this.aClass = new Mock<IClass656>();
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
