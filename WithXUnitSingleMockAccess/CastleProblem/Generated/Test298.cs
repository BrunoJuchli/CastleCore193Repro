using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test298
    {
        private readonly Mock<IClass298> aClass;

        public Test298()
        {
            this.aClass = new Mock<IClass298>();
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
