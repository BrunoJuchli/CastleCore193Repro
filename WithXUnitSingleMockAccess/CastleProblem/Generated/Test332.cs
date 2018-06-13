using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test332
    {
        private readonly Mock<IClass332> aClass;

        public Test332()
        {
            this.aClass = new Mock<IClass332>();
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
