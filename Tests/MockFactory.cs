using GG.DesignPatterns.FactoryPattern;

public class MockFactory : BaseFactory {
    public override IProduct CreateProduct() {
        return new MockProduct();
    }
}