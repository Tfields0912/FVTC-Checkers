﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.PL.Test
{
    [TestClass]
    public class utGameState : utBase<tblGameState>
    {
        [TestMethod]
        public void LoadTest()
        {
            int expected = 5;
            var gamestates = base.LoadTest();
            Assert.AreEqual(expected, gamestates.Count);
        }

        [TestMethod]
        public void InsertTest()
        {

        }

        [TestMethod]
        public void UpdateTest()
        {

        }

        [TestMethod]
        public void DeleteTest()
        {

        }
    }
}
