class Bin {
    //Attributes
    private string _denomination;
    private float _value;
    private int _quantity;

    //Constructor
    public Bin(string denomination, float value, int quantity) {
        _denomination = denomination;
        _value = value;
        _quantity = quantity;
    }

    //Methods
    public void ModifyQuantity(int exchange)  {
        _quantity += exchange;
    }

    public float CountValue() {
        return _quantity * _value;
    }
}
