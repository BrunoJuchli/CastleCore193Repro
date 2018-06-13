using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test754
    {
        private readonly Mock<IClass754> aClass;

        public Test754()
        {
            this.aClass = new Mock<IClass754>();
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
