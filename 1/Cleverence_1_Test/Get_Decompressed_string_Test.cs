namespace Cleverence_1_Test
{
    public class Get_Decompressed_string_Test
    {
        [Fact]
        public void Decompressed_Test1()
        {
            string testString = "f4g5h3jk";
            string expected = "ffffggggghhhjk";
            string result = Cleverence_1.StringBuild.Get_Decompressed_string(testString);
            Assert.Equal(expected, result);
        }
    }
}