class Cashregister {
    static void Main(string[] args) {
        Bin  myBin = new("quarters", (float)0.25, 40);
        myBin.ModifyQuantity(+6);
        Console.WriteLine(myBin.CountValue());
    }
}
