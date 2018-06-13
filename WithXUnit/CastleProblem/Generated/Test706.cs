using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test706
    {
        private readonly Mock<IClass706> aClass;

        public Test706()
        {
            this.aClass = new Mock<IClass706>();
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void DoSomething(bool value)
        {
            this.aClass.Setup(x => x.DoSomething()).Returns(value);

            Assert.Equal(this.aClass.Object.DoSomething(), value);
        }
    }
}
