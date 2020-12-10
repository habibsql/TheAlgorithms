namespace TheAlgorithms.TreeRelated.Merge
{
    using FluentAssertions;
    using Xunit;

    public class BinaryTreeMergeTest
    {
        private readonly BinaryTreeMerge binaryTreeMerge;

        public BinaryTreeMergeTest()
        {
            binaryTreeMerge = new BinaryTreeMerge();
        }

        [Fact]
        public void Should_Merge_Two_BinaryTrees()
        {
            TreeNode ndLeft = TreeNode.CreateT1();
            TreeNode ndRight = TreeNode.CreteT2();

            TreeNode newNode = binaryTreeMerge.Merge(ndLeft, ndRight);

            newNode.val.Should().Equals(3);
        }
    }
}
