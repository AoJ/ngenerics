/*  
  Copyright 2007-2010 The NGenerics Team
 (http://code.google.com/p/ngenerics/wiki/Team)

 This program is licensed under the GNU Lesser General Public License (LGPL).  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at http://www.gnu.org/copyleft/lesser.html.
*/
using System;
using NGenerics.DataStructures.General;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.General.AutoKeyDictionaryTests
{
    [TestFixture]
    public class Construction
    {
        [Test]
        public void Simple()
        {
            new AutoKeyDictionary<string, int>(x => x.ToString());
        }

        [Test]
        public void Comparer()
        {
            new AutoKeyDictionary<string, int>(x => x.ToString(), StringComparer.InvariantCultureIgnoreCase);
        }

        [Test]
        public void CapacityComparer()
        {
            var target = new AutoKeyDictionary<string, int>(x => x.ToString(), StringComparer.InvariantCultureIgnoreCase, 1);
            Assert.AreEqual(StringComparer.InvariantCultureIgnoreCase, target.Comparer);
        }
    }
}