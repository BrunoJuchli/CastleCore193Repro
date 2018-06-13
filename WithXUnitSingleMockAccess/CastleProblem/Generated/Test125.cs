using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test125
    {
        private readonly Mock<IClass125> aClass;

        public Test125()
        {
            this.aClass = new Mock<IClass125>();
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
