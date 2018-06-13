using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test742
    {
        private readonly Mock<IClass742> aClass;

        public Test742()
        {
            this.aClass = new Mock<IClass742>();
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
