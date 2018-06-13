using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test826
    {
        private readonly Mock<IClass826> aClass;

        public Test826()
        {
            this.aClass = new Mock<IClass826>();
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
