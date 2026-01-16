using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleverence_1_Test
{
    public class Compressed_string_Test
    {
        [Fact]
        public void Compressed_Test1()
        {
            string testString = "ffffggggghhhjkbbbbb";
            string expected = "f4g5h3jkb5";
            string result = Cleverence_1.StringBuild.Get_Compressed_string(testString);
            Assert.Equal(expected, result);
        }
    }
}
