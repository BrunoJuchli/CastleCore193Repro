using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test947
    {
        private readonly Mock<IClass947> aClass;

        public Test947()
        {
            this.aClass = new Mock<IClass947>();
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
