using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test612
    {
        private readonly Mock<IClass612> aClass;

        public Test612()
        {
            this.aClass = new Mock<IClass612>();
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
