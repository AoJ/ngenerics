/*  
  Copyright 2007-2010 The NGenerics Team
 (http://code.google.com/p/ngenerics/wiki/Team)

 This program is licensed under the GNU Lesser General Public License (LGPL).  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at http://www.gnu.org/copyleft/lesser.html.
*/
using System;
using NGenerics.DataStructures.Trees;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Trees.GeneralTreeTests
{
    [TestFixture]
    public class Index : GeneralTreeTest
    {

        [Test]
        public void Simple()
        {
            var generalTree = GetTestTree();
            Assert.AreEqual(generalTree[0].Data, 2);
            Assert.AreEqual(generalTree[1].Data, 3);
            Assert.AreEqual(generalTree[2].Data, 1);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ExceptionInvalidIndex1()
        {
            var root = new GeneralTree<int>(5);

            var child1 = new GeneralTree<int>(2);
            var child2 = new GeneralTree<int>(3);

            root.Add(child1);
            root.Add(child2);

            var i = root[3].Data;
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ExceptionInvalidIndex2()
        {
            var root = new GeneralTree<int>(5);
            var i = root[0].Data;
        }

    }
}