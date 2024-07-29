namespace CardApp.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        Shoe shoe= new Shoe(1);
        Shoe shoe2= new Shoe(2);
        Shoe shoe3= new Shoe(3);
        Assert.AreEqual(52, shoe.AllCards.Count);
        Assert.AreEqual(104, shoe2.AllCards.Count);
        Assert.AreEqual(156, shoe3.AllCards.Count);
    }
    [TestMethod]
    public void TestMethod2()
    {
        Shoe shoe= new Shoe(1);
        shoe.Shuffle();
        shoe.DealOneCard();
        
        Assert.AreNotEqual(52, shoe.AllCards.Count);
        
    }
    [TestMethod]
    public void TestMethod3()
    {
        int shoeCount = 8 * 52;
        Shoe shoe= new Shoe(8);
        shoe.DealMultipleCards(24);
        shoeCount -= 24;
        
        
        Assert.AreEqual(shoeCount, shoe.AllCards.Count);
        
    }

    [TestMethod]
    public void TestMethod4()
{
    int nonRandomCount = 0;
    Shoe shoe1 = new Shoe(1);
    Shoe shoe2 = new Shoe(1);
    shoe2.Shuffle();

    for (int i = 0; i < 52; i++)
    {
        if (shoe1.AllCards[i].Rank == shoe2.AllCards[i].Rank &&
            shoe1.AllCards[i].Suit == shoe2.AllCards[i].Suit)
        {
            nonRandomCount++;
        }
    }

    Assert.AreEqual(shoe1.AllCards.Count, shoe2.AllCards.Count);
    Assert.IsTrue(nonRandomCount < 20, "Shuffle not random enough");
}
}