using System;
using System.IO;
using System.Text;
using ChristmasTreeBuilder;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TreeBuilderUnitTests
{
    [TestClass]
    public class TreeBuilderTests
    {
        [TestMethod]
        public void Print_WithHeightZero_PrintNothing()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                TreeBuilder treeBuilder = new TreeBuilder();

                treeBuilder.Print(0);

                string expected = "";
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }

        [TestMethod]
        public void Print_WithHeightOne_PrintOneAsteriskOneRow()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                TreeBuilder treeBuilder = new TreeBuilder();

                treeBuilder.Print(1);

                string expected = string.Format("*{0}", Environment.NewLine);
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }

        [TestMethod]
        public void Print_WithHeightFive_PrintTree()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                TreeBuilder treeBuilder = new TreeBuilder();

                treeBuilder.Print(5);

                StringBuilder sb = new StringBuilder();
                sb.Append(string.Format("    *{0}", Environment.NewLine));
                sb.Append(string.Format("   ***{0}", Environment.NewLine));
                sb.Append(string.Format("  *****{0}", Environment.NewLine));
                sb.Append(string.Format(" *******{0}", Environment.NewLine));
                sb.Append(string.Format("*********{0}", Environment.NewLine));

                string expected = sb.ToString();
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }

        [TestMethod]
        public void Print_WithHeightSix_PrintTree()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                TreeBuilder treeBuilder = new TreeBuilder();

                treeBuilder.Print(6);

                StringBuilder sb = new StringBuilder();
                sb.Append(string.Format("     *{0}", Environment.NewLine));
                sb.Append(string.Format("    ***{0}", Environment.NewLine));
                sb.Append(string.Format("   *****{0}", Environment.NewLine));
                sb.Append(string.Format("  *******{0}", Environment.NewLine));
                sb.Append(string.Format(" *********{0}", Environment.NewLine));
                sb.Append(string.Format("***********{0}", Environment.NewLine));


                string expected = sb.ToString();
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }
    }
}
