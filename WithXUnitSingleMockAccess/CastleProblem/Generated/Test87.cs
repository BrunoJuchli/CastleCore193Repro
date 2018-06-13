using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test87
    {
        private readonly Mock<IClass87> aClass;

        public Test87()
        {
            this.aClass = new Mock<IClass87>();
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
