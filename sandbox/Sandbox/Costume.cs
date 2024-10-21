class Program {
    static void Main(string[] args) {
        Cashregister nurse = new();
        nurse._headWear = "faced  mask";
        nurse._gloves = "nitrile";
        nurse._shoes = "orthopedic sneakers";
        nurse._upperGrament = "scrubs";
        nurse._lowerGarment = "scrubs";

       Cashregister detective = new();
       detective._headWear = "fedora";
       detective._gloves = "leather";
       detective._shoes = "loafers";
       detective._upperGrament = "trenchcoat";
       detective._lowerGarment = "slacks";
       detective._accessory = "slacks";
       detective._accessory = "magnifiyinglass";

       nurse.ShowWardrobe();
       detective.ShowWardrobe();
    }
}
