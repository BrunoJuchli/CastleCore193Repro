using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test372
    {
        private readonly Mock<IClass372> aClass;

        public Test372()
        {
            this.aClass = new Mock<IClass372>();
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
