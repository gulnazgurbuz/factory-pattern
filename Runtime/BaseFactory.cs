namespace GG.DesignPatterns.FactoryPattern {
    public abstract class BaseFactory : IFactory {
        public abstract IProduct CreateProduct();
    }
}