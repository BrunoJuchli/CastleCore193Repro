using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test86
    {
        private readonly Mock<IClass86> aClass;

        public Test86()
        {
            this.aClass = new Mock<IClass86>();
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
