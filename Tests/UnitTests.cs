namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Rish()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Rish()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Rish()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}
}



[TestClass]
public class Power
{
    [TestMethod]
    public void Power_Valid_Rish()
    {
        Assert.AreEqual(8.0, Program.Power("2", "3"));
        Assert.AreEqual(25.0, Program.Power("5", "2"));
        Assert.AreEqual(1.0, Program.Power("7", "0"));
        Assert.AreEqual(0.125, Program.Power("2", "-3"));
    }

    [TestMethod]
    public void Power_Invalid_Rish()
    {
        Assert.ThrowsException<FormatException>(() => Program.Power("2", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Power("a", "2"));
        Assert.ThrowsException<FormatException>(() => Program.Power("a", "b"));
    }

    [TestMethod]
    public void Power_Null_Rish()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power("2", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "2"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, null));
    }
}

[TestClass]
public class Subtraction
{
    [TestMethod]
    public void Subtract_Valid_Rish()
    {
        Assert.AreEqual(1.0, Program.Subtract("3", "2"));
        Assert.AreEqual(-2.0, Program.Subtract("3", "5"));
        Assert.AreEqual(0.0, Program.Subtract("5", "5"));
    }

    [TestMethod]
    public void Subtract_Invalid_Rish()
    {
        Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "1"));
    }

    [TestMethod]
    public void Subtract_Null_Rish()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "1"));
    }
}

[TestClass]
public class Multiplication
{
    [TestMethod]
    public void Multiply_Valid_Rish()
    {
        Assert.AreEqual(6.0, Program.Multiply("2", "3"));
        Assert.AreEqual(-10.0, Program.Multiply("-2", "5"));
        Assert.AreEqual(0.0, Program.Multiply("0", "5"));
    }

    [TestMethod]
    public void Multiply_Invalid_Rish()
    {
        Assert.ThrowsException<FormatException>(() => Program.Multiply("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "1"));
    }

    [TestMethod]
    public void Multiply_Null_Rish()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "1"));
    }
}

[TestClass]
public class Division
{
    [TestMethod]
    public void Divide_Valid_Rish()
    {
        Assert.AreEqual(2.0, Program.Divide("6", "3"));
        Assert.AreEqual(-2.0, Program.Divide("6", "-3"));
        Assert.AreEqual(0.0, Program.Divide("0", "5"));
    }

    [TestMethod]
    public void Divide_Invalid_Rish()
    {
        Assert.ThrowsException<FormatException>(() => Program.Divide("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("a", "1"));
    }

    [TestMethod]
    public void Divide_Null_Rish()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "1"));
    }
}
