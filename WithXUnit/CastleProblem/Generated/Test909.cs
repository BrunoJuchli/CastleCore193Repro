using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test909
    {
        private readonly Mock<IClass909> aClass;

        public Test909()
        {
            this.aClass = new Mock<IClass909>();
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
