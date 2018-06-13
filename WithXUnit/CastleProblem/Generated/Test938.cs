using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test938
    {
        private readonly Mock<IClass938> aClass;

        public Test938()
        {
            this.aClass = new Mock<IClass938>();
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
