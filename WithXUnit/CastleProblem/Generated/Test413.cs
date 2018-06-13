using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test413
    {
        private readonly Mock<IClass413> aClass;

        public Test413()
        {
            this.aClass = new Mock<IClass413>();
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
