/*  
  Copyright 2007-2010 The NGenerics Team
 (http://code.google.com/p/ngenerics/wiki/Team)

 This program is licensed under the GNU Lesser General Public License (LGPL).  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at http://www.gnu.org/copyleft/lesser.html.
*/
using NGenerics.DataStructures.Mathematical;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Mathematical.MatrixTests
{
    [TestFixture]
    public class IsSquare
    {

        [Test]
        public void Simple()
        {
            var matrix = new Matrix(10, 10);

            Assert.IsTrue(matrix.IsSquare);

            matrix = new Matrix(3, 4);
            Assert.IsFalse(matrix.IsSquare);

            matrix = new Matrix(35, 35);
            Assert.IsTrue(matrix.IsSquare);

            matrix = new Matrix(45, 44);
            Assert.IsFalse(matrix.IsSquare);
        }

    }
}