using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test6
    {
        private readonly Mock<IClass6> aClass;

        public Test6()
        {
            this.aClass = new Mock<IClass6>();
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
