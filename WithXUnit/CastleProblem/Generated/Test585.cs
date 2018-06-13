using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test585
    {
        private readonly Mock<IClass585> aClass;

        public Test585()
        {
            this.aClass = new Mock<IClass585>();
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
