using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test2
    {
        private readonly Mock<IClass2> aClass;

        public Test2()
        {
            this.aClass = new Mock<IClass2>();
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
