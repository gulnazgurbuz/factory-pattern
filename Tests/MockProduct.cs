using GG.DesignPatterns.FactoryPattern;

public class MockProduct : IProduct {
    public bool IsInitialized { get; private set; }

    public void Initialize() {
        IsInitialized = true;
    }
}