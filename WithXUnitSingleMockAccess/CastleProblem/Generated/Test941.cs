using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test941
    {
        private readonly Mock<IClass941> aClass;

        public Test941()
        {
            this.aClass = new Mock<IClass941>();
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
