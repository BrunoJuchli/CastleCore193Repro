using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test657
    {
        private readonly Mock<IClass657> aClass;

        public Test657()
        {
            this.aClass = new Mock<IClass657>();
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
