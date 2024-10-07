class Costume {
    //Attributes(member vars)
   public string _headWear;
   public string _gloves;
   public string _shoes;
   public string _upperGrament;
   public string _lowerGarment;
   public string _accessory;

    //Behaviors
    public void ShowWardrobe() {
         string result = "";
         result += $"Head: {_headWear}\n";
         result += $"Hands: {_gloves}\n";
         result += $"Feet: {_shoes}\n";
         result += $"Torso: {_upperGrament}\n";
         result += $"Legs: {_lowerGarment}\n";
         result += $"Other: {_accessory}\n";
         Console.WriteLine(result);
    }
}
