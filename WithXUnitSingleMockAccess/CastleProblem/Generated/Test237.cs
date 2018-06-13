using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test237
    {
        private readonly Mock<IClass237> aClass;

        public Test237()
        {
            this.aClass = new Mock<IClass237>();
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
