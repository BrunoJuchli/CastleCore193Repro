using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test782
    {
        private readonly Mock<IClass782> aClass;

        public Test782()
        {
            this.aClass = new Mock<IClass782>();
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
