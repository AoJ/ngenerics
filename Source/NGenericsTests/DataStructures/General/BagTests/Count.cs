/*  
  Copyright 2007-2010 The NGenerics Team
 (http://code.google.com/p/ngenerics/wiki/Team)

 This program is licensed under the GNU Lesser General Public License (LGPL).  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at http://www.gnu.org/copyleft/lesser.html.
*/
using NGenerics.DataStructures.General;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.General.BagTests
{
    [TestFixture]
    public class Count : BagTest
    {

        [Test]
        public void Simple()
        {
            var bag = GetTestBag();
            Assert.AreEqual(bag.Count, 35);
            Assert.IsFalse(bag.IsEmpty);

            bag = new Bag<string>();
            Assert.AreEqual(bag.Count, 0);
            Assert.IsTrue(bag.IsEmpty);

            bag.Add("aa");
            Assert.AreEqual(bag.Count, 1);
            Assert.IsFalse(bag.IsEmpty);

            bag.Add("aa");
            Assert.AreEqual(bag.Count, 2);
            Assert.IsFalse(bag.IsEmpty);

            bag.Add("bb");
            Assert.AreEqual(bag.Count, 3);
            Assert.IsFalse(bag.IsEmpty);
        }
    }
}