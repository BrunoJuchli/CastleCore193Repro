using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test1
    {
        private readonly Mock<IClass1> aClass;

        public Test1()
        {
            this.aClass = new Mock<IClass1>();
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
