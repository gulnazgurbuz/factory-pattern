using NUnit.Framework;

// ReSharper disable All
public class FactoryPatternTests {
    [Test]
    public void factory_creates_product() {
        var factory = new MockFactory();
        var product = factory.CreateProduct();
        Assert.IsNotNull(product, "Factory should create a product.");
    }

    [Test]
    public void product_initializes_correctly() {
        var product = new MockProduct();
        product.Initialize();
        Assert.IsTrue(((MockProduct)product).IsInitialized, "Product should be initialized.");
    }
}