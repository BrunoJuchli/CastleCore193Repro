using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test200
    {
        private readonly Mock<IClass200> aClass;

        public Test200()
        {
            this.aClass = new Mock<IClass200>();
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
