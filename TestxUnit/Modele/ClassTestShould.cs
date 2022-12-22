using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestxUnit.Modele
{
    //Inspiré du laboratoire Xunit
    public class ClassTestShould
    {
        [Fact]
        public void TestTrue()
        {
            Assert.True(true);
        }

        /// <summary>
        /// Test d'une méthode Addition qui additionne
        /// deux nombres et retourne la somme
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        [Theory]
        [InlineData(20, 12)]
        public double Addition(double a, double b)
        {
            Assert.True(true);
            return a + b;
        }

        /// <summary>
        /// Test d'une méthode Soustraction qui soustrait
        /// deux nombres et retourne la différence
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        [Theory]
        [InlineData(30, 15)]
        public double Soustraction(double a, double b)
        {
            Assert.True(true);
            return a - b;
        }
    }
}
